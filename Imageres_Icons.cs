using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Windows_Task_Dialog_Generator
{
    public partial class Imageres_Icons : Form
    {
        private readonly MainForm mainForm;
        private FlowLayoutPanel? previousPanelSelection = null;

        [LibraryImport("user32.dll", EntryPoint = "DestroyIcon")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool DestroyIcon(IntPtr handle);

        // P/Invoke for EnumResourceNames to enumerate resource names
        [LibraryImport("kernel32.dll", EntryPoint = "EnumResourceNamesW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool EnumResourceNames(IntPtr hModule, IntPtr lpszType, EnumResNameProc lpEnumFunc, IntPtr lParam);

        [LibraryImport("user32.dll", EntryPoint = "LoadImageW", SetLastError = true)]
        private static partial IntPtr LoadImage(IntPtr hinst, IntPtr lpszName, uint uType, int cxDesired, int cyDesired, uint fuLoad);

        [LibraryImport("kernel32.dll", EntryPoint = "FindResourceW", SetLastError = true)]
        private static partial IntPtr FindResource(IntPtr hModule, IntPtr lpName, IntPtr lpType);

        [LibraryImport("kernel32.dll", EntryPoint = "LoadResource", SetLastError = true)]
        private static partial IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

        [LibraryImport("kernel32.dll", EntryPoint = "LockResource", SetLastError = true)]
        private static partial IntPtr LockResource(IntPtr hResData);

        [LibraryImport("kernel32.dll", EntryPoint = "LoadLibraryW", StringMarshalling = StringMarshalling.Utf16)]
        private static partial IntPtr LoadLibrary(string lpFileName);

        [LibraryImport("kernel32.dll", EntryPoint = "FreeLibrary")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static partial bool FreeLibrary(IntPtr hModule);


        // Delegate for EnumResourceNames callback
        private delegate bool EnumResNameProc(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, IntPtr lParam);
        public string CustomIconDLLPath = "imageres.dll";

        public Imageres_Icons(MainForm mainForm, string _customDll)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.MinimumSize = Size;
            CustomIconDLLPath = _customDll;
            // Ensure the form is hidden instead of closed to avoid having to reload everything
            // Doing this only after all the icons are loaded
            this.FormClosing += OnFormClosing;
            LoadIcons();
        }

        private async void LoadIcons()
        {
            string systemFolder = Environment.GetFolderPath(Environment.SpecialFolder.System);
            string imageresPath = CustomIconDLLPath;
            
            if (!CustomIconDLLPath.StartsWith(systemFolder))
            {
                imageresPath = Path.Combine(systemFolder, imageresPath);
            }

            IntPtr hModule = LoadLibrary(imageresPath);
            if ( hModule == IntPtr.Zero )
            {
                MessageBox.Show("Failed to load " + imageresPath, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<int> iconGroupIds = [];
            EnumResourceNames(hModule, new IntPtr(14), (h, t, name, l) =>
            {
                iconGroupIds.Add((int)name);
                return true;
            }, IntPtr.Zero);

            await Task.Run(() =>
            {
                foreach ( int groupId in iconGroupIds )
                {
                    ExtractAndDisplayIcon(hModule, groupId);
                }
            });

            FreeLibrary(hModule);
        }

        private void ExtractAndDisplayIcon(IntPtr hModule, int groupId)
        {
            IntPtr hResInfo = FindResource(hModule, new IntPtr(groupId), new IntPtr(14)); // RT_GROUP_ICON
            if ( hResInfo == IntPtr.Zero )
                return;

            IntPtr hResData = LoadResource(hModule, hResInfo);
            if ( hResData == IntPtr.Zero )
                return;

            IntPtr hGlobal = LockResource(hResData);
            if ( hGlobal == IntPtr.Zero )
                return;

            // Use LoadImage instead of ExtractIcon
            IntPtr hIcon = LoadImage(hModule, new IntPtr(groupId),
                    1, // IMAGE_ICON
                    0, 0, // Use actual size
                    0x00000040); // LR_DEFAULTSIZE

            if ( hIcon == IntPtr.Zero )
            {
                int error = Marshal.GetLastWin32Error();
                Debug.WriteLine($"LoadImage failed for ID {groupId} with error: {error}");
                return;
            }

            using Icon icon = Icon.FromHandle(hIcon);
            Icon iconCopy = (Icon)icon.Clone();
            DestroyIcon(hIcon);
            Bitmap bitmap = iconCopy.ToBitmap();

            FlowLayoutPanel containerPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                Margin = new Padding(4),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Size = new Size(56, 70),
                Tag = groupId
            };

            PictureBox pictureBox = new PictureBox
            {
                Image = bitmap,
                Size = new Size(48, 48),
                SizeMode = PictureBoxSizeMode.Zoom,
                Margin = new Padding(0),
                Tag = groupId
            };

            Label iconLabel = new Label
            {
                Text = $"{groupId}",
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0),
                Width = pictureBox.Width
            };

            // Changed click to MouseDown for better responsiveness
            pictureBox.MouseDown += IconClickHandler;
            iconLabel.MouseDown += IconClickHandler;

            containerPanel.Controls.Add(pictureBox);
            containerPanel.Controls.Add(iconLabel);

            try
            {
                this.Invoke(() =>
                {
                    // Ensure the form is not disposed already
                    if ( !flowLayoutPanelMain.IsDisposed )
                        flowLayoutPanelMain.Controls.Add(containerPanel);
                });
            }
            catch ( ObjectDisposedException ) // If the other form was closed before finished adding. For some reason checking IsDisposed isn't enough
            {
                Debug.WriteLine("Caught trying to invoke while form was disposed");
            }
        }

        private void OnPanelClick(object? sender, int iconIndex)
        {
            mainForm.SetCustomID(iconIndex);

            // Make the selected thing highlighted, and Unhighlight the previous selection
            if ( previousPanelSelection != null )
            {
                previousPanelSelection.BackColor = Color.Transparent;
            }

            if ( sender is FlowLayoutPanel panel )
            {
                panel.BackColor = Color.LightBlue;
                previousPanelSelection = panel;
            }
        }

        private void IconClickHandler(object? sender, EventArgs e)
        {
            if ( sender is Control control )
            {
                var containerPanel = control as FlowLayoutPanel ?? control.Parent as FlowLayoutPanel;
                if ( containerPanel?.Tag is int iconIndex )
                {
                    OnPanelClick(containerPanel, iconIndex);
                }
            }
        }

        private void OnFormClosing(object? sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
