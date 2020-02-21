using CloudTool.Constants;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CloudTool.UI
{
    partial class ToolFrame : Form
    {
        public ToolFrame()
        {
            InitializeComponent();
        }
        public ToolStrip MainMenu => mainMenu;
 
        private Point mouseLocationOnLeftButtonDown = new Point(-1, -1);
        private bool leftMouseDown = false;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style = (int)(WindowStyles.Popup | WindowStyles.Visible | WindowStyles.Clipsiblings);
                cp.ExStyle = (int)(WindowExStyles.NoActive | WindowExStyles.ToolWindow | WindowExStyles.TopMost);
                return cp;
            }
        }

        #region Move form functions
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (!this.Bounds.Contains(PointToScreen(e.Location)))
            {
                MessageBox.Show("out of window");
            }
            if ((e.Button & MouseButtons.Left) != 0)
            {
                mouseLocationOnLeftButtonDown = e.Location;
                leftMouseDown = true;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            leftMouseDown = false;
            Screen src = Screen.AllScreens[0];
            Rectangle rtScr = src.Bounds;
            SuspendLayout();
            if (Left < 0)
            {
                Left = 0;
            }
            else if (Right > rtScr.Right)
            {
                Left = rtScr.Right - Width;
            }
            if (Top < 0)
            {
                Top = 0;
            }
            else if (Bottom > rtScr.Bottom)
            {
                Top = rtScr.Bottom - Height;
            }
            ResumeLayout();
            base.OnMouseUp(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (leftMouseDown)
            {
                int xMoved = e.Location.X - mouseLocationOnLeftButtonDown.X;
                int yMoved = e.Location.Y - mouseLocationOnLeftButtonDown.Y;
                SuspendLayout();
                this.Location = new Point(Location.X + xMoved, Location.Y + yMoved);
                ResumeLayout();
            }
        }
        #endregion        
        
        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}