using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Metro.ColorTables;

namespace MediaManager
{
    public partial class frmMain : MetroForm
    {

        #region 窗体移动
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        /// <summary>
        /// 窗体移动事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            }
        }
        #endregion

        #region 窗体最大化位置及大小
        private const long WM_GETMINMAXINFO = 0x24;
        public struct POINTAPI
        {
            public int x;
            public int y;
        }
        public struct MINMAXINFO
        {
            public POINTAPI ptReserved;
            public POINTAPI ptMaxSize;
            public POINTAPI ptMaxPosition;
            public POINTAPI ptMinTrackSize;
            public POINTAPI ptMaxTrackSize;
        }
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_GETMINMAXINFO)
            {
                MINMAXINFO mmi = (MINMAXINFO)m.GetLParam(typeof(MINMAXINFO));
                mmi.ptMinTrackSize.x = this.MinimumSize.Width;
                mmi.ptMinTrackSize.y = this.MinimumSize.Height;
                if (this.MaximumSize.Width != 0 || this.MaximumSize.Height != 0)
                {
                    mmi.ptMaxTrackSize.x = this.MaximumSize.Width;
                    mmi.ptMaxTrackSize.y = this.MaximumSize.Height;
                }
                mmi.ptMaxPosition.x = 0;
                mmi.ptMaxPosition.y = 0;

                System.Runtime.InteropServices.Marshal.StructureToPtr(mmi, m.LParam, true);
            }
        }
        #endregion

        #region 窗体大小调整
        /// <summary>
        /// 调整大小时,鼠标感应的边框宽度.
        /// </summary>
        private int ResizeBorderWidth = 6;
        /// <summary>
        /// 位置类型.
        /// </summary>
        private MouseLocationStyle loactionStyle = MouseLocationStyle.S22_MiddelCenter;
        /// <summary>
        /// 上一次鼠标坐标.
        /// </summary>
        private Point LastMoustLocation;
        /// <summary>
        /// 鼠标是否按下.
        /// </summary>
        private bool IsMouseDown;
        /// <summary>
        /// 鼠标坐标类型枚举(用于调整窗体大小对应九宫格).
        /// </summary>
        public enum MouseLocationStyle
        {
            S11_LeftTop,
            S12_CenterTop,
            S13_RightTop,
            S21_MiddleLeft,
            S22_MiddelCenter,
            S23_RightMiddel,
            S31_LeftBottom,
            S32_CenterBottom,
            S33_RightBottom
        }
        /// <summary>
        /// 根据鼠标坐标,返回鼠标位置类型.
        /// </summary>
        /// <param name="mouseLocation">鼠标距窗体左上角的坐标</param>
        /// <returns></returns>
        private MouseLocationStyle GetLocationStyle(Point mouseLocation)
        {
            //左上
            if (mouseLocation.X <= ResizeBorderWidth &&
                mouseLocation.Y <= ResizeBorderWidth)
            {
                return MouseLocationStyle.S11_LeftTop;
            }

            //中上
            if (mouseLocation.X > ResizeBorderWidth &&
                mouseLocation.X <= this.Width - ResizeBorderWidth &&
                mouseLocation.Y <= ResizeBorderWidth)
            {
                return MouseLocationStyle.S12_CenterTop;
            }

            //右上
            if (mouseLocation.X > this.Width - ResizeBorderWidth &&
                mouseLocation.Y <= ResizeBorderWidth)
            {
                return MouseLocationStyle.S13_RightTop;
            }

            //左中
            if (mouseLocation.X <= ResizeBorderWidth &&
                mouseLocation.Y > ResizeBorderWidth &&
                mouseLocation.Y <= this.Height - ResizeBorderWidth)
            {
                return MouseLocationStyle.S21_MiddleLeft;
            }

            //中中
            if (mouseLocation.X > ResizeBorderWidth &&
                mouseLocation.X <= this.Width - ResizeBorderWidth &&
                mouseLocation.Y > ResizeBorderWidth &&
                mouseLocation.Y <= this.Height - ResizeBorderWidth)
            {
                return MouseLocationStyle.S22_MiddelCenter;
            }

            //右中
            if (mouseLocation.X > this.Width - ResizeBorderWidth &&
                mouseLocation.Y > ResizeBorderWidth &&
                mouseLocation.Y <= this.Height - ResizeBorderWidth)
            {
                return MouseLocationStyle.S23_RightMiddel;
            }

            //左下
            if (mouseLocation.X <= ResizeBorderWidth
                && mouseLocation.Y > this.Height - ResizeBorderWidth)
            {
                return MouseLocationStyle.S31_LeftBottom;
            }

            //中下
            if (mouseLocation.X > ResizeBorderWidth &&
                mouseLocation.X <= this.Width - ResizeBorderWidth &&
                mouseLocation.Y > this.Height - ResizeBorderWidth)
            {
                return MouseLocationStyle.S32_CenterBottom;
            }

            //右下
            if (mouseLocation.X > this.Width - ResizeBorderWidth &&
                mouseLocation.Y > this.Height - ResizeBorderWidth)
            {
                return MouseLocationStyle.S33_RightBottom;
            }

            throw new Exception("未知区域");
        }
        /// <summary>
        /// 根据鼠标位置类型,返回鼠标光标类型.
        /// </summary>
        /// <param name="mouseStyle">鼠标位置类型</param>
        /// <returns>鼠标光标类型</returns>
        private System.Windows.Forms.Cursor GetCursorByMouseLocationStyle(MouseLocationStyle mouseStyle)
        {
            switch (mouseStyle)
            {
                case MouseLocationStyle.S11_LeftTop:
                    return System.Windows.Forms.Cursors.SizeNWSE;
                case MouseLocationStyle.S12_CenterTop:
                    return System.Windows.Forms.Cursors.SizeNS;
                case MouseLocationStyle.S13_RightTop:
                    return System.Windows.Forms.Cursors.SizeNESW;
                case MouseLocationStyle.S21_MiddleLeft:
                    return System.Windows.Forms.Cursors.SizeWE;
                case MouseLocationStyle.S22_MiddelCenter:
                    return System.Windows.Forms.Cursors.Default;
                case MouseLocationStyle.S23_RightMiddel:
                    return System.Windows.Forms.Cursors.SizeWE;
                case MouseLocationStyle.S31_LeftBottom:
                    return System.Windows.Forms.Cursors.SizeNESW;
                case MouseLocationStyle.S32_CenterBottom:
                    return System.Windows.Forms.Cursors.SizeNS;
                case MouseLocationStyle.S33_RightBottom:
                    return System.Windows.Forms.Cursors.SizeNWSE;
                default:
                    return System.Windows.Forms.Cursors.Default;
            }
        }
        /// <summary>
        /// 根据鼠标坐标和鼠标坐标类型调整窗体大小.
        /// </summary>
        /// <param name="mouseLocation">鼠标坐标</param>
        /// <param name="mouseStyle">鼠标位置类型</param>
        private void ChangeSize(Point mouseLocation, MouseLocationStyle mouseStyle)
        {
            Size newSize = new Size(this.Width, this.Height);
            switch (mouseStyle)
            {
                case MouseLocationStyle.S11_LeftTop:
                    //左上
                    newSize.Width -= mouseLocation.X;
                    newSize.Height -= mouseLocation.Y;
                    this.Location = new Point(this.Location.X + mouseLocation.X, this.Location.Y + mouseLocation.Y);
                    break;
                case MouseLocationStyle.S12_CenterTop:
                    //中上
                    newSize.Height -= mouseLocation.Y;
                    this.Location = new Point(this.Location.X, this.Location.Y + mouseLocation.Y);
                    break;
                case MouseLocationStyle.S13_RightTop:
                    //右上
                    newSize.Width = mouseLocation.X;
                    newSize.Height -= mouseLocation.Y;
                    this.Location = new Point(this.Location.X, this.Location.Y + mouseLocation.Y);
                    break;
                case MouseLocationStyle.S21_MiddleLeft:
                    //左中
                    newSize.Width -= mouseLocation.X;
                    this.Location = new Point(this.Location.X + mouseLocation.X, this.Location.Y);
                    break;
                case MouseLocationStyle.S22_MiddelCenter:
                    //中中【无需调整】
                    break;
                case MouseLocationStyle.S23_RightMiddel:
                    //中右
                    newSize.Width = mouseLocation.X;
                    break;
                case MouseLocationStyle.S31_LeftBottom:
                    //左下
                    newSize.Width -= mouseLocation.X;
                    newSize.Height = mouseLocation.Y;
                    this.Location = new Point(this.Location.X + mouseLocation.X, this.Location.Y);
                    break;
                case MouseLocationStyle.S32_CenterBottom:
                    //中下
                    newSize.Height = mouseLocation.Y;
                    break;
                case MouseLocationStyle.S33_RightBottom:
                    //右下
                    newSize.Width = mouseLocation.X;
                    newSize.Height = mouseLocation.Y;
                    break;
            }

            this.Size = newSize;
        }
        /// <summary>
        /// 鼠标移动事件(调整窗体大小).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStyle_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //如果最大化则不触发事件.
            if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized) return;

            //鼠标距界面左上角的坐标
            Point mouseLocation = new Point(System.Windows.Forms.Control.MousePosition.X - this.Location.X, System.Windows.Forms.Control.MousePosition.Y - this.Location.Y);

            //如果允许调整大小
            if (this.IsMouseDown && this.loactionStyle != MouseLocationStyle.S22_MiddelCenter)
            {
                //调整大小
                if (this.LastMoustLocation == null || Math.Abs(this.LastMoustLocation.X - mouseLocation.X) >= 5 || Math.Abs(this.LastMoustLocation.Y - mouseLocation.Y) >= 5)
                {
                    this.ChangeSize(mouseLocation, this.loactionStyle);
                    this.LastMoustLocation = new Point(mouseLocation.X, mouseLocation.Y);
                }
            }
            else
            {
                //鼠标位置
                this.loactionStyle = this.GetLocationStyle(mouseLocation);
                this.Cursor = this.GetCursorByMouseLocationStyle(this.loactionStyle);
            }
        }
        /// <summary>
        /// 鼠标离开事件(调整窗体大小).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelEx6_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        /// <summary>
        /// 鼠标按下事件(调整窗体大小).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStyle_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.Cursor != System.Windows.Forms.Cursors.Default)
            {
                this.IsMouseDown = true;
            }
        }
        /// <summary>
        /// 鼠标放开事件(调整窗体大小).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStyle_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.IsMouseDown = false;
        }
        #endregion

        #region 窗体构造函数
        public frmMain()
        {
            InitializeComponent();

            this.MaximumSize = new Size(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width, System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height);
        }
        #endregion

        #region 窗体基础事件
        /// <summary>
        /// 窗体加载事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            sbStyle.Value = false;
        }
        /// <summary>
        /// 开关事件(主题测试).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbStyle_ValueChanged(object sender, EventArgs e)
        {
            if (sbStyle.Value)
            {
                styleManager.MetroColorParameters = new MetroColorGeneratorParameters(Color.Silver, Color.Gray);
            }
            else
            {
                styleManager.MetroColorParameters = new MetroColorGeneratorParameters(Color.White, Color.Gray);
            }
        }
        /// <summary>
        /// 按钮关闭事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 按钮最大化事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMax_Click(object sender, EventArgs e)
        {
            SetWindowsMax();
        }
        /// <summary>
        /// 按钮最小化事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        /// <summary>
        /// 窗体关闭事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.Cancel == true)
                return;
            
            if (MessageBoxEx.Show("是否退出", "提示", System.Windows.Forms.MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// 标题双击事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTitle_DoubleClick(object sender, EventArgs e)
        {
            SetWindowsMax();
        }
        #endregion

        #region 窗体方法
        /// <summary>
        /// 窗体最大化最小化.
        /// </summary>
        public void SetWindowsMax()
        {
            if (this.WindowState != System.Windows.Forms.FormWindowState.Maximized)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        #endregion

        private void lblOption_MouseEnter(object sender, EventArgs e)
        {
            if (((LabelX)sender).Tag == null)
            {
                ((LabelX)sender).BackColor = Color.LightGray;
            }
        }

        private void lblOption_MouseLeave(object sender, EventArgs e)
        {
            if (((LabelX)sender).Tag == null)
            {
                ((LabelX)sender).BackColor = Color.Transparent;
            }
        }

        private void lblOption_Click(object sender, EventArgs e)
        {
            foreach (LabelX lbl in ((LabelX)sender).Parent.Controls)
            {
                lbl.Tag = null;
                lbl.BackColor = Color.Transparent;
            }
            if (((LabelX)sender).Tag == null)
            {
                ((LabelX)sender).Tag = "check";
                ((LabelX)sender).BackColor = Color.Gray;
            }

            pnlCenterContent.Visible = true;

            intWidth = pnlCenterContent.Width;
            intHeight = pnlCenterContent.Height;
            intWidthSub = intWidth / 10;

            pnlCenterContent.Dock = System.Windows.Forms.DockStyle.None;
            pnlCenterContent.Location = new Point(-intWidth, 0);
            pnlCenterContent.Width = intWidth;
            pnlCenterContent.Height = intHeight;

            Timer.Start();
        }

        int intWidthSub;
        int intWidth;
        int intHeight;

        private delegate void AnimateControl();
        private void AnimateControlFunc()
        {
            if (-pnlCenterContent.Location.X >= intWidthSub)
            {
                pnlCenterContent.Location = new Point(pnlCenterContent.Location.X + intWidth / 30, 0);
            }
            else
            {
                pnlCenterContent.Location = new Point(pnlCenterContent.Location.X + intWidth / 100, 0);
            }

            if (-pnlCenterContent.Location.X < 0)
            {
                pnlCenterContent.Location = new Point(0, 0);
                Timer.Stop();
                pnlCenterContent.Dock = System.Windows.Forms.DockStyle.Fill;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AnimateControlFunc();
        }
    }
}
