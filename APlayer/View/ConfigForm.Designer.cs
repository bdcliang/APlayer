namespace APlayer.View
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.skinButtonConfirm = new CCWin.SkinControl.SkinButton();
            this.skinButtonExit = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.skinComboBoxState = new CCWin.SkinControl.SkinComboBox();
            this.lightEnable = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxXpos = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBoxYpos = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxHeight = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxWidth = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBoxIP = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBoxChipID = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxPorts = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox3 = new CCWin.SkinControl.SkinGroupBox();
            this.skinTextBoxListenPort = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxCirPlay = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxHideCur = new CCWin.SkinControl.SkinComboBox();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.skinGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinButtonConfirm
            // 
            this.skinButtonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonConfirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonConfirm.DownBack = null;
            this.skinButtonConfirm.Location = new System.Drawing.Point(42, 473);
            this.skinButtonConfirm.MouseBack = null;
            this.skinButtonConfirm.Name = "skinButtonConfirm";
            this.skinButtonConfirm.NormlBack = null;
            this.skinButtonConfirm.Size = new System.Drawing.Size(75, 23);
            this.skinButtonConfirm.TabIndex = 0;
            this.skinButtonConfirm.Text = "确定修改";
            this.skinButtonConfirm.UseVisualStyleBackColor = false;
            this.skinButtonConfirm.Click += new System.EventHandler(this.skinButtonConfirm_Click);
            // 
            // skinButtonExit
            // 
            this.skinButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonExit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonExit.DownBack = null;
            this.skinButtonExit.Location = new System.Drawing.Point(198, 472);
            this.skinButtonExit.MouseBack = null;
            this.skinButtonExit.Name = "skinButtonExit";
            this.skinButtonExit.NormlBack = null;
            this.skinButtonExit.Size = new System.Drawing.Size(75, 23);
            this.skinButtonExit.TabIndex = 1;
            this.skinButtonExit.Text = "退出程序";
            this.skinButtonExit.UseVisualStyleBackColor = false;
            this.skinButtonExit.Click += new System.EventHandler(this.skinButtonExit_Click);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Silver;
            this.skinGroupBox1.Controls.Add(this.skinTextBoxHeight);
            this.skinGroupBox1.Controls.Add(this.skinLabel4);
            this.skinGroupBox1.Controls.Add(this.skinTextBoxWidth);
            this.skinGroupBox1.Controls.Add(this.skinLabel3);
            this.skinGroupBox1.Controls.Add(this.skinTextBoxYpos);
            this.skinGroupBox1.Controls.Add(this.skinLabel2);
            this.skinGroupBox1.Controls.Add(this.skinTextBoxXpos);
            this.skinGroupBox1.Controls.Add(this.skinLabel1);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Location = new System.Drawing.Point(18, 37);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(281, 109);
            this.skinGroupBox1.TabIndex = 2;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "播放器屏幕配置";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Silver;
            this.skinGroupBox2.Controls.Add(this.skinLabel7);
            this.skinGroupBox2.Controls.Add(this.skinTextBoxPorts);
            this.skinGroupBox2.Controls.Add(this.skinTextBoxChipID);
            this.skinGroupBox2.Controls.Add(this.skinTextBoxIP);
            this.skinGroupBox2.Controls.Add(this.skinLabel6);
            this.skinGroupBox2.Controls.Add(this.skinLabel5);
            this.skinGroupBox2.Controls.Add(this.lightEnable);
            this.skinGroupBox2.Controls.Add(this.skinComboBoxState);
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Location = new System.Drawing.Point(22, 152);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(277, 153);
            this.skinGroupBox2.TabIndex = 3;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "播放器屏幕配置";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinComboBoxState
            // 
            this.skinComboBoxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxState.FormattingEnabled = true;
            this.skinComboBoxState.Items.AddRange(new object[] {
            "NC",
            "NO"});
            this.skinComboBoxState.Location = new System.Drawing.Point(194, 29);
            this.skinComboBoxState.Name = "skinComboBoxState";
            this.skinComboBoxState.Size = new System.Drawing.Size(59, 22);
            this.skinComboBoxState.TabIndex = 0;
            this.skinComboBoxState.Text = "NC";
            this.skinComboBoxState.WaterText = "";
            // 
            // lightEnable
            // 
            this.lightEnable.AutoSize = true;
            this.lightEnable.BackColor = System.Drawing.Color.Transparent;
            this.lightEnable.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.lightEnable.DownBack = null;
            this.lightEnable.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lightEnable.Location = new System.Drawing.Point(14, 30);
            this.lightEnable.MouseBack = null;
            this.lightEnable.Name = "lightEnable";
            this.lightEnable.NormlBack = null;
            this.lightEnable.SelectedDownBack = null;
            this.lightEnable.SelectedMouseBack = null;
            this.lightEnable.SelectedNormlBack = null;
            this.lightEnable.Size = new System.Drawing.Size(99, 21);
            this.lightEnable.TabIndex = 1;
            this.lightEnable.Text = "启动灯光控制";
            this.lightEnable.UseVisualStyleBackColor = false;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(15, 31);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(38, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "Xpos";
            // 
            // skinTextBoxXpos
            // 
            this.skinTextBoxXpos.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxXpos.DownBack = null;
            this.skinTextBoxXpos.Icon = null;
            this.skinTextBoxXpos.IconIsButton = false;
            this.skinTextBoxXpos.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxXpos.IsPasswordChat = '\0';
            this.skinTextBoxXpos.IsSystemPasswordChar = false;
            this.skinTextBoxXpos.Lines = new string[] {
        "0"};
            this.skinTextBoxXpos.Location = new System.Drawing.Point(56, 26);
            this.skinTextBoxXpos.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxXpos.MaxLength = 32767;
            this.skinTextBoxXpos.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxXpos.MouseBack = null;
            this.skinTextBoxXpos.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxXpos.Multiline = false;
            this.skinTextBoxXpos.Name = "skinTextBoxXpos";
            this.skinTextBoxXpos.NormlBack = null;
            this.skinTextBoxXpos.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxXpos.ReadOnly = false;
            this.skinTextBoxXpos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxXpos.Size = new System.Drawing.Size(53, 28);
            // 
            // 
            // 
            this.skinTextBoxXpos.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxXpos.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxXpos.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxXpos.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxXpos.SkinTxt.Name = "BaseText";
            this.skinTextBoxXpos.SkinTxt.Size = new System.Drawing.Size(43, 18);
            this.skinTextBoxXpos.SkinTxt.TabIndex = 0;
            this.skinTextBoxXpos.SkinTxt.Text = "0";
            this.skinTextBoxXpos.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxXpos.SkinTxt.WaterText = "";
            this.skinTextBoxXpos.TabIndex = 1;
            this.skinTextBoxXpos.Text = "0";
            this.skinTextBoxXpos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxXpos.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxXpos.WaterText = "";
            this.skinTextBoxXpos.WordWrap = true;
            // 
            // skinTextBoxYpos
            // 
            this.skinTextBoxYpos.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxYpos.DownBack = null;
            this.skinTextBoxYpos.Icon = null;
            this.skinTextBoxYpos.IconIsButton = false;
            this.skinTextBoxYpos.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxYpos.IsPasswordChat = '\0';
            this.skinTextBoxYpos.IsSystemPasswordChar = false;
            this.skinTextBoxYpos.Lines = new string[] {
        "0"};
            this.skinTextBoxYpos.Location = new System.Drawing.Point(181, 26);
            this.skinTextBoxYpos.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxYpos.MaxLength = 32767;
            this.skinTextBoxYpos.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxYpos.MouseBack = null;
            this.skinTextBoxYpos.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxYpos.Multiline = false;
            this.skinTextBoxYpos.Name = "skinTextBoxYpos";
            this.skinTextBoxYpos.NormlBack = null;
            this.skinTextBoxYpos.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxYpos.ReadOnly = false;
            this.skinTextBoxYpos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxYpos.Size = new System.Drawing.Size(50, 28);
            // 
            // 
            // 
            this.skinTextBoxYpos.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxYpos.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxYpos.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxYpos.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxYpos.SkinTxt.Name = "BaseText";
            this.skinTextBoxYpos.SkinTxt.Size = new System.Drawing.Size(40, 18);
            this.skinTextBoxYpos.SkinTxt.TabIndex = 0;
            this.skinTextBoxYpos.SkinTxt.Text = "0";
            this.skinTextBoxYpos.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxYpos.SkinTxt.WaterText = "";
            this.skinTextBoxYpos.TabIndex = 3;
            this.skinTextBoxYpos.Text = "0";
            this.skinTextBoxYpos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxYpos.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxYpos.WaterText = "";
            this.skinTextBoxYpos.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(136, 31);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(37, 17);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "Ypos";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(15, 70);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(42, 17);
            this.skinLabel3.TabIndex = 4;
            this.skinLabel3.Text = "Width";
            // 
            // skinTextBoxHeight
            // 
            this.skinTextBoxHeight.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxHeight.DownBack = null;
            this.skinTextBoxHeight.Icon = null;
            this.skinTextBoxHeight.IconIsButton = false;
            this.skinTextBoxHeight.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxHeight.IsPasswordChat = '\0';
            this.skinTextBoxHeight.IsSystemPasswordChar = false;
            this.skinTextBoxHeight.Lines = new string[] {
        "600"};
            this.skinTextBoxHeight.Location = new System.Drawing.Point(180, 65);
            this.skinTextBoxHeight.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxHeight.MaxLength = 32767;
            this.skinTextBoxHeight.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxHeight.MouseBack = null;
            this.skinTextBoxHeight.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxHeight.Multiline = false;
            this.skinTextBoxHeight.Name = "skinTextBoxHeight";
            this.skinTextBoxHeight.NormlBack = null;
            this.skinTextBoxHeight.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxHeight.ReadOnly = false;
            this.skinTextBoxHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxHeight.Size = new System.Drawing.Size(53, 28);
            // 
            // 
            // 
            this.skinTextBoxHeight.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxHeight.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxHeight.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxHeight.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxHeight.SkinTxt.Name = "BaseText";
            this.skinTextBoxHeight.SkinTxt.Size = new System.Drawing.Size(43, 18);
            this.skinTextBoxHeight.SkinTxt.TabIndex = 0;
            this.skinTextBoxHeight.SkinTxt.Text = "600";
            this.skinTextBoxHeight.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxHeight.SkinTxt.WaterText = "";
            this.skinTextBoxHeight.TabIndex = 7;
            this.skinTextBoxHeight.Text = "600";
            this.skinTextBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxHeight.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxHeight.WaterText = "";
            this.skinTextBoxHeight.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(136, 70);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(46, 17);
            this.skinLabel4.TabIndex = 6;
            this.skinLabel4.Text = "Height";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(136, 32);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(56, 17);
            this.skinLabel5.TabIndex = 8;
            this.skinLabel5.Text = "开关状态";
            // 
            // skinTextBoxWidth
            // 
            this.skinTextBoxWidth.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxWidth.DownBack = null;
            this.skinTextBoxWidth.Icon = null;
            this.skinTextBoxWidth.IconIsButton = false;
            this.skinTextBoxWidth.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxWidth.IsPasswordChat = '\0';
            this.skinTextBoxWidth.IsSystemPasswordChar = false;
            this.skinTextBoxWidth.Lines = new string[] {
        "1024"};
            this.skinTextBoxWidth.Location = new System.Drawing.Point(56, 65);
            this.skinTextBoxWidth.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxWidth.MaxLength = 32767;
            this.skinTextBoxWidth.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxWidth.MouseBack = null;
            this.skinTextBoxWidth.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxWidth.Multiline = false;
            this.skinTextBoxWidth.Name = "skinTextBoxWidth";
            this.skinTextBoxWidth.NormlBack = null;
            this.skinTextBoxWidth.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxWidth.ReadOnly = false;
            this.skinTextBoxWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxWidth.Size = new System.Drawing.Size(53, 28);
            // 
            // 
            // 
            this.skinTextBoxWidth.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxWidth.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxWidth.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxWidth.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxWidth.SkinTxt.Name = "BaseText";
            this.skinTextBoxWidth.SkinTxt.Size = new System.Drawing.Size(43, 18);
            this.skinTextBoxWidth.SkinTxt.TabIndex = 0;
            this.skinTextBoxWidth.SkinTxt.Text = "1024";
            this.skinTextBoxWidth.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxWidth.SkinTxt.WaterText = "";
            this.skinTextBoxWidth.TabIndex = 5;
            this.skinTextBoxWidth.Text = "1024";
            this.skinTextBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxWidth.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxWidth.WaterText = "";
            this.skinTextBoxWidth.WordWrap = true;
            // 
            // skinTextBoxIP
            // 
            this.skinTextBoxIP.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxIP.DownBack = null;
            this.skinTextBoxIP.Icon = null;
            this.skinTextBoxIP.IconIsButton = false;
            this.skinTextBoxIP.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxIP.IsPasswordChat = '\0';
            this.skinTextBoxIP.IsSystemPasswordChar = false;
            this.skinTextBoxIP.Lines = new string[] {
        "127.0.0.1"};
            this.skinTextBoxIP.Location = new System.Drawing.Point(135, 65);
            this.skinTextBoxIP.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxIP.MaxLength = 32767;
            this.skinTextBoxIP.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxIP.MouseBack = null;
            this.skinTextBoxIP.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxIP.Multiline = false;
            this.skinTextBoxIP.Name = "skinTextBoxIP";
            this.skinTextBoxIP.NormlBack = null;
            this.skinTextBoxIP.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxIP.ReadOnly = false;
            this.skinTextBoxIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxIP.Size = new System.Drawing.Size(118, 28);
            // 
            // 
            // 
            this.skinTextBoxIP.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxIP.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxIP.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxIP.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxIP.SkinTxt.Name = "BaseText";
            this.skinTextBoxIP.SkinTxt.Size = new System.Drawing.Size(108, 18);
            this.skinTextBoxIP.SkinTxt.TabIndex = 0;
            this.skinTextBoxIP.SkinTxt.Text = "127.0.0.1";
            this.skinTextBoxIP.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxIP.SkinTxt.WaterText = "";
            this.skinTextBoxIP.TabIndex = 6;
            this.skinTextBoxIP.Text = "127.0.0.1";
            this.skinTextBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxIP.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxIP.WaterText = "";
            this.skinTextBoxIP.WordWrap = true;
            // 
            // skinTextBoxChipID
            // 
            this.skinTextBoxChipID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxChipID.DownBack = null;
            this.skinTextBoxChipID.Icon = null;
            this.skinTextBoxChipID.IconIsButton = false;
            this.skinTextBoxChipID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxChipID.IsPasswordChat = '\0';
            this.skinTextBoxChipID.IsSystemPasswordChar = false;
            this.skinTextBoxChipID.Lines = new string[] {
        "1"};
            this.skinTextBoxChipID.Location = new System.Drawing.Point(50, 65);
            this.skinTextBoxChipID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxChipID.MaxLength = 32767;
            this.skinTextBoxChipID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxChipID.MouseBack = null;
            this.skinTextBoxChipID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxChipID.Multiline = false;
            this.skinTextBoxChipID.Name = "skinTextBoxChipID";
            this.skinTextBoxChipID.NormlBack = null;
            this.skinTextBoxChipID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxChipID.ReadOnly = false;
            this.skinTextBoxChipID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxChipID.Size = new System.Drawing.Size(50, 28);
            // 
            // 
            // 
            this.skinTextBoxChipID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxChipID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxChipID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxChipID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxChipID.SkinTxt.Name = "BaseText";
            this.skinTextBoxChipID.SkinTxt.Size = new System.Drawing.Size(40, 18);
            this.skinTextBoxChipID.SkinTxt.TabIndex = 0;
            this.skinTextBoxChipID.SkinTxt.Text = "1";
            this.skinTextBoxChipID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxChipID.SkinTxt.WaterText = "";
            this.skinTextBoxChipID.TabIndex = 9;
            this.skinTextBoxChipID.Text = "1";
            this.skinTextBoxChipID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxChipID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxChipID.WaterText = "";
            this.skinTextBoxChipID.WordWrap = true;
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(16, 71);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 8;
            this.skinLabel6.Text = "地址";
            // 
            // skinTextBoxPorts
            // 
            this.skinTextBoxPorts.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxPorts.DownBack = null;
            this.skinTextBoxPorts.Icon = null;
            this.skinTextBoxPorts.IconIsButton = false;
            this.skinTextBoxPorts.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxPorts.IsPasswordChat = '\0';
            this.skinTextBoxPorts.IsSystemPasswordChar = false;
            this.skinTextBoxPorts.Lines = new string[] {
        "1,2,3,4,5,6,7,8,9,10,11,12"};
            this.skinTextBoxPorts.Location = new System.Drawing.Point(52, 108);
            this.skinTextBoxPorts.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxPorts.MaxLength = 32767;
            this.skinTextBoxPorts.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxPorts.MouseBack = null;
            this.skinTextBoxPorts.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxPorts.Multiline = false;
            this.skinTextBoxPorts.Name = "skinTextBoxPorts";
            this.skinTextBoxPorts.NormlBack = null;
            this.skinTextBoxPorts.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxPorts.ReadOnly = false;
            this.skinTextBoxPorts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxPorts.Size = new System.Drawing.Size(201, 28);
            // 
            // 
            // 
            this.skinTextBoxPorts.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxPorts.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxPorts.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxPorts.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxPorts.SkinTxt.Name = "BaseText";
            this.skinTextBoxPorts.SkinTxt.Size = new System.Drawing.Size(191, 18);
            this.skinTextBoxPorts.SkinTxt.TabIndex = 0;
            this.skinTextBoxPorts.SkinTxt.Text = "1,2,3,4,5,6,7,8,9,10,11,12";
            this.skinTextBoxPorts.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxPorts.SkinTxt.WaterText = "";
            this.skinTextBoxPorts.TabIndex = 7;
            this.skinTextBoxPorts.Text = "1,2,3,4,5,6,7,8,9,10,11,12";
            this.skinTextBoxPorts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxPorts.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxPorts.WaterText = "";
            this.skinTextBoxPorts.WordWrap = true;
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(17, 114);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 10;
            this.skinLabel7.Text = "端口";
            // 
            // skinGroupBox3
            // 
            this.skinGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.BorderColor = System.Drawing.Color.Silver;
            this.skinGroupBox3.Controls.Add(this.skinLabel8);
            this.skinGroupBox3.Controls.Add(this.skinComboBoxHideCur);
            this.skinGroupBox3.Controls.Add(this.skinTextBoxListenPort);
            this.skinGroupBox3.Controls.Add(this.skinLabel9);
            this.skinGroupBox3.Controls.Add(this.skinLabel10);
            this.skinGroupBox3.Controls.Add(this.skinComboBoxCirPlay);
            this.skinGroupBox3.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox3.Location = new System.Drawing.Point(22, 311);
            this.skinGroupBox3.Name = "skinGroupBox3";
            this.skinGroupBox3.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Size = new System.Drawing.Size(277, 139);
            this.skinGroupBox3.TabIndex = 11;
            this.skinGroupBox3.TabStop = false;
            this.skinGroupBox3.Text = "播放器屏幕配置";
            this.skinGroupBox3.TitleBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinGroupBox3.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinTextBoxListenPort
            // 
            this.skinTextBoxListenPort.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxListenPort.DownBack = null;
            this.skinTextBoxListenPort.Icon = null;
            this.skinTextBoxListenPort.IconIsButton = false;
            this.skinTextBoxListenPort.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxListenPort.IsPasswordChat = '\0';
            this.skinTextBoxListenPort.IsSystemPasswordChar = false;
            this.skinTextBoxListenPort.Lines = new string[] {
        "9000"};
            this.skinTextBoxListenPort.Location = new System.Drawing.Point(87, 23);
            this.skinTextBoxListenPort.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxListenPort.MaxLength = 32767;
            this.skinTextBoxListenPort.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxListenPort.MouseBack = null;
            this.skinTextBoxListenPort.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxListenPort.Multiline = false;
            this.skinTextBoxListenPort.Name = "skinTextBoxListenPort";
            this.skinTextBoxListenPort.NormlBack = null;
            this.skinTextBoxListenPort.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxListenPort.ReadOnly = false;
            this.skinTextBoxListenPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxListenPort.Size = new System.Drawing.Size(166, 28);
            // 
            // 
            // 
            this.skinTextBoxListenPort.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxListenPort.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxListenPort.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxListenPort.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxListenPort.SkinTxt.Name = "BaseText";
            this.skinTextBoxListenPort.SkinTxt.Size = new System.Drawing.Size(156, 18);
            this.skinTextBoxListenPort.SkinTxt.TabIndex = 0;
            this.skinTextBoxListenPort.SkinTxt.Text = "9000";
            this.skinTextBoxListenPort.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxListenPort.SkinTxt.WaterText = "";
            this.skinTextBoxListenPort.TabIndex = 9;
            this.skinTextBoxListenPort.Text = "9000";
            this.skinTextBoxListenPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxListenPort.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxListenPort.WaterText = "";
            this.skinTextBoxListenPort.WordWrap = true;
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(16, 29);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(68, 17);
            this.skinLabel9.TabIndex = 8;
            this.skinLabel9.Text = "服务器端口";
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(21, 64);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(56, 17);
            this.skinLabel10.TabIndex = 8;
            this.skinLabel10.Text = "循环播放";
            // 
            // skinComboBoxCirPlay
            // 
            this.skinComboBoxCirPlay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxCirPlay.FormattingEnabled = true;
            this.skinComboBoxCirPlay.Items.AddRange(new object[] {
            "是",
            "否"});
            this.skinComboBoxCirPlay.Location = new System.Drawing.Point(88, 62);
            this.skinComboBoxCirPlay.Name = "skinComboBoxCirPlay";
            this.skinComboBoxCirPlay.Size = new System.Drawing.Size(165, 22);
            this.skinComboBoxCirPlay.TabIndex = 0;
            this.skinComboBoxCirPlay.Text = "是";
            this.skinComboBoxCirPlay.WaterText = "";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(21, 97);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(56, 17);
            this.skinLabel8.TabIndex = 11;
            this.skinLabel8.Text = "隐藏鼠标";
            // 
            // skinComboBoxHideCur
            // 
            this.skinComboBoxHideCur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxHideCur.FormattingEnabled = true;
            this.skinComboBoxHideCur.Items.AddRange(new object[] {
            "是",
            "否"});
            this.skinComboBoxHideCur.Location = new System.Drawing.Point(88, 95);
            this.skinComboBoxHideCur.Name = "skinComboBoxHideCur";
            this.skinComboBoxHideCur.Size = new System.Drawing.Size(165, 22);
            this.skinComboBoxHideCur.TabIndex = 10;
            this.skinComboBoxHideCur.Text = "否";
            this.skinComboBoxHideCur.WaterText = "";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 527);
            this.Controls.Add(this.skinGroupBox3);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.Controls.Add(this.skinButtonExit);
            this.Controls.Add(this.skinButtonConfirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.skinGroupBox3.ResumeLayout(false);
            this.skinGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButtonConfirm;
        private CCWin.SkinControl.SkinButton skinButtonExit;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinTextBox skinTextBoxHeight;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinTextBox skinTextBoxWidth;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinTextBox skinTextBoxYpos;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox skinTextBoxXpos;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinTextBox skinTextBoxPorts;
        private CCWin.SkinControl.SkinTextBox skinTextBoxChipID;
        private CCWin.SkinControl.SkinTextBox skinTextBoxIP;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinCheckBox lightEnable;
        private CCWin.SkinControl.SkinComboBox skinComboBoxState;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox3;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinComboBox skinComboBoxHideCur;
        private CCWin.SkinControl.SkinTextBox skinTextBoxListenPort;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinComboBox skinComboBoxCirPlay;
    }
}