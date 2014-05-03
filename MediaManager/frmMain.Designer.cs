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
            this.pnlSelectOptions = new DevComponents.DotNetBar.PanelEx();
            this.lblOptionMain = new DevComponents.DotNetBar.LabelX();
            this.lblOptionThree = new DevComponents.DotNetBar.LabelX();
            this.lblOptionTwo = new DevComponents.DotNetBar.LabelX();
            this.lblOptionOne = new DevComponents.DotNetBar.LabelX();
            this.pnlSelectMenuBottom = new DevComponents.DotNetBar.PanelEx();
            this.pnlSelectMenuTop = new DevComponents.DotNetBar.PanelEx();
            this.pnlLeftContent = new DevComponents.DotNetBar.PanelEx();
            this.pnlRightContent = new DevComponents.DotNetBar.PanelEx();
            this.pnlCenterContent = new DevComponents.DotNetBar.PanelEx();
            this.pnlOptionThree = new DevComponents.DotNetBar.PanelEx();
            this.pnlOptionTwo = new DevComponents.DotNetBar.PanelEx();
            this.pnlOptionOne = new DevComponents.DotNetBar.PanelEx();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.pnlTitle = new DevComponents.DotNetBar.PanelEx();
            this.btnMin = new DevComponents.DotNetBar.ButtonX();
            this.btnMax = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.pnlMain = new DevComponents.DotNetBar.PanelEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnlSelectMenu.SuspendLayout();
            this.pnlSelectOptions.SuspendLayout();
            this.pnlLeftContent.SuspendLayout();
            this.pnlRightContent.SuspendLayout();
            this.pnlCenterContent.SuspendLayout();
            this.pnlOptionOne.SuspendLayout();
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
            this.pnlSelectMenu.Controls.Add(this.pnlSelectOptions);
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
            // pnlSelectOptions
            // 
            this.pnlSelectOptions.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlSelectOptions.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlSelectOptions.Controls.Add(this.labelX1);
            this.pnlSelectOptions.Controls.Add(this.lblOptionMain);
            this.pnlSelectOptions.Controls.Add(this.lblOptionThree);
            this.pnlSelectOptions.Controls.Add(this.lblOptionTwo);
            this.pnlSelectOptions.Controls.Add(this.lblOptionOne);
            this.pnlSelectOptions.Location = new System.Drawing.Point(-1, 93);
            this.pnlSelectOptions.Name = "pnlSelectOptions";
            this.pnlSelectOptions.Size = new System.Drawing.Size(202, 373);
            this.pnlSelectOptions.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlSelectOptions.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlSelectOptions.Style.BorderWidth = 0;
            this.pnlSelectOptions.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlSelectOptions.Style.GradientAngle = 90;
            this.pnlSelectOptions.TabIndex = 2;
            // 
            // lblOptionMain
            // 
            this.lblOptionMain.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblOptionMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblOptionMain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOptionMain.ForeColor = System.Drawing.Color.Black;
            this.lblOptionMain.Image = ((System.Drawing.Image)(resources.GetObject("lblOptionMain.Image")));
            this.lblOptionMain.ImageTextSpacing = 15;
            this.lblOptionMain.Location = new System.Drawing.Point(-1, 27);
            this.lblOptionMain.Name = "lblOptionMain";
            this.lblOptionMain.Size = new System.Drawing.Size(205, 40);
            this.lblOptionMain.TabIndex = 3;
            this.lblOptionMain.Tag = "main";
            this.lblOptionMain.Text = "欢迎使用媒体管理";
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
            this.lblOptionThree.Location = new System.Drawing.Point(-1, 147);
            this.lblOptionThree.Name = "lblOptionThree";
            this.lblOptionThree.Size = new System.Drawing.Size(205, 40);
            this.lblOptionThree.TabIndex = 2;
            this.lblOptionThree.Text = "面板3";
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
            this.lblOptionTwo.Location = new System.Drawing.Point(-1, 107);
            this.lblOptionTwo.Name = "lblOptionTwo";
            this.lblOptionTwo.Size = new System.Drawing.Size(205, 40);
            this.lblOptionTwo.TabIndex = 1;
            this.lblOptionTwo.Text = "面板2";
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
            this.lblOptionOne.Location = new System.Drawing.Point(-1, 67);
            this.lblOptionOne.Name = "lblOptionOne";
            this.lblOptionOne.Size = new System.Drawing.Size(205, 40);
            this.lblOptionOne.TabIndex = 0;
            this.lblOptionOne.Text = "面板1";
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
            // 
            // pnlCenterContent
            // 
            this.pnlCenterContent.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlCenterContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlCenterContent.Controls.Add(this.buttonX1);
            this.pnlCenterContent.Controls.Add(this.pnlOptionThree);
            this.pnlCenterContent.Controls.Add(this.pnlOptionTwo);
            this.pnlCenterContent.Controls.Add(this.pnlOptionOne);
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
            this.pnlCenterContent.Text = "pnlCenterContent";
            // 
            // pnlOptionThree
            // 
            this.pnlOptionThree.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlOptionThree.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlOptionThree.Location = new System.Drawing.Point(53, 257);
            this.pnlOptionThree.Name = "pnlOptionThree";
            this.pnlOptionThree.Size = new System.Drawing.Size(200, 100);
            this.pnlOptionThree.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlOptionThree.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlOptionThree.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlOptionThree.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlOptionThree.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlOptionThree.Style.GradientAngle = 90;
            this.pnlOptionThree.TabIndex = 3;
            this.pnlOptionThree.Tag = "lblOptionThree";
            this.pnlOptionThree.Text = "pnlOptionThree";
            // 
            // pnlOptionTwo
            // 
            this.pnlOptionTwo.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlOptionTwo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlOptionTwo.Location = new System.Drawing.Point(53, 151);
            this.pnlOptionTwo.Name = "pnlOptionTwo";
            this.pnlOptionTwo.Size = new System.Drawing.Size(200, 100);
            this.pnlOptionTwo.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlOptionTwo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlOptionTwo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlOptionTwo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlOptionTwo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlOptionTwo.Style.GradientAngle = 90;
            this.pnlOptionTwo.TabIndex = 2;
            this.pnlOptionTwo.Tag = "lblOptionTwo";
            this.pnlOptionTwo.Text = "pnlOptionTwo";
            // 
            // pnlOptionOne
            // 
            this.pnlOptionOne.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlOptionOne.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlOptionOne.Controls.Add(this.webBrowser);
            this.pnlOptionOne.Location = new System.Drawing.Point(53, 45);
            this.pnlOptionOne.Name = "pnlOptionOne";
            this.pnlOptionOne.Size = new System.Drawing.Size(200, 100);
            this.pnlOptionOne.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlOptionOne.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlOptionOne.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlOptionOne.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlOptionOne.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlOptionOne.Style.GradientAngle = 90;
            this.pnlOptionOne.TabIndex = 1;
            this.pnlOptionOne.Tag = "lblOptionOne";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(200, 100);
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
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(460, 333);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "buttonX1";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Image = ((System.Drawing.Image)(resources.GetObject("labelX1.Image")));
            this.labelX1.ImageTextSpacing = 15;
            this.labelX1.Location = new System.Drawing.Point(-1, 224);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(205, 40);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "面板4";
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlSelectMenu.ResumeLayout(false);
            this.pnlSelectOptions.ResumeLayout(false);
            this.pnlLeftContent.ResumeLayout(false);
            this.pnlRightContent.ResumeLayout(false);
            this.pnlCenterContent.ResumeLayout(false);
            this.pnlOptionOne.ResumeLayout(false);
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
        private DevComponents.DotNetBar.PanelEx pnlSelectOptions;
        private DevComponents.DotNetBar.LabelX lblOptionOne;
        private DevComponents.DotNetBar.LabelX lblOptionThree;
        private DevComponents.DotNetBar.LabelX lblOptionTwo;
        private DevComponents.DotNetBar.PanelEx pnlOptionThree;
        private DevComponents.DotNetBar.PanelEx pnlOptionTwo;
        private DevComponents.DotNetBar.PanelEx pnlOptionOne;
        private DevComponents.DotNetBar.LabelX lblOptionMain;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}

