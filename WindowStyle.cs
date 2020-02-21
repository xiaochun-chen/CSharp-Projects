namespace CloudTool.Constants
{
    static class WindowStyles
    {
        public const int Overlapped = 0x00000000;
        public const int Popup = unchecked((int)0x80000000);
        public const int Child = 0x40000000;
        public const int ChildWindow = 0x40000000;
        public const int Minimize = 0x20000000;
        public const int Iconic = 0x20000000;
        public const int Visible = 0x10000000;
        public const int Disable = 0x08000000;
        public const int Clipsiblings = 0x04000000;
        public const int ClipChildren = 0x02000000;
        public const int Maximize = 0x01000000;
        public const int Caption = 0x00C00000;    /* WS_BORDER | WS_DLGFRAME  */
        public const int Border = 0x00800000;
        public const int DlgFrame = 0x00400000;
        public const int VScroll = 0x00200000;
        public const int HScroll = 0x00100000;
        public const int SysMenu = 0x00080000;
        public const int ThickFrame = 0x00040000;
        public const int Group = 0x00020000;
        public const int TabStop = 0x00010000;
        public const int MinimizeBox = 0x00020000;
        public const int MaximizeBox = 0x00010000;
        public const int OverlappedWindow = 0x00000000 | 0x00C00000 | 0x00080000 | 0x00040000 | 0x00020000 | 0x00010000;
        public const int PopupWindow = unchecked((int)(0x00800000 | 0x80000000 | 0x00080000));
        public const int SizeBox = 0x00040000;
        public const int Tiled = 0x00000000;
        public const int TiledWindow = 0x00000000 | 0x00C00000 | 0x00080000 | 0x00040000 | 0x00020000 | 0x00010000;
    }
}