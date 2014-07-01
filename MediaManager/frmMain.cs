using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Metro.ColorTables;

using MediaManagerBLL;
using MediaManagerENT.uTorrent;

namespace MediaManager
{
    public partial class frmMain : MetroForm
    {

        #region 主启动对象及执行
        /// <summary>
        /// 主选项面板集合.
        /// </summary>
        private Dictionary<LabelX, PanelEx> dicSelectOptions = new Dictionary<LabelX, PanelEx>();
        /// <summary>
        /// 启动事务以及对象初始化.
        /// </summary>
        private void LoadTransaction()
        {
            //挂载调整窗体事件.
            //this.pnlSelectMenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseDown);
            //this.pnlSelectMenuTop.MouseLeave += new System.EventHandler(this.FrmStyle_MouseLeave);
            //this.pnlSelectMenuTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseMove);
            //this.pnlSelectMenuTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseUp);
            //
            this.pnlSelectMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseDown);
            this.pnlSelectMenu.MouseLeave += new System.EventHandler(this.FrmStyle_MouseLeave);
            this.pnlSelectMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseMove);
            this.pnlSelectMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseUp);
            //
            this.pnlSelectOptions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseDown);
            this.pnlSelectOptions.MouseLeave += new System.EventHandler(this.FrmStyle_MouseLeave);
            this.pnlSelectOptions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseMove);
            this.pnlSelectOptions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseUp);
            //
            this.pnlRightContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseDown);
            this.pnlRightContent.MouseLeave += new System.EventHandler(this.FrmStyle_MouseLeave);
            this.pnlRightContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseMove);
            this.pnlRightContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseUp);
            //是否已有主选项.
            bool isHadMain = false;
            //挂载面板事件,关联菜单面板关系.
            foreach (LabelX lbl in pnlSelectOptions.Controls)
            {
                //选项字体颜色.
                lbl.ForeColor = colUnCheckFore;
                //鼠标进入事件.
                lbl.MouseEnter += new EventHandler(lblOption_MouseEnter);
                //鼠标离开事件.
                lbl.MouseLeave += new EventHandler(lblOption_MouseLeave);
                //鼠标单击事件.
                lbl.Click += new EventHandler(lblOption_Click);

                dicSelectOptions.Add(lbl, null);

                if (lbl.Tag != null)
                {
                    if (isHadMain)
                    {
                        throw new Exception("不允许存在多个主选项");
                    }
                    else
                    {
                        lbl.Tag = optionState.MAINCHECKED;

                        //设置主选项默认选中状态.
                        lbl.BackColor = colChecked;

                        //设置主选项样式.
                        lbl.ForeColor = colCheckedFore;
                        lbl.BackgroundStyle.BorderLeft = eStyleBorderType.Solid;
                        lbl.BackgroundStyle.BorderLeftWidth = 4;
                        lbl.BackgroundStyle.BorderLeftColor = pnlSelectMenuTop.Style.BackColor1.Color;

                        isHadMain = true;
                    }
                }
                else
                {
                    lbl.Tag = optionState.UNCHECK;
                }

                //关联关系.
                foreach (System.Windows.Forms.Control ctrlTEMP in pnlCenterContent.Controls)
                {
                    if (ctrlTEMP.GetType() == typeof(PanelEx) && ((PanelEx)ctrlTEMP).Tag != null)
                    {
                        PanelEx pnl = ((PanelEx)ctrlTEMP);

                        //设置所有面板默认隐藏.
                        pnl.Visible = false;

                        if (pnl.Tag.ToString() == lbl.Name)
                        {
                            pnl.Tag = lbl;
                            dicSelectOptions[lbl] = pnl;
                        }
                    }
                }
            }
        }
        #endregion

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
        private void FrmStyle_MouseLeave(object sender, EventArgs e)
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

        #region 主选项及面板事件
        /// <summary>
        /// 面板宽度.
        /// </summary>
        private int intWidth;
        /// <summary>
        /// 面板高度.
        /// </summary>
        private int intHeight;
        /// <summary>
        /// 面板缓速宽度.
        /// </summary>
        private int intWidthSub;
        /// <summary>
        /// 选项选中字体颜色.
        /// </summary>
        private Color colCheckedFore = Color.White;
        /// <summary>
        /// 选项未选中字体颜色.
        /// </summary>
        private Color colUnCheckFore = Color.FromArgb(255, 165, 176, 196);
        /// <summary>
        /// 选项进入背景色.
        /// </summary>
        private Color colMoveIn = Color.FromArgb(255, 79, 95, 121);
        /// <summary>
        /// 选项选中背景色.
        /// </summary>
        private Color colChecked = Color.FromArgb(255, 79, 95, 121);
        /// <summary>
        /// 选项未选中背景色.
        /// </summary>
        private Color colUnCheck = Color.Transparent;
        /// <summary>
        /// 前一面板对象.
        /// </summary>
        private PanelEx pnlPrevious = null;
        /// <summary>
        /// 当前面板对象.
        /// </summary>
        private PanelEx pnlCurrent = null;
        /// <summary>
        /// 面板动画时间控件.
        /// </summary>
        private System.Windows.Forms.Timer timeOptionAnimate;
        /// <summary>
        /// 主选项状态.
        /// </summary>
        private enum optionState
        {
            /// <summary>
            /// 选中状态.
            /// </summary>
            CHECKED,
            /// <summary>
            /// 未选中状态
            /// </summary>
            UNCHECK,
            /// <summary>
            /// 主面板选中状态.
            /// </summary>
            MAINCHECKED,
            /// <summary>
            /// 主面板未选中状态.
            /// </summary>
            MAINUNCHECK
        }
        /// <summary>
        /// 主选项鼠标进入事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOption_MouseEnter(object sender, EventArgs e)
        {
            if ((optionState)((LabelX)sender).Tag != optionState.CHECKED
                &&
                (optionState)((LabelX)sender).Tag != optionState.MAINCHECKED)
            {
                ((LabelX)sender).BackColor = colMoveIn;
            }
        }
        /// <summary>
        /// 主选项鼠标离开事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOption_MouseLeave(object sender, EventArgs e)
        {
            if ((optionState)((LabelX)sender).Tag != optionState.CHECKED
                &&
                (optionState)((LabelX)sender).Tag != optionState.MAINCHECKED)
            {
                ((LabelX)sender).BackColor = colUnCheck;
            }
        }
        /// <summary>
        /// 主选项鼠标单击事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOption_Click(object sender, EventArgs e)
        {
            //判断是否已选中.
            if ((optionState)((LabelX)sender).Tag == optionState.CHECKED
                ||
                (optionState)((LabelX)sender).Tag == optionState.MAINCHECKED)
                return;

            //设置所有选项为未选中.
            foreach (LabelX lbl in ((LabelX)sender).Parent.Controls)
            {
                if ((optionState)lbl.Tag == optionState.MAINCHECKED)
                    lbl.Tag = optionState.MAINUNCHECK;
                else if ((optionState)lbl.Tag == optionState.CHECKED)
                {
                    pnlPrevious = dicSelectOptions[lbl];
                    lbl.Tag = optionState.UNCHECK;
                }
                lbl.BackColor = colUnCheck;
                lbl.ForeColor = colUnCheckFore;
                lbl.BackgroundStyle.BorderLeft = eStyleBorderType.None;
            }

            //选中当前选项.
            if ((optionState)((LabelX)sender).Tag == optionState.MAINUNCHECK)
                ((LabelX)sender).Tag = optionState.MAINCHECKED;
            else
                ((LabelX)sender).Tag = optionState.CHECKED;
            ((LabelX)sender).BackColor = colChecked;
            ((LabelX)sender).ForeColor = colCheckedFore;
            ((LabelX)sender).BackgroundStyle.BorderLeft = eStyleBorderType.Solid;
            ((LabelX)sender).BackgroundStyle.BorderLeftWidth = 4;
            ((LabelX)sender).BackgroundStyle.BorderLeftColor = pnlSelectMenuTop.Style.BackColor1.Color;

            #region 面板动画初始化
            //判断是否存在面板对象.
            if ((optionState)((LabelX)sender).Tag != optionState.MAINCHECKED && dicSelectOptions[((LabelX)sender)] == null)
                return;

            //判断前一动画是否执行完毕.
            if (timeOptionAnimate != null && timeOptionAnimate.Enabled)
            {
                timeOptionAnimate.Stop();

                if (pnlPrevious != null)
                    pnlPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            }

            //初始化动画时间控件.
            timeOptionAnimate = new System.Windows.Forms.Timer();
            timeOptionAnimate.Enabled = false;
            timeOptionAnimate.Interval = 1;

            //判断动画效果.
            if ((optionState)((LabelX)sender).Tag == optionState.MAINCHECKED)
            {
                //判断是否存在面板.
                if (pnlPrevious == null)
                    return;

                //挂载动画事件.
                timeOptionAnimate.Tick += new EventHandler(timeOptionAnimateClose_Tick);

                //设置除前一面板外所有面板为隐藏.
                foreach (System.Windows.Forms.Control ctrlTEMP in pnlCenterContent.Controls)
                {
                    if (ctrlTEMP.GetType() == typeof(PanelEx) && ((PanelEx)ctrlTEMP).Tag != null)
                    {
                        PanelEx pnl = ((PanelEx)ctrlTEMP);

                        if (pnlPrevious != pnl)
                            pnl.Visible = false;
                    }
                }

                //为动画进行属性初始化.
                intWidth = pnlPrevious.Width;
                intHeight = pnlPrevious.Height;
                intWidthSub = intWidth / 10;

                pnlPrevious.Dock = System.Windows.Forms.DockStyle.None;
                pnlPrevious.Location = new Point(0, 0);
                pnlPrevious.Width = intWidth;
                pnlPrevious.Height = intHeight;
            }
            else
            {
                //挂载动画事件.
                timeOptionAnimate.Tick += new EventHandler(timeOptionAnimateOpen_Tick);

                pnlCurrent = dicSelectOptions[((LabelX)sender)];

                //为动画进行属性初始化.
                pnlCurrent.Visible = true;
                pnlCurrent.BringToFront();

                pnlCurrent.Dock = System.Windows.Forms.DockStyle.Fill;

                intWidth = pnlCurrent.Width;
                intHeight = pnlCurrent.Height;
                intWidthSub = intWidth / 10;

                pnlCurrent.Dock = System.Windows.Forms.DockStyle.None;
                pnlCurrent.Location = new Point(-intWidth, 0);
                pnlCurrent.Width = intWidth;
                pnlCurrent.Height = intHeight;
            }
            #endregion
            timeOptionAnimate.Start();
        }
        /// <summary>
        /// 打开面板动画.
        /// </summary>
        private void AnimateControlFuncOpen()
        {
            //如果对象为空终止.
            if (pnlCurrent == null)
            {
                timeOptionAnimate.Stop();
                return;
            }
            //通过对象高宽计算动画速度.
            if (-pnlCurrent.Location.X >= intWidthSub)
            {
                pnlCurrent.Location = new Point(pnlCurrent.Location.X + intWidth / 30, 0);
            }
            else
            {
                pnlCurrent.Location = new Point(pnlCurrent.Location.X + intWidth / 100, 0);
            }

            if (-pnlCurrent.Location.X < 0)
            {
                pnlCurrent.Location = new Point(0, 0);
                timeOptionAnimate.Stop();
                pnlCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            }
        }
        /// <summary>
        /// 关闭面板动画.
        /// </summary>
        private void AnimateControlFuncClose()
        {
            //如果对象为空终止.
            if (pnlPrevious == null)
            {
                timeOptionAnimate.Stop();
                return;
            }
            //通过对象高宽计算动画速度.
            if (intWidth + pnlPrevious.Location.X >= intWidthSub)
            {
                pnlPrevious.Location = new Point(pnlPrevious.Location.X - intWidth / 30, 0);
            }
            else
            {
                pnlPrevious.Location = new Point(pnlPrevious.Location.X - intWidth / 100, 0);
            }

            if (pnlPrevious.Location.X < -intWidth)
            {
                pnlPrevious.Location = new Point(-intWidth, 0);
                timeOptionAnimate.Stop();
                pnlPrevious.Visible = false;
            }
        }
        /// <summary>
        /// 面板动画打开时间事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeOptionAnimateOpen_Tick(object sender, EventArgs e)
        {
            AnimateControlFuncOpen();
        }
        /// <summary>
        /// 面板动画关闭时间事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeOptionAnimateClose_Tick(object sender, EventArgs e)
        {
            AnimateControlFuncClose();
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
            this.TopMost = true;
            this.TopMost = false;
            //启动事件初始化.
            LoadTransaction();
            //默认风格设置.
            sbStyle.Value = false;
            //默认位置大小设置.
            SetWindowsInitLocalSize();
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
        private void SetWindowsMax()
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
        /// <summary>
        /// 设置窗体的初始化位置和大小.
        /// </summary>
        private void SetWindowsInitLocalSize()
        {
            //窗体系数.
            int intFormNum = Convert.ToInt32(
                (new decimal(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width)
                /
                new decimal(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height) * 20));

            //窗体位置.
            this.Left = intFormNum;
            this.Top = intFormNum;

            //窗体大小.
            if (this.MinimumSize.Height + intFormNum >= System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height
                ||
                this.MinimumSize.Width + intFormNum >= System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            else
            {
                this.Size = new Size(
                    System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - intFormNum * 2,
                    System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - intFormNum * 2);
            }
        }
        #endregion


        private void btnTEST_Click(object sender, EventArgs e)
        {
            UTorrentWebRequest test = new UTorrentWebRequest();

            Torrents torrents = test.GetTorrents();
        }

    }
}
