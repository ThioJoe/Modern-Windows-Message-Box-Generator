using System.Runtime.InteropServices;

namespace Windows_Task_Dialog_Generator
{
    public class TaskDialogIconExtractor
    {
        private const int TDN_CREATED = 0;
        private static IntPtr extractedIcon;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int TaskDialogCallback(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam, IntPtr lpRefData);

        private static int CallbackProc(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam, IntPtr lpRefData)
        {
            if ( msg == TDN_CREATED )
            {
                // Get the icon handle when the dialog is created
                extractedIcon = SendMessage(hwnd, WM_GETICON, ICON_BIG, IntPtr.Zero);
                // Immediately close the dialog
                EndDialog(hwnd, 0);
            }
            return 0;
        }

        private const int WM_GETICON = 0x007F;
        private const int ICON_BIG = 1;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool EndDialog(IntPtr hDlg, int nResult);

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct TaskDialogConfig
        {
            public uint cbSize;
            public IntPtr hwndParent;
            public IntPtr hInstance;
            public uint dwFlags;
            public uint dwCommonButtons;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszWindowTitle;
            public IntPtr hMainIcon;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszMainInstruction;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszContent;
            public uint cButtons;
            public IntPtr pButtons;
            public int nDefaultButton;
            public uint cRadioButtons;
            public IntPtr pRadioButtons;
            public int nDefaultRadioButton;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszVerificationText;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszExpandedInformation;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszExpandedControlText;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszCollapsedControlText;
            public IntPtr hFooterIcon;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pszFooter;
            public IntPtr pfCallback;
            public IntPtr lpCallbackData;
            public uint cxWidth;
        }

        [DllImport("comctl32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern int TaskDialogIndirect(
            ref TaskDialogConfig pTaskConfig,
            out int pnButton,
            out int pnRadioButton,
            out bool pfVerificationFlagChecked);

        public static Icon GetShieldSuccessGreenBarIcon()
        {
            //const int TD_SHIELD_GREEN_BAR = -4;  // MAKEINTRESOURCEW(-4)
            const int TD_SHIELD_GREEN_BAR = ushort.MaxValue - 7;
            TaskDialogCallback callback = new TaskDialogCallback(CallbackProc);
            nint callbackPtr = Marshal.GetFunctionPointerForDelegate(callback);

            TaskDialogConfig config = new TaskDialogConfig
            {
                cbSize = (uint)Marshal.SizeOf(typeof(TaskDialogConfig)),
                hwndParent = IntPtr.Zero,
                hInstance = IntPtr.Zero,
                dwFlags = 0,
                dwCommonButtons = 1,
                pszWindowTitle = "",
                hMainIcon = new IntPtr(TD_SHIELD_GREEN_BAR),
                pszMainInstruction = "",
                pszContent = "",
                pfCallback = callbackPtr,
                cxWidth = 0
            };

            extractedIcon = IntPtr.Zero;
            int button;
            int radioButton;
            bool verificationFlag;

            TaskDialogIndirect(ref config, out button, out radioButton, out verificationFlag);

            if ( extractedIcon != IntPtr.Zero )
            {
                // Convert the HICON to a managed Icon
                return Icon.FromHandle(extractedIcon);
            }

            return null;
        }
    }
}
