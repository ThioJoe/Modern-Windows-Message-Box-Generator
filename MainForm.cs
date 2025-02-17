using System.Diagnostics.Eventing.Reader;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable enable
#pragma warning disable IDE1006

namespace Windows_Task_Dialog_Generator
{
    public partial class MainForm : Form
    {
        [LibraryImport("user32.dll", EntryPoint = "SendMessageW")]
        private static partial IntPtr SendMessage(IntPtr hWnd, uint Msg, UIntPtr wParam, IntPtr lParam);

        // Class level variables
        public static string VERSION = "Error getting version";
        public static IDSelectionBox LastUsedIDTextBox = IDSelectionBox.None; // Use to decide where to put selected imagres Icon IDS
        public static Dictionary<string, TaskDialogPreset> Presets = new Dictionary<string, TaskDialogPreset>();

        public MainForm()
        {
            InitializeComponent();

            VERSION = DetermineVersion();
            labelVersion.Text = "Version: " + VERSION;

            MinimumSize = Size; // Prevent resizing
            // if length of presets is 0 then set cbPresets to disabled
            if (Presets.Count == 0)
            {
                cbPresets.Enabled = false;
                btnPresetUpdate.Enabled = false;
                btnPresetLoad.Enabled = false;
                btnPresetDelete.Enabled = false;
            }
            else
            {
                cbPresets.Items.AddRange(Presets.Keys.ToArray());
                cbPresets.SelectedIndex = 0;
            }
#if DEBUG
            buttonTest.Visible = true;
#endif

            // Attach event handler to all radio buttons for icon selection to enable/disable necessary controls when the radio button selection changes
            foreach (Control control in tableLayoutMainIconSelect.Controls)
            {
                if (control is RadioButton rb)
                {
                    rb.CheckedChanged += EnableDisableNecessaryMainIconControls;
                }
            }
            foreach (Control control in tableLayoutTitleIconSelect.Controls)
            {
                if (control is RadioButton rb)
                {
                    rb.CheckedChanged += EnableDisableNecessaryTitleIconControls;
                }
            }
            foreach (Control control in flowButtons.Controls)
            {
                if (control is RadioButton rb)
                {
                    rb.CheckedChanged += EnableDisableNecessaryButtonControls;
                }
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            CreateAndShowDialog();
        }

        private static string DetermineVersion()
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown Version";

            // If the last digit is zero, remove it
            if (version.EndsWith(".0"))
            {
                version = version.Substring(0, version.Length - 2);
            }

            return version;
        }

        private TaskDialogPage AssembleTaskDialogPage()
        {
            string captionText = txtTitle.Text;
            if (string.IsNullOrEmpty(captionText))
            {
                captionText = " "; // Add a single space to prevent it from defaulting to the executable file name
            }

            TaskDialogPage page = new TaskDialogPage()
            {
                Caption = captionText,
                Heading = txtHeading.Text,
                Text = txtMessage.Text,
                Footnote = new TaskDialogFootnote() { Text = txtFooter.Text },
                AllowCancel = true,
            };

            if (!string.IsNullOrEmpty(txtExpandedInfo.Text))
            {
                page.Expander = new TaskDialogExpander()
                {
                    Text = txtExpandedInfo.Text,
                    CollapsedButtonText = "Show details",
                    ExpandedButtonText = "Hide details",
                    Position = TaskDialogExpanderPosition.AfterFootnote
                };
            }

            if (chkVerification.Checked)
            {
                page.Verification = new TaskDialogVerificationCheckBox()
                {
                    Text = textBoxVerification.Text,
                    Checked = false
                };
            }

            page.Buttons.Clear();
            if (rbOk.Checked) page.Buttons.Add(TaskDialogButton.OK);
            else if (rbOkCancel.Checked)
            {
                page.Buttons.Add(TaskDialogButton.OK);
                page.Buttons.Add(TaskDialogButton.Cancel);
            }
            else if (rbYesNo.Checked)
            {
                page.Buttons.Add(TaskDialogButton.Yes);
                page.Buttons.Add(TaskDialogButton.No);
            }
            else if (rbYesNoCancel.Checked)
            {
                page.Buttons.Add(TaskDialogButton.Yes);
                page.Buttons.Add(TaskDialogButton.No);
                page.Buttons.Add(TaskDialogButton.Cancel);
            }
            else if (rbAbortRetryIgnore.Checked)
            {
                TaskDialogButton abortButton = new TaskDialogButton("Abort");
                TaskDialogButton retryButton = new TaskDialogButton("Retry");
                TaskDialogButton ignoreButton = new TaskDialogButton("Ignore");

                page.Buttons.Add(abortButton);
                page.Buttons.Add(retryButton);
                page.Buttons.Add(ignoreButton);
            }
            else if (rbRetryCancel.Checked)
            {
                page.Buttons.Add(TaskDialogButton.Retry);
                page.Buttons.Add(TaskDialogButton.Cancel);
            }
            else if (rbCustom.Checked)
            {
                // Add the custom buttons if they are checked, and enable them depending on check state being fully checked (enabled) vs intermediate (disabled)
                // For the text, use a space if the text box is empty, otherwise it will cause an exception

                // Custom Button 1
                if (checkCustom1Visibility.CheckState != CheckState.Unchecked)
                {
                    string customButtonText1 = string.IsNullOrEmpty(textBoxCustom1.Text) ? " " : textBoxCustom1.Text;
                    TaskDialogButton customButton1 = new TaskDialogButton(customButtonText1);
                    page.Buttons.Add(customButton1);
                    customButton1.Enabled = checkCustom1Visibility.CheckState == CheckState.Checked;
                }

                // Custom Button 2
                if (checkCustom2Visibility.CheckState != CheckState.Unchecked)
                {
                    string customButtonText2 = string.IsNullOrEmpty(textBoxCustom2.Text) ? " " : textBoxCustom2.Text;
                    TaskDialogButton customButton2 = new TaskDialogButton(customButtonText2);
                    page.Buttons.Add(customButton2);
                    customButton2.Enabled = checkCustom2Visibility.CheckState == CheckState.Checked;
                }

                // Custom Button 3
                if (checkCustom3Visibility.CheckState != CheckState.Unchecked)
                {
                    string customButtonText3 = string.IsNullOrEmpty(textBoxCustom3.Text) ? " " : textBoxCustom3.Text;
                    TaskDialogButton customButton3 = new TaskDialogButton(customButtonText3);
                    page.Buttons.Add(customButton3);
                    customButton3.Enabled = checkCustom3Visibility.CheckState == CheckState.Checked;
                }
            }

            return page;
        }

        private void CreateAndShowDialog()
        {
            // Create the initial dialog page by adding buttons, but not yet setting the icon
            TaskDialogPage page = AssembleTaskDialogPage();

            TaskDialogIcon chosenIcon;
            if (rbIconMainCustomFile.Checked)
            {
                TaskDialogIcon? customIcon = GetCustomTaskDialogIconFromPath(textBoxCustomIconMainPath.Text);

                if (customIcon != null)
                    chosenIcon = customIcon;
                else
                    return; // If error / invalid custom icon, return without showing the dialog
            }
            else if (rbIconMainCustomID.Checked)
            {
                TaskDialogIcon? extractedIcon = GetCustomTaskDialogIconObjectFromID();

                if (extractedIcon == null)
                    return; // If error / invalid custom icon, return without showing the dialog. Error will have been shown in GetCustomIconObjectFromID()
                else
                    chosenIcon = extractedIcon;
            }
            else
            {
                chosenIcon = DetermineChosenMainIconFromSelection();

                //if ( chosenIcon == TaskDialogIcon.None )
                //{
                //    page.Created += RemoveTitlebarIcon_OnCreated; // It will add a default icon to the title bar if none is selected, so we need to remove it
                //}
            }

            // Directly set the icon if we don't need to specify a custom color bar
            if (rbBarColorDefault.Checked)
            {
                page.Icon = chosenIcon;
            }
            // Otherwise we'll set the icon after the dialog is created, after creating it with the temporary color bar icon
            else
            {
                page = SetupMainIconUpdate(page);
            }

            // Determine the title bar icon
            Icon? chosenTitlebarIcon;
            if (rbIconTitleSame.Checked)
            {
                IntPtr iconHandle = IntPtr.Zero;
                try
                {
                    iconHandle = chosenIcon.IconHandle;
                    chosenTitlebarIcon = Icon.FromHandle(iconHandle);
                }
                catch (InvalidOperationException)
                {
                    // It doesn't use a handle and throws an exception when trying to get it, so we'll use the corresponding icon from imageres.dll
                    // Apparently no way to check without try/catch, since IsHandleIcon throws an exception instead of returning null or something
                    chosenTitlebarIcon = GetCorrespondingIconFromTaskDialogIcon(chosenIcon);
                }
            }
            else if (rbIconTitleCustomFile.Checked)
            {
                chosenTitlebarIcon = GetCustomIconFromPath(textBoxCustomIconTitlePath.Text);
                if (chosenTitlebarIcon == null)
                    return; // If error / invalid custom icon, return without showing the dialog
            }
            else if (rbIconTitleCustomID.Checked)
            {
                chosenTitlebarIcon = GetCustomIconObjectFromID(textBoxCustomIconTitleID.Text);
                if (chosenTitlebarIcon == null)
                    return; // If error / invalid custom icon, return without showing the dialog
            }
            else
            {
                chosenTitlebarIcon = DetermineChosenTitlebarIconFromSelection();
            }

            // Either remove the title icon or set it to the chosen one
            if (chosenTitlebarIcon == null)
            {
                page.Created += RemoveTitlebarIcon_OnCreated;
            }
            else
            {
                page.Created += (sender, e) => UpdateTitlebarIcon_OnCreated(sender, chosenTitlebarIcon);
            }

            // Shows the actual dialog. Returns the button that was pressed
            TaskDialog.ShowDialog(page);
        }

        private TaskDialogPage SetupMainIconUpdate(TaskDialogPage page)
        {
            TaskDialogIcon temporaryColorBarIcon;

            if (rbBarColorGreen.Checked)
                temporaryColorBarIcon = TaskDialogIcon.ShieldSuccessGreenBar;
            else if (rbBarColorBlue.Checked)
                temporaryColorBarIcon = TaskDialogIcon.ShieldBlueBar;
            else if (rbBarColorGray.Checked)
                temporaryColorBarIcon = TaskDialogIcon.ShieldGrayBar;
            else if (rbBarColorRed.Checked)
                temporaryColorBarIcon = TaskDialogIcon.ShieldErrorRedBar;
            else if (rbBarColorYellow.Checked)
                temporaryColorBarIcon = TaskDialogIcon.ShieldWarningYellowBar;
            else if (rbBarColorNone.Checked)
                temporaryColorBarIcon = TaskDialogIcon.None;
            else
                temporaryColorBarIcon = TaskDialogIcon.None; // This should not happen since the radio buttons are mutually exclusive, but just in case

            // Use the temporary initial icon for the main icon to get the colored bar, then change it to the chosen icon after the dialog is created with SendMessage
            page.Icon = temporaryColorBarIcon;

            int chosenIconInt = DetermineChosenIconMainFromSelection_Int();

            // This will fire after the dialog is created
            page.Created += (sender, e) => UpdateMainIcon_OnCreated(sender, chosenIconInt);

            return page;
        }

        private static void RemoveTitlebarIcon_OnCreated(object? sender, EventArgs e)
        {
            TaskDialogPage? dialogPage = sender as TaskDialogPage;
            TaskDialog? dialog = dialogPage?.BoundDialog;
            if (dialog != null)
            {
                IntPtr hwnd = dialog.Handle;
                try
                {
                    // Set the window title icon to null
                    SendMessage(hwnd, (uint)WM.WM_SETICON, (UIntPtr)WPARAM.ICON_BIG, IntPtr.Zero);
                    SendMessage(hwnd, (uint)WM.WM_SETICON, (UIntPtr)WPARAM.ICON_SMALL, IntPtr.Zero);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing icon: " + ex.Message);
                }
            }
        }

        private static void UpdateTitlebarIcon_OnCreated(object? sender, Icon chosenIcon)
        {
            TaskDialogPage? dialogPage = sender as TaskDialogPage;
            TaskDialog? dialog = dialogPage?.BoundDialog;
            IntPtr hIcon = chosenIcon.Handle;

            if (dialog != null)
            {
                IntPtr hwnd;
                try
                {
                    hwnd = dialog.Handle;
                }
                catch (Exception ex)
                {
                    // Handle the case where the dialog is already closed or something
                    Console.WriteLine("Error getting dialog handle: " + ex.Message);
                    return;
                }

                try
                {
                    // Set the window title icon to null
                    SendMessage(hwnd, (uint)WM.WM_SETICON, (UIntPtr)WPARAM.ICON_BIG, hIcon);
                    SendMessage(hwnd, (uint)WM.WM_SETICON, (UIntPtr)WPARAM.ICON_SMALL, hIcon);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating icon: " + ex.Message);
                }
            }
        }

        private static void UpdateMainIcon_OnCreated(object? sender, int chosenIconID)
        {
            TaskDialogPage? dialogPage = sender as TaskDialogPage;
            TaskDialog? dialog = dialogPage?.BoundDialog;
            if (dialog != null)
            {
                IntPtr hwnd = dialog.Handle;
                try
                {
                    // We can update the icon using a SendMessage call. But we must specify the icon via ID, not an object or hIcon handle
                    // We do NOT use the negative of the ID, since the API is doing other stuff with the ID and handles it automatically
                    SendMessage(hwnd, (uint)TDM.UPDATE_ICON, UIntPtr.Zero, new IntPtr(chosenIconID));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating icon: " + ex.Message);
                }

            }
        }

        private static int? ParseAndValidateCustomID(string inputText)
        {
            int id;
            try
            {
                id = int.Parse(inputText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid icon ID. Please enter a valid integer. Error: \n\n" + ex);
                return null;
            }

            // Ensure the absolute value of the ID is within the valid range, since it can be negative
            if (id < 0 || id > ushort.MaxValue)
            {
                MessageBox.Show("Invalid icon ID. Valid values are from 0 to 65535.");
                return null;
            }

            return id;
        }

        private TaskDialogIcon? GetCustomTaskDialogIconObjectFromID()
        {
            string inputText = textBoxCustomIconMainID.Text;
            // Get System.Drawing.Icon from the imageres.dll file of the given ID, then convert to TaskDialogIcon
            Icon? extractedIcon = GetCustomIconObjectFromID(inputText);
            if (extractedIcon == null)
                return null;
            else
            {
                TaskDialogIcon convertedIcon = new TaskDialogIcon(extractedIcon);
                return convertedIcon;
            }
        }

        private static Icon? GetCustomIconObjectFromID(string idText)
        {
            int? parsedID = ParseAndValidateCustomID(idText);
            int id;

            if (parsedID == null)
                return null;
            else
                id = (int)parsedID;

            if (id < 0 || id > ushort.MaxValue)
            {
                MessageBox.Show("Invalid icon ID. Valid values are from 0 to 65535.");
                return null;
            }
            else
            {
                string winPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
                string imageresPath = Path.Combine(winPath, "imageres.dll");

                // When extracting icons from imageres.dll, we need to use the negative of the ID
                Icon? imageresIcon = System.Drawing.Icon.ExtractIcon(imageresPath, -1 * id);

                if (imageresIcon != null)
                {
                    return imageresIcon;
                }
                else
                {
                    MessageBox.Show($"No icon found in imageres.dll with ID {id}");
                    return null;
                }
            }
        }

        private static Icon? GetCorrespondingIconFromTaskDialogIcon(TaskDialogIcon? icon)
        {
            if (icon == null) return null;

            int iconID = -1;

            if (icon == TaskDialogIcon.Information) { iconID = (int)ImageresIconIDs.Information; }
            else if (icon == TaskDialogIcon.Warning) { iconID = (int)ImageresIconIDs.Warning; }
            else if (icon == TaskDialogIcon.Error) { iconID = (int)ImageresIconIDs.Error; }
            else if (icon == TaskDialogIcon.Shield) { iconID = (int)ImageresIconIDs.Shield; }
            else if (icon == TaskDialogIcon.ShieldBlueBar) { iconID = (int)ImageresIconIDs.Shield; }
            else if (icon == TaskDialogIcon.ShieldGrayBar) { iconID = (int)ImageresIconIDs.Shield; }
            else if (icon == TaskDialogIcon.ShieldSuccessGreenBar) { iconID = (int)ImageresIconIDs.ShieldSuccess; }
            else if (icon == TaskDialogIcon.ShieldWarningYellowBar) { iconID = (int)ImageresIconIDs.ShieldWarning; }
            else if (icon == TaskDialogIcon.ShieldErrorRedBar) { iconID = (int)ImageresIconIDs.ShieldError; }

            if (iconID != -1)
            {
                return GetIconObjectFromImageRes(iconID);
            }
            else
            {
                return null;
            }
        }

        private static Icon? GetIconObjectFromImageRes(int id)
        {
            string winPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            string imageresPath = Path.Combine(winPath, "imageres.dll");
            try
            {
                return Icon.ExtractIcon(imageresPath, -1 * id); // Negative ID to extract from imageres.dll
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading icon: " + ex.Message);
                return null;
            }
        }

        private static System.Drawing.Bitmap? GetIconPreviewImageFromImageRes(int id, int size)
        {
            string winPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            string imageresPath = Path.Combine(winPath, "imageres.dll");
            try
            {
                return Icon.ExtractIcon(imageresPath, -1 * id, size)?.ToBitmap(); // Negative ID to extract from imageres.dll
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading icon: " + ex.Message);
                return null;
            }
        }

        // Set the icons on the radio buttons to the actual icons
        private void SetRadioIcons()
        {
            // Get display DPI
            float dpiX = CreateGraphics().DpiX;
            float dpiScale = dpiX / 96f;


            // Icon IDs aren't necessarily the same as the enum values, so we need to get the actual icon from the imageres.dll file
            List<(RadioButton, int)> radioButtonsWithIcons =
            [
                (rbIconMainInformation,            81),
                (rbIconMainWarning,                84),
                (rbIconMainError,                  98),
                (rbIconMainShield,                 78),
                (rbIconMainShieldBlueBar,          78),
                (rbIconMainShieldGrayBar,          78),
                (rbIconMainShieldWarningYellowBar, 107),
                (rbIconMainShieldErrorRedBar,      105),
                (rbIconMainShieldSuccessGreenBar,  106)
            ];

            foreach ((RadioButton? radioButton, int iconID) in radioButtonsWithIcons)
            {
                int ScaledSize = (int)((16) * dpiScale);
                Bitmap? image = GetIconPreviewImageFromImageRes(iconID, ScaledSize);
                if (image != null)
                {
                    radioButton.Image = image;
                }
                radioButton.ImageAlign = ContentAlignment.MiddleLeft;
                radioButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetRadioIcons();
        }

        private Icon? DetermineChosenTitlebarIconFromSelection()
        {
            Icon? icon = null;

            if (rbIconTitleNone.Checked) icon = null;
            else if (rbIconTitleInformation.Checked) icon = GetIconObjectFromImageRes((int)ImageresIconIDs.Information);
            else if (rbIconTitleWarning.Checked) icon = GetIconObjectFromImageRes((int)ImageresIconIDs.Warning);
            else if (rbIconTitleError.Checked) icon = GetIconObjectFromImageRes((int)ImageresIconIDs.Error);
            else if (rbIconTitleShield.Checked) icon = GetIconObjectFromImageRes((int)ImageresIconIDs.Shield);
            else if (rbIconTitleShieldBlueBar.Checked) icon = GetIconObjectFromImageRes((int)ImageresIconIDs.Shield);
            else if (rbIconTitleShieldGrayBar.Checked) icon = GetIconObjectFromImageRes((int)ImageresIconIDs.Shield);
            else if (rbIconTitleShieldSuccess.Checked) icon = GetIconObjectFromImageRes((int)ImageresIconIDs.ShieldSuccess);
            else if (rbIconTitleShieldWarning.Checked) icon = GetIconObjectFromImageRes((int)ImageresIconIDs.ShieldWarning);
            else if (rbIconTitleShieldError.Checked) icon = GetIconObjectFromImageRes((int)ImageresIconIDs.ShieldError);

            return icon;
        }

        private TaskDialogIcon DetermineChosenMainIconFromSelection()
        {
            TaskDialogIcon chosenIcon = TaskDialogIcon.None;

            if (rbIconMainNone.Checked) chosenIcon = TaskDialogIcon.None;
            else if (rbIconMainInformation.Checked) chosenIcon = TaskDialogIcon.Information;
            else if (rbIconMainWarning.Checked) chosenIcon = TaskDialogIcon.Warning;
            else if (rbIconMainError.Checked) chosenIcon = TaskDialogIcon.Error;
            else if (rbIconMainShield.Checked) chosenIcon = TaskDialogIcon.Shield;
            else if (rbIconMainShieldBlueBar.Checked) chosenIcon = TaskDialogIcon.ShieldBlueBar;
            else if (rbIconMainShieldGrayBar.Checked) chosenIcon = TaskDialogIcon.ShieldGrayBar;
            else if (rbIconMainShieldWarningYellowBar.Checked) chosenIcon = TaskDialogIcon.ShieldWarningYellowBar;
            else if (rbIconMainShieldErrorRedBar.Checked) chosenIcon = TaskDialogIcon.ShieldErrorRedBar;
            else if (rbIconMainShieldSuccessGreenBar.Checked) chosenIcon = TaskDialogIcon.ShieldSuccessGreenBar;

            return chosenIcon;
        }

        private int DetermineChosenIconMainFromSelection_Int()
        {
            if (rbIconMainWarning.Checked)
                return (int)StandardIcons.Warning;
            else if (rbIconMainError.Checked)
                return (int)StandardIcons.Error;
            else if (rbIconMainInformation.Checked)
                return (int)StandardIcons.Information;
            else if (rbIconMainShield.Checked)
                return (int)StandardIcons.Shield;
            else if (rbIconMainShieldBlueBar.Checked)
                return (int)ShieldIcons.BlueBar;
            else if (rbIconMainShieldGrayBar.Checked)
                return (int)ShieldIcons.GrayBar;
            else if (rbIconMainShieldWarningYellowBar.Checked)
                return (int)ShieldIcons.YellowBar;
            else if (rbIconMainShieldErrorRedBar.Checked)
                return (int)ShieldIcons.RedBar;
            else if (rbIconMainShieldSuccessGreenBar.Checked)
                return (int)ShieldIcons.GreenBar;

            // For custom icon ID
            else if (rbIconMainCustomID.Checked)
            {
                int? parsedID = ParseAndValidateCustomID(textBoxCustomIconMainID.Text);
                if (parsedID == null)
                    return 0;
                else
                    return (int)parsedID;
            }

            else
                return (int)StandardIcons.None;
        }

        private static string GetPathFromBrowseDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.ico;*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tiff)|*.ico;*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tiff|Icon files (*.ico)|*.ico|Icon From Exe (*.exe)|*.exe|All files (*.*)|*.*"
            };

            // Show the open file dialog and get the selected file path
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
            {
                return string.Empty;
            }
        }

        private void buttonBrowseCustomIcon_Click(object sender, EventArgs e)
        {
            string filePath = GetPathFromBrowseDialog();

            if (!string.IsNullOrEmpty(filePath))
            {
                textBoxCustomIconMainPath.Text = filePath;
            }
        }

        private void buttonBrowseCustomIconTitle_Click(object sender, EventArgs e)
        {
            string filePath = GetPathFromBrowseDialog();

            if (!string.IsNullOrEmpty(filePath))
            {
                textBoxCustomIconTitlePath.Text = filePath;
            }
        }

        private static TaskDialogIcon? GetCustomTaskDialogIconFromPath(string filePath)
        {
            Icon? icon = GetCustomIconFromPath(filePath: filePath);
            if (icon == null)
                return null;
            else
                return new TaskDialogIcon(icon);
        }

        private static Icon? GetCustomIconFromPath(string filePath)
        {
            // Strip quotes if present
            filePath = filePath.Trim('"');

            // Get the file path from the text box, and get info about the file type
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("No custom icon path specified.");
                return null;
            }
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Custom icon path does not exist.");
                return null;
            }

            Icon? icon;

            // If it's an icon file, we can use it directly
            if (Path.GetExtension(filePath).Equals(".ico", StringComparison.CurrentCultureIgnoreCase))
            {
                try
                {
                    icon = new Icon(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading icon: " + ex.Message);
                    return null;
                }
            }
            // If it's an EXE, try to load the main icon
            else if (Path.GetExtension(filePath).Equals(".exe", StringComparison.CurrentCultureIgnoreCase))
            {
                try
                {
                    icon = Icon.ExtractAssociatedIcon(filePath);
                    if (icon == null)
                    {
                        MessageBox.Show("Error loading icon: No icon found in EXE");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading icon: " + ex.Message);
                    return null;
                }
            }

            // If it's another image type or file, try to convert to bitmap
            else
            {
                try
                {
                    using Image img = Image.FromFile(filePath);
                    if (img is Bitmap bitmap)
                    {
                        icon = Icon.FromHandle(bitmap.GetHicon());
                    }
                    else
                    {
                        MessageBox.Show("Unsupported image format.");
                        return null;
                    }
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("The file is not a valid image. Must be one of the following: ICO, BMP, GIF, JPG, PNG or TIFF");
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                    return null;
                }
            }

            return icon;
        }

        public enum IDSelectionBox
        {
            MainIcon,
            TitleIcon,
            None
        }

        public void SetCustomID(int id)
        {
            if (LastUsedIDTextBox == IDSelectionBox.MainIcon)
                textBoxCustomIconMainID.Text = id.ToString();
            else if (LastUsedIDTextBox == IDSelectionBox.TitleIcon)
                textBoxCustomIconTitleID.Text = id.ToString();
            else // Default to the main icon text box
                textBoxCustomIconMainID.Text = id.ToString();
        }

        private void EnableDisableNecessaryMainIconControls(object? sender, EventArgs e)
        {
            groupBoxCustomIconMainFile.Enabled = rbIconMainCustomFile.Checked; // Enable the custom file path group box if the custom file radio button is checked
            groupBoxBarColor.Enabled = !rbIconMainCustomFile.Checked; // We cannot use bar colors with custom icons from a file, only an imageRes.dll ID
            groupBoxCustomIconMainID.Enabled = rbIconMainCustomID.Checked; // Custom ID and custom file are mutually exclusive

            if (rbIconMainCustomFile.Checked)
            {
                // If the custom icon is selected, disable the bar color options
                rbBarColorDefault.Checked = true;
            }
        }

        private void EnableDisableNecessaryTitleIconControls(object? sender, EventArgs e)
        {
            // Enable the custom ID group box if the custom ID radio button is checked
            groupBoxCustomIconTitleID.Enabled = rbIconTitleCustomID.Checked;
            // Enable the custom file path group box if the custom file radio button is checked
            groupBoxCustomIconTitleFile.Enabled = rbIconTitleCustomFile.Checked;
        }

        private void EnableDisableNecessaryButtonControls(object? sender, EventArgs e)
        {
            // Enable the custom button text boxes if the custom button radio button is checked
            checkCustom1Visibility.Enabled = rbCustom.Checked;
            checkCustom2Visibility.Enabled = rbCustom.Checked;
            checkCustom3Visibility.Enabled = rbCustom.Checked;

            // Enable the custom button text boxes if the custom button radio button is checked
            textBoxCustom1.Enabled = rbCustom.Checked;
            textBoxCustom2.Enabled = rbCustom.Checked;
            textBoxCustom3.Enabled = rbCustom.Checked;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //CustomTaskDialog.Test();
            //TaskDialogIconExtractor.GetShieldSuccessGreenBarIcon();
            //TaskDialogIcon test = TaskDialogIcon.ShieldSuccessGreenBar;'
            //TaskDialogStandardIcon testIcon = TaskDialogStandardIcon.ShieldSuccessGreenBar;

            //bool testVar = true;
        }

        private void buttonImageResIcons_Click(object sender, EventArgs e)
        {
            // Check if the form is already open or already created
            foreach (Form form in Application.OpenForms)
            {
                if (form is Imageres_Icons)
                {
                    form.Show();
                    form.BringToFront();
                    return;
                }
            }

            // Open the Imageres_Icons form
            Imageres_Icons imageresIcons = new Imageres_Icons(this);
            imageresIcons.Show();
        }

        // ------------ Handlers specifically to set the LastUsedIDTextBox variable ------------
        private void rbIconMainCustomID_CheckedChanged(object sender, EventArgs e)
        {
            // Only set the LastUsedIDTextBox if the radio button is checked
            if (rbIconMainCustomID.Checked)
            {
                LastUsedIDTextBox = IDSelectionBox.MainIcon;
            }
        }
        private void rbIconTitleCustomID_CheckedChanged(object sender, EventArgs e)
        {
            // Only set the LastUsedIDTextBox if the radio button is checked
            if (rbIconTitleCustomID.Checked)
            {
                LastUsedIDTextBox = IDSelectionBox.TitleIcon;
            }
        }
        private void textBoxCustomIconMainID_Enter(object sender, EventArgs e)
        {
            LastUsedIDTextBox = IDSelectionBox.MainIcon;
        }
        private void textBoxCustomIconTitleID_Enter(object sender, EventArgs e)
        {
            LastUsedIDTextBox = IDSelectionBox.TitleIcon;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        public MessageBoxButtons GetSelectedMessageBoxButton()
        {
            if (rbOk.Checked) return MessageBoxButtons.OK;
            else if (rbOkCancel.Checked) return MessageBoxButtons.OKCancel;
            else if (rbYesNo.Checked) return MessageBoxButtons.YesNo;
            else if (rbYesNoCancel.Checked) return MessageBoxButtons.YesNoCancel;
            else if (rbAbortRetryIgnore.Checked) return MessageBoxButtons.AbortRetryIgnore;
            else if (rbRetryCancel.Checked) return MessageBoxButtons.RetryCancel;
            else return MessageBoxButtons.OK;
        }

        public void SetSelectedMessageBoxButtonRadio(MessageBoxButtons messageBoxButtons)
        {
            if (messageBoxButtons == MessageBoxButtons.OK)
            {
                rbOk.Checked = true;
            }
            else if (messageBoxButtons == MessageBoxButtons.OKCancel)
            {
                rbOkCancel.Checked = true;
            }
            else if (messageBoxButtons == MessageBoxButtons.YesNo)
            {
                rbYesNo.Checked = true;
            }
            else if (messageBoxButtons == MessageBoxButtons.YesNoCancel)
            {
                rbYesNoCancel.Checked = true;
            }
            else if (messageBoxButtons == MessageBoxButtons.AbortRetryIgnore)
            {
                rbAbortRetryIgnore.Checked = true;
            }
            else if (messageBoxButtons == MessageBoxButtons.RetryCancel)
            {
                rbRetryCancel.Checked = true;
            }
            else
            {
                rbCustom.Checked = true;
            }
        }

        public TaskDialogPreset AssembleTaskDialogPreset()
        {
            TaskDialogPreset preset = new TaskDialogPreset()
            {
                Title = txtTitle.Text,
                Heading = txtHeading.Text,
                Message = txtMessage.Text,
                Footer = txtFooter.Text,
                ExpandedInfo = txtExpandedInfo.Text,
                ShowVerification = chkVerification.Checked,
                VerificationMessage = textBoxVerification.Text,
                Buttons = GetSelectedMessageBoxButton()
            };

            if (preset.Buttons == MessageBoxButtons.OK)
            {
                rbOk.Checked = true;
            }
            else if (preset.Buttons == MessageBoxButtons.OKCancel)
            {
                rbOkCancel.Checked = true;
            }
            else if (preset.Buttons == MessageBoxButtons.YesNo)
            {
                rbYesNo.Checked = true;
            }
            else if (preset.Buttons == MessageBoxButtons.YesNoCancel)
            {
                rbYesNoCancel.Checked = true;
            }
            else if (preset.Buttons == MessageBoxButtons.AbortRetryIgnore)
            {
                rbAbortRetryIgnore.Checked = true;
            }
            else if (preset.Buttons == MessageBoxButtons.RetryCancel)
            {
                rbRetryCancel.Checked = true;
            }
            else
            {
                rbCustom.Checked = true;
            }

            return preset;
        }

        private void btnPresetSave_Click(object sender, EventArgs e)
        {
            SavePresetPromptDialog savePresetPromptDialog = new SavePresetPromptDialog();

            DialogResult result = savePresetPromptDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                AddPreset(savePresetPromptDialog.PresetName(), AssembleTaskDialogPreset());
            }
        }

        public void AddPreset(string name, TaskDialogPreset preset)
        {
            Presets.Add(name, preset);
            cbPresets.Enabled = true;
            btnPresetDelete.Enabled = true;
            btnPresetUpdate.Enabled = true;
            btnPresetLoad.Enabled = true;
            cbPresets.Items.Add(name);
            cbPresets.SelectedIndex = cbPresets.Items.Count - 1;
        }

        private void btnPresetLoad_Click(object sender, EventArgs e)
        {
            // Load values from selected preset
            if (cbPresets.SelectedIndex != -1)
            {
                string? selectedPresetName = cbPresets.SelectedItem?.ToString();
                if (selectedPresetName == null)
                {
                    // TODO: Replace with one of the custom message boxes
                    MessageBox.Show("Did ya mess with the files or somethin? It seems like the preset you selected does not exist in our records", "Oopsies, can't load the preset!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TaskDialogPreset? selectedPreset = Presets[selectedPresetName];
                if (selectedPreset != null)
                {
                    txtTitle.Text = selectedPreset.Title;
                    txtHeading.Text = selectedPreset.Heading;
                    txtMessage.Text = selectedPreset.Message;
                    txtFooter.Text = selectedPreset.Footer;
                    txtExpandedInfo.Text = selectedPreset.ExpandedInfo;
                    chkVerification.Checked = selectedPreset.ShowVerification;
                    textBoxVerification.Text = selectedPreset.VerificationMessage;
                    SetSelectedMessageBoxButtonRadio(selectedPreset.Buttons);
                }

            }
        }

        private void btnPresetUpdate_Click(object sender, EventArgs e)
        {
            // check if selected preset is not empty or null if so try to get it from the presets list. if it exists then set the values of the preset to the value of different elements
            if (cbPresets.SelectedIndex != -1)
            {
                string? selectedPresetName = cbPresets.SelectedItem?.ToString();
                if (selectedPresetName == null)
                {
                    MessageBox.Show("Please select a valid preset. The one you selected is invalid/does not exist", "Unable to update preset", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TaskDialogPreset? selectedPreset = Presets[selectedPresetName];
                if (selectedPreset != null)
                {
                    selectedPreset.Title = txtTitle.Text;
                    selectedPreset.Heading = txtHeading.Text;
                    selectedPreset.Message = txtMessage.Text;
                    selectedPreset.Footer = txtFooter.Text;
                    selectedPreset.ExpandedInfo = txtExpandedInfo.Text;
                    selectedPreset.ShowVerification = chkVerification.Checked;
                    selectedPreset.VerificationMessage = textBoxVerification.Text;
                    selectedPreset.Buttons = GetSelectedMessageBoxButton();

                    // finally change the text of the update button to "updated!" and disable it for 5 seconds then re-enable it and change back to Update
                    btnPresetUpdate.Text = "Updated!";
                    btnPresetUpdate.Enabled = false;
                    Task.Delay(1000).ContinueWith(_ =>
                    {
                        btnPresetUpdate.Invoke(new Action(() =>
                        {
                            btnPresetUpdate.Text = "Update";
                            btnPresetUpdate.Enabled = true;
                        }));
                    });
                }
            }
        }

        private void btnPresetDelete_Click(object sender, EventArgs e)
        {
            // delete selected item from both presets list and the combobox
            if (cbPresets.SelectedIndex != -1)
            {
                string? selectedPresetName = cbPresets.SelectedItem?.ToString();
                if (selectedPresetName == null)
                {
                    MessageBox.Show("Please select a valid preset. The one you selected is invalid/does not exist", "Unable to delete preset", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Presets.Remove(selectedPresetName);
                cbPresets.Items.Remove(selectedPresetName);
                if (cbPresets.Items.Count == 0)
                {
                    cbPresets.Enabled = false;
                    btnPresetDelete.Enabled = false;
                    btnPresetUpdate.Enabled = false;
                    btnPresetLoad.Enabled = false;
                }
                else
                {
                    cbPresets.SelectedIndex = 0;
                }

                btnPresetDelete.Text = "Deleted!";
                btnPresetDelete.Enabled = false;
                Task.Delay(500).ContinueWith(_ =>
                {
                    btnPresetDelete.Invoke(new Action(() =>
                    {
                        btnPresetDelete.Text = "Delete";
                        btnPresetDelete.Enabled = cbPresets.Items.Count > 0;
                    }));
                });
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
