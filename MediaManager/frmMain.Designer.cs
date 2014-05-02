namespace MediaManager
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.sbStyle = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.pnlSelectMenu = new DevComponents.DotNetBar.PanelEx();
            this.pnl = new DevComponents.DotNetBar.PanelEx();
            this.lblOptionThree = new DevComponents.DotNetBar.LabelX();
            this.lblOptionTwo = new DevComponents.DotNetBar.LabelX();
            this.lblOptionOne = new DevComponents.DotNetBar.LabelX();
            this.pnlSelectMenuBottom = new DevComponents.DotNetBar.PanelEx();
            this.pnlSelectMenuTop = new DevComponents.DotNetBar.PanelEx();
            this.pnlLeftContent = new DevComponents.DotNetBar.PanelEx();
            this.pnlRightContent = new DevComponents.DotNetBar.PanelEx();
            this.pnlCenterContent = new DevComponents.DotNetBar.PanelEx();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.pnlTitle = new DevComponents.DotNetBar.PanelEx();
            this.btnMin = new DevComponents.DotNetBar.ButtonX();
            this.btnMax = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.pnlMain = new DevComponents.DotNetBar.PanelEx();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pnlSelectMenu.SuspendLayout();
            this.pnl.SuspendLayout();
            this.pnlLeftContent.SuspendLayout();
            this.pnlRightContent.SuspendLayout();
            this.pnlCenterContent.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.Gray);
            // 
            // sbStyle
            // 
            this.sbStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbStyle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.sbStyle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbStyle.ForeColor = System.Drawing.Color.Black;
            this.sbStyle.Location = new System.Drawing.Point(654, 7);
            this.sbStyle.Name = "sbStyle";
            this.sbStyle.OffText = "灰";
            this.sbStyle.OnText = "白";
            this.sbStyle.Size = new System.Drawing.Size(66, 23);
            this.sbStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sbStyle.TabIndex = 8;
            this.sbStyle.TabStop = false;
            this.sbStyle.ValueChanged += new System.EventHandler(this.sbStyle_ValueChanged);
            // 
            // pnlSelectMenu
            // 
            this.pnlSelectMenu.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSelectMenu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlSelectMenu.Controls.Add(this.pnl);
            this.pnlSelectMenu.Controls.Add(this.pnlSelectMenuBottom);
            this.pnlSelectMenu.Controls.Add(this.pnlSelectMenuTop);
            this.pnlSelectMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSelectMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectMenu.Name = "pnlSelectMenu";
            this.pnlSelectMenu.Size = new System.Drawing.Size(200, 596);
            this.pnlSelectMenu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlSelectMenu.Style.BackColor1.Color = System.Drawing.Color.Silver;
            this.pnlSelectMenu.Style.BackColor2.Color = System.Drawing.Color.Gray;
            this.pnlSelectMenu.Style.BorderColor.Color = System.Drawing.Color.DarkGray;
            this.pnlSelectMenu.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.pnlSelectMenu.Style.BorderWidth = 0;
            this.pnlSelectMenu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlSelectMenu.Style.GradientAngle = 90;
            this.pnlSelectMenu.TabIndex = 9;
            // 
            // pnl
            // 
            this.pnl.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl.Controls.Add(this.lblOptionThree);
            this.pnl.Controls.Add(this.lblOptionTwo);
            this.pnl.Controls.Add(this.lblOptionOne);
            this.pnl.Location = new System.Drawing.Point(-1, 93);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(202, 196);
            this.pnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl.Style.BorderWidth = 0;
            this.pnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl.Style.GradientAngle = 90;
            this.pnl.TabIndex = 2;
            // 
            // lblOptionThree
            // 
            this.lblOptionThree.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblOptionThree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblOptionThree.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOptionThree.ForeColor = System.Drawing.Color.Black;
            this.lblOptionThree.Image = ((System.Drawing.Image)(resources.GetObject("lblOptionThree.Image")));
            this.lblOptionThree.ImageTextSpacing = 15;
            this.lblOptionThree.Location = new System.Drawing.Point(-1, 112);
            this.lblOptionThree.Name = "lblOptionThree";
            this.lblOptionThree.Size = new System.Drawing.Size(205, 40);
            this.lblOptionThree.TabIndex = 2;
            this.lblOptionThree.Text = "欢迎使用媒体管理";
            this.lblOptionThree.Click += new System.EventHandler(this.lblOption_Click);
            this.lblOptionThree.MouseEnter += new System.EventHandler(this.lblOption_MouseEnter);
            this.lblOptionThree.MouseLeave += new System.EventHandler(this.lblOption_MouseLeave);
            // 
            // lblOptionTwo
            // 
            this.lblOptionTwo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblOptionTwo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblOptionTwo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOptionTwo.ForeColor = System.Drawing.Color.Black;
            this.lblOptionTwo.Image = ((System.Drawing.Image)(resources.GetObject("lblOptionTwo.Image")));
            this.lblOptionTwo.ImageTextSpacing = 15;
            this.lblOptionTwo.Location = new System.Drawing.Point(-1, 72);
            this.lblOptionTwo.Name = "lblOptionTwo";
            this.lblOptionTwo.Size = new System.Drawing.Size(205, 40);
            this.lblOptionTwo.TabIndex = 1;
            this.lblOptionTwo.Text = "欢迎使用媒体管理";
            this.lblOptionTwo.Click += new System.EventHandler(this.lblOption_Click);
            this.lblOptionTwo.MouseEnter += new System.EventHandler(this.lblOption_MouseEnter);
            this.lblOptionTwo.MouseLeave += new System.EventHandler(this.lblOption_MouseLeave);
            // 
            // lblOptionOne
            // 
            this.lblOptionOne.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblOptionOne.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblOptionOne.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOptionOne.ForeColor = System.Drawing.Color.Black;
            this.lblOptionOne.Image = ((System.Drawing.Image)(resources.GetObject("lblOptionOne.Image")));
            this.lblOptionOne.ImageTextSpacing = 15;
            this.lblOptionOne.Location = new System.Drawing.Point(-1, 32);
            this.lblOptionOne.Name = "lblOptionOne";
            this.lblOptionOne.Size = new System.Drawing.Size(205, 40);
            this.lblOptionOne.TabIndex = 0;
            this.lblOptionOne.Text = "欢迎使用媒体管理";
            this.lblOptionOne.Click += new System.EventHandler(this.lblOption_Click);
            this.lblOptionOne.MouseEnter += new System.EventHandler(this.lblOption_MouseEnter);
            this.lblOptionOne.MouseLeave += new System.EventHandler(this.lblOption_MouseLeave);
            // 
            // pnlSelectMenuBottom
            // 
            this.pnlSelectMenuBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSelectMenuBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlSelectMenuBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSelectMenuBottom.Location = new System.Drawing.Point(0, 555);
            this.pnlSelectMenuBottom.Name = "pnlSelectMenuBottom";
            this.pnlSelectMenuBottom.Size = new System.Drawing.Size(200, 41);
            this.pnlSelectMenuBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlSelectMenuBottom.Style.BackColor1.Color = System.Drawing.Color.Gray;
            this.pnlSelectMenuBottom.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlSelectMenuBottom.Style.BorderColor.Alpha = ((byte)(0));
            this.pnlSelectMenuBottom.Style.BorderColor.Color = System.Drawing.Color.White;
            this.pnlSelectMenuBottom.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top;
            this.pnlSelectMenuBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlSelectMenuBottom.Style.GradientAngle = 90;
            this.pnlSelectMenuBottom.TabIndex = 1;
            this.pnlSelectMenuBottom.Text = "panelEx1";
            // 
            // pnlSelectMenuTop
            // 
            this.pnlSelectMenuTop.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSelectMenuTop.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlSelectMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectMenuTop.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectMenuTop.Name = "pnlSelectMenuTop";
            this.pnlSelectMenuTop.Size = new System.Drawing.Size(200, 60);
            this.pnlSelectMenuTop.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlSelectMenuTop.Style.BackColor1.Color = System.Drawing.Color.Gray;
            this.pnlSelectMenuTop.Style.BorderColor.Color = System.Drawing.Color.White;
            this.pnlSelectMenuTop.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.pnlSelectMenuTop.Style.BorderWidth = 0;
            this.pnlSelectMenuTop.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlSelectMenuTop.Style.GradientAngle = 90;
            this.pnlSelectMenuTop.TabIndex = 0;
            this.pnlSelectMenuTop.Text = "panelEx1";
            this.pnlSelectMenuTop.DoubleClick += new System.EventHandler(this.pnlTitle_DoubleClick);
            this.pnlSelectMenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            // 
            // pnlLeftContent
            // 
            this.pnlLeftContent.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlLeftContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlLeftContent.Controls.Add(this.pnlSelectMenu);
            this.pnlLeftContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftContent.Location = new System.Drawing.Point(2, 2);
            this.pnlLeftContent.Name = "pnlLeftContent";
            this.pnlLeftContent.Size = new System.Drawing.Size(200, 596);
            this.pnlLeftContent.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlLeftContent.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlLeftContent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlLeftContent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlLeftContent.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.pnlLeftContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlLeftContent.Style.GradientAngle = 90;
            this.pnlLeftContent.TabIndex = 10;
            this.pnlLeftContent.Text = "panelEx2";
            // 
            // pnlRightContent
            // 
            this.pnlRightContent.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlRightContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlRightContent.Controls.Add(this.pnlCenterContent);
            this.pnlRightContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightContent.Location = new System.Drawing.Point(202, 62);
            this.pnlRightContent.Name = "pnlRightContent";
            this.pnlRightContent.Padding = new System.Windows.Forms.Padding(0, 0, 40, 40);
            this.pnlRightContent.Size = new System.Drawing.Size(820, 536);
            this.pnlRightContent.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlRightContent.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlRightContent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlRightContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlRightContent.Style.GradientAngle = 90;
            this.pnlRightContent.TabIndex = 11;
            this.pnlRightContent.Text = "panelEx3";
            this.pnlRightContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            // 
            // pnlCenterContent
            // 
            this.pnlCenterContent.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlCenterContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlCenterContent.Controls.Add(this.webBrowser);
            this.pnlCenterContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterContent.Location = new System.Drawing.Point(0, 0);
            this.pnlCenterContent.Name = "pnlCenterContent";
            this.pnlCenterContent.Size = new System.Drawing.Size(780, 496);
            this.pnlCenterContent.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlCenterContent.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlCenterContent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlCenterContent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlCenterContent.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.pnlCenterContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlCenterContent.Style.GradientAngle = 90;
            this.pnlCenterContent.TabIndex = 0;
            this.pnlCenterContent.Text = "panelEx4";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(780, 496);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http://chdbits.org/", System.UriKind.Absolute);
            // 
            // pnlTitle
            // 
            this.pnlTitle.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlTitle.Controls.Add(this.sbStyle);
            this.pnlTitle.Controls.Add(this.btnMin);
            this.pnlTitle.Controls.Add(this.btnMax);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(202, 2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(820, 60);
            this.pnlTitle.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlTitle.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.pnlTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlTitle.Style.GradientAngle = 90;
            this.pnlTitle.TabIndex = 12;
            this.pnlTitle.Text = "panelEx5";
            this.pnlTitle.DoubleClick += new System.EventHandler(this.pnlTitle_DoubleClick);
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(728, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(24, 23);
            this.btnMin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Text = "-";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMax.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(758, 7);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(24, 23);
            this.btnMax.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Text = "□";
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(788, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "×";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlMain.Controls.Add(this.pnlRightContent);
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.Controls.Add(this.pnlLeftContent);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(2);
            this.pnlMain.Size = new System.Drawing.Size(1024, 600);
            this.pnlMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlMain.Style.BackColor1.Color = System.Drawing.Color.DarkGray;
            this.pnlMain.Style.BackColor2.Color = System.Drawing.Color.DarkGray;
            this.pnlMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlMain.Style.GradientAngle = 90;
            this.pnlMain.TabIndex = 13;
            this.pnlMain.Text = "panelEx6";
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseDown);
            this.pnlMain.MouseLeave += new System.EventHandler(this.panelEx6_MouseLeave);
            this.pnlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseMove);
            this.pnlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmStyle_MouseUp);
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlSelectMenu.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.pnlLeftContent.ResumeLayout(false);
            this.pnlRightContent.ResumeLayout(false);
            this.pnlCenterContent.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.Controls.SwitchButton sbStyle;
        private DevComponents.DotNetBar.PanelEx pnlSelectMenu;
        private DevComponents.DotNetBar.PanelEx pnlLeftContent;
        private DevComponents.DotNetBar.PanelEx pnlRightContent;
        private DevComponents.DotNetBar.PanelEx pnlCenterContent;
        private System.Windows.Forms.WebBrowser webBrowser;
        private DevComponents.DotNetBar.PanelEx pnlTitle;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnMax;
        private DevComponents.DotNetBar.ButtonX btnMin;
        private DevComponents.DotNetBar.PanelEx pnlMain;
        private DevComponents.DotNetBar.PanelEx pnlSelectMenuTop;
        private DevComponents.DotNetBar.PanelEx pnlSelectMenuBottom;
        private DevComponents.DotNetBar.PanelEx pnl;
        private DevComponents.DotNetBar.LabelX lblOptionOne;
        private DevComponents.DotNetBar.LabelX lblOptionThree;
        private DevComponents.DotNetBar.LabelX lblOptionTwo;
        private System.Windows.Forms.Timer Timer;
    }
}

