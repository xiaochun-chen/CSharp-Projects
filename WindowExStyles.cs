using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudTool.Constants
{
    class WindowExStyles
    {
        public const int DlgModelFrame = 0x00000001;
        public const int NoParentNotify = 0x00000004;
        public const int TopMost = 0x00000008;
        public const int AcceptFiles = 0x00000010;
        public const int Transparent = 0x00000020;
        public const int MDIChild = 0x00000040;
        public const int ToolWindow = 0x00000080;
        public const int WindowEdge = 0x00000100;
        public const int ClientEdge = 0x00000200;
        public const int ContextHelp = 0x00000400;
        public const int Right = 0x00001000;
        public const int Left = 0x00000000;
        public const int RTLReading = 0x00002000;
        public const int LTRReading = 0x00000000;
        public const int LeftScrollBar = 0x00004000;
        public const int RightScrollBar = 0x00000000;
        public const int ControlParent = 0x00010000;
        public const int StaticEdge = 0x00020000;
        public const int AppWindow = 0x00040000;
        public const int OverlappedWindow = unchecked((int)(0x00000100L | 0x00000200L));
        public const int PaletteWindow = unchecked((int)(0x00000100L | 0x00000080L | 0x00000008L));
        public const int NoActive = 0x08000000;
    }
}
