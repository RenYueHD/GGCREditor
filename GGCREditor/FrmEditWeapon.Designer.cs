namespace GGCREditor
{
    partial class FrmEditWeapon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditWeapon));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lsGundam = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cboMpLimit = new System.Windows.Forms.ComboBox();
            this.cboSpec = new System.Windows.Forms.ComboBox();
            this.cboIco = new System.Windows.Forms.ComboBox();
            this.cboProp = new System.Windows.Forms.ComboBox();
            this.cboAE1 = new System.Windows.Forms.ComboBox();
            this.cboAE2 = new System.Windows.Forms.ComboBox();
            this.cboAE3 = new System.Windows.Forms.ComboBox();
            this.cboAE4 = new System.Windows.Forms.ComboBox();
            this.cboAE5 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.chkUse5 = new System.Windows.Forms.CheckBox();
            this.chkUse4 = new System.Windows.Forms.CheckBox();
            this.chkUse3 = new System.Windows.Forms.CheckBox();
            this.chkUse2 = new System.Windows.Forms.CheckBox();
            this.chkUse1 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnKnow = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHitCount = new System.Windows.Forms.TextBox();
            this.txtMoveAct = new System.Windows.Forms.TextBox();
            this.txtRange2 = new System.Windows.Forms.TextBox();
            this.txtRange1 = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHitRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(33, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 21);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lsGundam
            // 
            this.lsGundam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lsGundam.FormattingEnabled = true;
            this.lsGundam.ItemHeight = 16;
            this.lsGundam.Location = new System.Drawing.Point(12, 33);
            this.lsGundam.Name = "lsGundam";
            this.lsGundam.Size = new System.Drawing.Size(248, 508);
            this.lsGundam.TabIndex = 9;
            this.lsGundam.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsGundam_DrawItem);
            this.lsGundam.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lsGundam_MeasureItem);
            this.lsGundam.SelectedIndexChanged += new System.EventHandler(this.lsGundam_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 8;
            this.label19.Text = "搜";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.cboMpLimit);
            this.groupBox1.Controls.Add(this.cboSpec);
            this.groupBox1.Controls.Add(this.cboIco);
            this.groupBox1.Controls.Add(this.cboProp);
            this.groupBox1.Controls.Add(this.cboAE1);
            this.groupBox1.Controls.Add(this.cboAE2);
            this.groupBox1.Controls.Add(this.cboAE3);
            this.groupBox1.Controls.Add(this.cboAE4);
            this.groupBox1.Controls.Add(this.cboAE5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.chkUse5);
            this.groupBox1.Controls.Add(this.chkUse4);
            this.groupBox1.Controls.Add(this.chkUse3);
            this.groupBox1.Controls.Add(this.chkUse2);
            this.groupBox1.Controls.Add(this.chkUse1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUnKnow);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtPower);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEN);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHitCount);
            this.groupBox1.Controls.Add(this.txtMoveAct);
            this.groupBox1.Controls.Add(this.txtRange2);
            this.groupBox1.Controls.Add(this.txtRange1);
            this.groupBox1.Controls.Add(this.txtMP);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtHitRate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(266, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 532);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "属性";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(377, 168);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(11, 12);
            this.label25.TabIndex = 30;
            this.label25.Text = "-";
            // 
            // cboMpLimit
            // 
            this.cboMpLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMpLimit.FormattingEnabled = true;
            this.cboMpLimit.Location = new System.Drawing.Point(310, 92);
            this.cboMpLimit.Name = "cboMpLimit";
            this.cboMpLimit.Size = new System.Drawing.Size(144, 20);
            this.cboMpLimit.TabIndex = 25;
            // 
            // cboSpec
            // 
            this.cboSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpec.FormattingEnabled = true;
            this.cboSpec.Location = new System.Drawing.Point(310, 128);
            this.cboSpec.Name = "cboSpec";
            this.cboSpec.Size = new System.Drawing.Size(144, 20);
            this.cboSpec.TabIndex = 25;
            // 
            // cboIco
            // 
            this.cboIco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIco.FormattingEnabled = true;
            this.cboIco.Location = new System.Drawing.Point(80, 236);
            this.cboIco.Name = "cboIco";
            this.cboIco.Size = new System.Drawing.Size(144, 20);
            this.cboIco.TabIndex = 25;
            // 
            // cboProp
            // 
            this.cboProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProp.FormattingEnabled = true;
            this.cboProp.Location = new System.Drawing.Point(80, 272);
            this.cboProp.Name = "cboProp";
            this.cboProp.Size = new System.Drawing.Size(144, 20);
            this.cboProp.TabIndex = 25;
            // 
            // cboAE1
            // 
            this.cboAE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAE1.FormattingEnabled = true;
            this.cboAE1.Location = new System.Drawing.Point(117, 342);
            this.cboAE1.Name = "cboAE1";
            this.cboAE1.Size = new System.Drawing.Size(51, 20);
            this.cboAE1.TabIndex = 25;
            // 
            // cboAE2
            // 
            this.cboAE2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAE2.FormattingEnabled = true;
            this.cboAE2.Location = new System.Drawing.Point(225, 342);
            this.cboAE2.Name = "cboAE2";
            this.cboAE2.Size = new System.Drawing.Size(51, 20);
            this.cboAE2.TabIndex = 26;
            // 
            // cboAE3
            // 
            this.cboAE3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAE3.FormattingEnabled = true;
            this.cboAE3.Location = new System.Drawing.Point(333, 342);
            this.cboAE3.Name = "cboAE3";
            this.cboAE3.Size = new System.Drawing.Size(51, 20);
            this.cboAE3.TabIndex = 27;
            // 
            // cboAE4
            // 
            this.cboAE4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAE4.FormattingEnabled = true;
            this.cboAE4.Location = new System.Drawing.Point(117, 373);
            this.cboAE4.Name = "cboAE4";
            this.cboAE4.Size = new System.Drawing.Size(51, 20);
            this.cboAE4.TabIndex = 28;
            // 
            // cboAE5
            // 
            this.cboAE5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAE5.FormattingEnabled = true;
            this.cboAE5.Location = new System.Drawing.Point(225, 372);
            this.cboAE5.Name = "cboAE5";
            this.cboAE5.Size = new System.Drawing.Size(51, 20);
            this.cboAE5.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 20;
            this.label13.Text = "宇";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(202, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 21;
            this.label15.Text = "空";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(308, 346);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 22;
            this.label20.Text = "地";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(84, 376);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 23;
            this.label21.Text = "水上";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(190, 376);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 24;
            this.label22.Text = "水中";
            // 
            // chkUse5
            // 
            this.chkUse5.AutoSize = true;
            this.chkUse5.Location = new System.Drawing.Point(310, 319);
            this.chkUse5.Name = "chkUse5";
            this.chkUse5.Size = new System.Drawing.Size(48, 16);
            this.chkUse5.TabIndex = 17;
            this.chkUse5.Text = "水中";
            this.chkUse5.UseVisualStyleBackColor = true;
            // 
            // chkUse4
            // 
            this.chkUse4.AutoSize = true;
            this.chkUse4.Location = new System.Drawing.Point(244, 319);
            this.chkUse4.Name = "chkUse4";
            this.chkUse4.Size = new System.Drawing.Size(48, 16);
            this.chkUse4.TabIndex = 17;
            this.chkUse4.Text = "水面";
            this.chkUse4.UseVisualStyleBackColor = true;
            // 
            // chkUse3
            // 
            this.chkUse3.AutoSize = true;
            this.chkUse3.Location = new System.Drawing.Point(190, 319);
            this.chkUse3.Name = "chkUse3";
            this.chkUse3.Size = new System.Drawing.Size(36, 16);
            this.chkUse3.TabIndex = 17;
            this.chkUse3.Text = "地";
            this.chkUse3.UseVisualStyleBackColor = true;
            // 
            // chkUse2
            // 
            this.chkUse2.AutoSize = true;
            this.chkUse2.Location = new System.Drawing.Point(136, 319);
            this.chkUse2.Name = "chkUse2";
            this.chkUse2.Size = new System.Drawing.Size(36, 16);
            this.chkUse2.TabIndex = 17;
            this.chkUse2.Text = "空";
            this.chkUse2.UseVisualStyleBackColor = true;
            // 
            // chkUse1
            // 
            this.chkUse1.AutoSize = true;
            this.chkUse1.Location = new System.Drawing.Point(82, 319);
            this.chkUse1.Name = "chkUse1";
            this.chkUse1.Size = new System.Drawing.Size(36, 16);
            this.chkUse1.TabIndex = 17;
            this.chkUse1.Text = "宇";
            this.chkUse1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(168, 508);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(215, 12);
            this.label18.TabIndex = 6;
            this.label18.Text = "每个人物单独保存,保存前请备份原文件";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(389, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(276, 60);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "未知";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(276, 24);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "地址";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "武器名";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(264, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "MP限制";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Power";
            // 
            // txtUnKnow
            // 
            this.txtUnKnow.Location = new System.Drawing.Point(310, 56);
            this.txtUnKnow.Name = "txtUnKnow";
            this.txtUnKnow.ReadOnly = true;
            this.txtUnKnow.Size = new System.Drawing.Size(144, 21);
            this.txtUnKnow.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(310, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(144, 21);
            this.txtAddress.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(80, 56);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(144, 21);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 20);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(144, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(80, 92);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(144, 21);
            this.txtPower.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "EN";
            // 
            // txtEN
            // 
            this.txtEN.Location = new System.Drawing.Point(80, 128);
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(144, 21);
            this.txtEN.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "射程(无效)";
            // 
            // txtCT
            // 
            this.txtCT.Location = new System.Drawing.Point(310, 236);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(144, 21);
            this.txtCT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "MP";
            // 
            // txtHitCount
            // 
            this.txtHitCount.Location = new System.Drawing.Point(310, 272);
            this.txtHitCount.Name = "txtHitCount";
            this.txtHitCount.Size = new System.Drawing.Size(144, 21);
            this.txtHitCount.TabIndex = 4;
            // 
            // txtMoveAct
            // 
            this.txtMoveAct.Location = new System.Drawing.Point(80, 200);
            this.txtMoveAct.Name = "txtMoveAct";
            this.txtMoveAct.Size = new System.Drawing.Size(144, 21);
            this.txtMoveAct.TabIndex = 4;
            // 
            // txtRange2
            // 
            this.txtRange2.Location = new System.Drawing.Point(398, 164);
            this.txtRange2.Name = "txtRange2";
            this.txtRange2.Size = new System.Drawing.Size(56, 21);
            this.txtRange2.TabIndex = 2;
            // 
            // txtRange1
            // 
            this.txtRange1.Location = new System.Drawing.Point(310, 164);
            this.txtRange1.Name = "txtRange1";
            this.txtRange1.Size = new System.Drawing.Size(56, 21);
            this.txtRange1.TabIndex = 2;
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(80, 164);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(144, 21);
            this.txtMP.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(45, 276);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 2;
            this.label23.Text = "属性";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "命中";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "使用适性";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "武器效果";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "对应适性";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "暴击";
            // 
            // txtHitRate
            // 
            this.txtHitRate.Location = new System.Drawing.Point(310, 200);
            this.txtHitRate.Name = "txtHitRate";
            this.txtHitRate.Size = new System.Drawing.Size(144, 21);
            this.txtHitRate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "移动后攻击";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "HIT数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "图标1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblFile,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(745, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblFile
            // 
            this.tslblFile.Name = "tslblFile";
            this.tslblFile.Size = new System.Drawing.Size(131, 17);
            this.tslblFile.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(466, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel1.Text = "感谢mediar的武器数据";
            // 
            // FrmEditWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lsGundam);
            this.Controls.Add(this.label19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditWeapon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "武器信息修改";
            this.Load += new System.EventHandler(this.FrmEditGundam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lsGundam;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoveAct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblFile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.TextBox txtHitCount;
        private System.Windows.Forms.TextBox txtRange1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHitRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkUse2;
        private System.Windows.Forms.CheckBox chkUse1;
        private System.Windows.Forms.CheckBox chkUse3;
        private System.Windows.Forms.CheckBox chkUse4;
        private System.Windows.Forms.CheckBox chkUse5;
        private System.Windows.Forms.ComboBox cboAE1;
        private System.Windows.Forms.ComboBox cboAE2;
        private System.Windows.Forms.ComboBox cboAE3;
        private System.Windows.Forms.ComboBox cboAE4;
        private System.Windows.Forms.ComboBox cboAE5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cboProp;
        private System.Windows.Forms.ComboBox cboSpec;
        private System.Windows.Forms.ComboBox cboIco;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUnKnow;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtRange2;
        private System.Windows.Forms.ComboBox cboMpLimit;
    }
}