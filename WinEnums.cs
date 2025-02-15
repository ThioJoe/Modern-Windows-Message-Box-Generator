namespace Windows_Task_Dialog_Generator
{
    public enum WM : uint
    {
        USER = 0x0400,
        WM_SETICON = 0x0080,
    }

    public enum WPARAM : uint // UIntPtr
    {
        ICON_SMALL = 0,
        ICON_BIG = 1,
        ICON_SMALL2 = 2 // Maybe not supported by Task Dialog, but see: https://stackoverflow.com/questions/75414979/wm-geticon-icon-small-vs-icon-small2
    }

    public enum TDM : uint
    {
        NAVIGATE_PAGE = WM.USER + 101,
        /// <summary>
        ///   "wParam = Button ID"
        /// </summary>
        CLICK_BUTTON = WM.USER + 102,
        /// <summary>
        ///   "wParam = 0 (nonMarque) wParam != 0 (Marquee)"
        /// </summary>
        SET_MARQUEE_PROGRESS_BAR = WM.USER + 103,
        /// <summary>
        ///   "wParam = new progress state"
        /// </summary>
        SET_PROGRESS_BAR_STATE = WM.USER + 104,
        /// <summary>
        ///   "lParam = MAKELPARAM(nMinRange, nMaxRange)"
        /// </summary>
        SET_PROGRESS_BAR_RANGE = WM.USER + 105,
        /// <summary>
        ///   "wParam = new position"
        /// </summary>
        SET_PROGRESS_BAR_POS = WM.USER + 106,
        /// <summary>
        ///   "wParam = 0 (stop marquee), wParam != 0 (start marquee),
        ///   lparam = speed (milliseconds between repaints)"
        /// </summary>
        SET_PROGRESS_BAR_MARQUEE = WM.USER + 107,
        /// <summary>
        ///   "wParam = element (TASKDIALOG_ELEMENTS), lParam = new element text (LPCWSTR)"
        /// </summary>
        SET_ELEMENT_TEXT = WM.USER + 108,
        /// <summary>
        ///   "wParam = Radio Button ID"
        /// </summary>
        CLICK_RADIO_BUTTON = WM.USER + 110,
        /// <summary>
        ///   "lParam = 0 (disable), lParam != 0 (enable), wParam = Button ID"
        /// </summary>
        ENABLE_BUTTON = WM.USER + 111,
        /// <summary>
        ///   "lParam = 0 (disable), lParam != 0 (enable), wParam = Radio Button ID"
        /// </summary>
        ENABLE_RADIO_BUTTON = WM.USER + 112,
        /// <summary>
        ///   "wParam = 0 (unchecked), 1 (checked), lParam = 1 (set key focus)"
        /// </summary>
        CLICK_VERIFICATION = WM.USER + 113,
        /// <summary>
        ///   "wParam = element (TASKDIALOG_ELEMENTS), lParam = new element text (LPCWSTR)"
        /// </summary>
        UPDATE_ELEMENT_TEXT = WM.USER + 114,
        /// <summary>
        ///   "wParam = Button ID, lParam = 0 (elevation not required),
        ///   lParam != 0 (elevation required)"
        /// </summary>
        SET_BUTTON_ELEVATION_REQUIRED_STATE = WM.USER + 115,
        /// <summary>
        ///   "wParam = icon element (TASKDIALOG_ICON_ELEMENTS), lParam = new icon
        ///   (hIcon if TDF_USE_HICON_* was set, PCWSTR otherwise)"
        /// </summary>
        UPDATE_ICON = WM.USER + 116,
    }

    public enum TDF : uint
    {
        NONE = 0x00000000,
        ENABLE_HYPERLINKS = 0x00000001,
        USE_HICON_MAIN = 0x00000002,
        USE_HICON_FOOTER = 0x00000004,
        VERIFY_CLICK = 0x00000008,
        SHOW_PROGRESS_BAR = 0x00000010,
        SHOW_MARQUEE_PROGRESS_BAR = 0x00000020,
        CALLBACK_TIMER = 0x00000040,
        POSITION_RELATIVE_TO_WINDOW = 0x00000080,
        RTL_LAYOUT = 0x00000100,
        NO_DEFAULT_RADIO_BUTTON = 0x00000200,
        CAN_BE_MINIMIZED = 0x00000400,
        SIZE_TO_CONTENT = 0x00000800,
    }

    public enum ShieldIcons : int
    {
        BlueBar = ushort.MaxValue - 4,
        YellowBar = ushort.MaxValue - 5,
        RedBar = ushort.MaxValue - 6,
        GreenBar = ushort.MaxValue - 7,
        GrayBar = ushort.MaxValue - 8

    }

    public enum StandardIcons : int
    {
        None = 0,
        Warning = 65535,
        Error = 65534,
        Information = 65533,
        Shield = 65532
    }

    public enum ImageresIconIDs : int
    {
        Information = 81,
        Warning = 84,
        Error = 98,
        Shield = 78,
        ShieldSuccess = 106,
        ShieldWarning = 107,
        ShieldError = 105
    }

}
