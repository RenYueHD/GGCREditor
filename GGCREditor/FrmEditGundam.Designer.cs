﻿namespace GGCREditor
{
    partial class FrmEditGundam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditGundam));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lsGundam = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditWeapon = new System.Windows.Forms.Button();
            this.cboSkill5 = new System.Windows.Forms.ComboBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboSkill4 = new System.Windows.Forms.ComboBox();
            this.cboSkill3 = new System.Windows.Forms.ComboBox();
            this.cboSkill2 = new System.Windows.Forms.ComboBox();
            this.cboSkill1 = new System.Windows.Forms.ComboBox();
            this.cboE5 = new System.Windows.Forms.ComboBox();
            this.cboE4 = new System.Windows.Forms.ComboBox();
            this.cboE3 = new System.Windows.Forms.ComboBox();
            this.cboE2 = new System.Windows.Forms.ComboBox();
            this.cboE1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeaponCount = new System.Windows.Forms.TextBox();
            this.txtWeapon1ID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpd = new System.Windows.Forms.TextBox();
            this.txtEarthSize = new System.Windows.Forms.TextBox();
            this.txtMove = new System.Windows.Forms.TextBox();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label24 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(33, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 21);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lsGundam
            // 
            this.lsGundam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsGundam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lsGundam.FormattingEnabled = true;
            this.lsGundam.ItemHeight = 16;
            this.lsGundam.Location = new System.Drawing.Point(12, 33);
            this.lsGundam.Name = "lsGundam";
            this.lsGundam.Size = new System.Drawing.Size(301, 521);
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtGroup);
            this.groupBox1.Controls.Add(this.btnEditWeapon);
            this.groupBox1.Controls.Add(this.cboSkill5);
            this.groupBox1.Controls.Add(this.cboSize);
            this.groupBox1.Controls.Add(this.cboSkill4);
            this.groupBox1.Controls.Add(this.cboSkill3);
            this.groupBox1.Controls.Add(this.cboSkill2);
            this.groupBox1.Controls.Add(this.cboSkill1);
            this.groupBox1.Controls.Add(this.cboE5);
            this.groupBox1.Controls.Add(this.cboE4);
            this.groupBox1.Controls.Add(this.cboE3);
            this.groupBox1.Controls.Add(this.cboE2);
            this.groupBox1.Controls.Add(this.cboE1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWeaponCount);
            this.groupBox1.Controls.Add(this.txtWeapon1ID);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtHP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSpd);
            this.groupBox1.Controls.Add(this.txtEarthSize);
            this.groupBox1.Controls.Add(this.txtMove);
            this.groupBox1.Controls.Add(this.txtAct);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDef);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(319, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 545);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "属性";
            // 
            // btnEditWeapon
            // 
            this.btnEditWeapon.Location = new System.Drawing.Point(10, 429);
            this.btnEditWeapon.Name = "btnEditWeapon";
            this.btnEditWeapon.Size = new System.Drawing.Size(443, 35);
            this.btnEditWeapon.TabIndex = 20;
            this.btnEditWeapon.Text = "拥有武器修改";
            this.btnEditWeapon.UseVisualStyleBackColor = true;
            this.btnEditWeapon.Click += new System.EventHandler(this.btnEditWeapon_Click);
            // 
            // cboSkill5
            // 
            this.cboSkill5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill5.FormattingEnabled = true;
            this.cboSkill5.Location = new System.Drawing.Point(309, 352);
            this.cboSkill5.Name = "cboSkill5";
            this.cboSkill5.Size = new System.Drawing.Size(144, 20);
            this.cboSkill5.TabIndex = 19;
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(78, 315);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(144, 20);
            this.cboSize.TabIndex = 19;
            // 
            // cboSkill4
            // 
            this.cboSkill4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill4.FormattingEnabled = true;
            this.cboSkill4.Location = new System.Drawing.Point(309, 315);
            this.cboSkill4.Name = "cboSkill4";
            this.cboSkill4.Size = new System.Drawing.Size(144, 20);
            this.cboSkill4.TabIndex = 19;
            // 
            // cboSkill3
            // 
            this.cboSkill3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill3.FormattingEnabled = true;
            this.cboSkill3.Location = new System.Drawing.Point(309, 278);
            this.cboSkill3.Name = "cboSkill3";
            this.cboSkill3.Size = new System.Drawing.Size(144, 20);
            this.cboSkill3.TabIndex = 19;
            // 
            // cboSkill2
            // 
            this.cboSkill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill2.FormattingEnabled = true;
            this.cboSkill2.Location = new System.Drawing.Point(309, 241);
            this.cboSkill2.Name = "cboSkill2";
            this.cboSkill2.Size = new System.Drawing.Size(144, 20);
            this.cboSkill2.TabIndex = 19;
            // 
            // cboSkill1
            // 
            this.cboSkill1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill1.FormattingEnabled = true;
            this.cboSkill1.Location = new System.Drawing.Point(309, 204);
            this.cboSkill1.Name = "cboSkill1";
            this.cboSkill1.Size = new System.Drawing.Size(144, 20);
            this.cboSkill1.TabIndex = 19;
            // 
            // cboE5
            // 
            this.cboE5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboE5.FormattingEnabled = true;
            this.cboE5.Location = new System.Drawing.Point(309, 93);
            this.cboE5.Name = "cboE5";
            this.cboE5.Size = new System.Drawing.Size(51, 20);
            this.cboE5.TabIndex = 19;
            // 
            // cboE4
            // 
            this.cboE4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboE4.FormattingEnabled = true;
            this.cboE4.Location = new System.Drawing.Point(402, 93);
            this.cboE4.Name = "cboE4";
            this.cboE4.Size = new System.Drawing.Size(51, 20);
            this.cboE4.TabIndex = 19;
            // 
            // cboE3
            // 
            this.cboE3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboE3.FormattingEnabled = true;
            this.cboE3.Location = new System.Drawing.Point(309, 130);
            this.cboE3.Name = "cboE3";
            this.cboE3.Size = new System.Drawing.Size(51, 20);
            this.cboE3.TabIndex = 19;
            // 
            // cboE2
            // 
            this.cboE2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboE2.FormattingEnabled = true;
            this.cboE2.Location = new System.Drawing.Point(402, 130);
            this.cboE2.Name = "cboE2";
            this.cboE2.Size = new System.Drawing.Size(51, 20);
            this.cboE2.TabIndex = 19;
            // 
            // cboE1
            // 
            this.cboE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboE1.FormattingEnabled = true;
            this.cboE1.Location = new System.Drawing.Point(309, 167);
            this.cboE1.Name = "cboE1";
            this.cboE1.Size = new System.Drawing.Size(51, 20);
            this.cboE1.TabIndex = 19;
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
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(250, 393);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 2;
            this.label23.Text = "武器数量";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(275, 23);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "地址";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 393);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 2;
            this.label22.Text = "第一武器ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "机体名";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "宇宙";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "空中";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "地上";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "水上";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "水中";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "HP";
            // 
            // txtWeaponCount
            // 
            this.txtWeaponCount.Location = new System.Drawing.Point(309, 389);
            this.txtWeaponCount.Name = "txtWeaponCount";
            this.txtWeaponCount.ReadOnly = true;
            this.txtWeaponCount.Size = new System.Drawing.Size(144, 21);
            this.txtWeaponCount.TabIndex = 3;
            // 
            // txtWeapon1ID
            // 
            this.txtWeapon1ID.Location = new System.Drawing.Point(78, 389);
            this.txtWeapon1ID.Name = "txtWeapon1ID";
            this.txtWeapon1ID.ReadOnly = true;
            this.txtWeapon1ID.Size = new System.Drawing.Size(144, 21);
            this.txtWeapon1ID.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(309, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(144, 21);
            this.txtAddress.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 20);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(144, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(78, 93);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(144, 21);
            this.txtHP.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "EN";
            // 
            // txtEN
            // 
            this.txtEN.Location = new System.Drawing.Point(78, 130);
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(144, 21);
            this.txtEN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "攻击";
            // 
            // txtSpd
            // 
            this.txtSpd.Location = new System.Drawing.Point(78, 241);
            this.txtSpd.Name = "txtSpd";
            this.txtSpd.Size = new System.Drawing.Size(144, 21);
            this.txtSpd.TabIndex = 4;
            // 
            // txtEarthSize
            // 
            this.txtEarthSize.Location = new System.Drawing.Point(78, 352);
            this.txtEarthSize.Name = "txtEarthSize";
            this.txtEarthSize.Size = new System.Drawing.Size(144, 21);
            this.txtEarthSize.TabIndex = 4;
            // 
            // txtMove
            // 
            this.txtMove.Location = new System.Drawing.Point(78, 278);
            this.txtMove.Name = "txtMove";
            this.txtMove.Size = new System.Drawing.Size(144, 21);
            this.txtMove.TabIndex = 4;
            // 
            // txtAct
            // 
            this.txtAct.Location = new System.Drawing.Point(78, 167);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(144, 21);
            this.txtAct.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(268, 356);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "能力5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(268, 319);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "能力4";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(268, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "能力3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(268, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "能力2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(268, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "能力1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "占地图面积";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "防御";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "SIZE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "机动力";
            // 
            // txtDef
            // 
            this.txtDef.Location = new System.Drawing.Point(78, 204);
            this.txtDef.Name = "txtDef";
            this.txtDef.Size = new System.Drawing.Size(144, 21);
            this.txtDef.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "移动";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblFile,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(796, 22);
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
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(510, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(140, 17);
            this.toolStripStatusLabel1.Text = "感谢lxdlxd99的机体数据";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(44, 60);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 21;
            this.label24.Text = "系列";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(78, 56);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.ReadOnly = true;
            this.txtGroup.Size = new System.Drawing.Size(144, 21);
            this.txtGroup.TabIndex = 22;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(309, 56);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(144, 21);
            this.txtId.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(287, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 12);
            this.label25.TabIndex = 21;
            this.label25.Text = "ID";
            // 
            // FrmEditGundam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 579);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lsGundam);
            this.Controls.Add(this.label19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditGundam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "机体信息修改";
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
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMove;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboE5;
        private System.Windows.Forms.ComboBox cboE4;
        private System.Windows.Forms.ComboBox cboE3;
        private System.Windows.Forms.ComboBox cboE2;
        private System.Windows.Forms.ComboBox cboE1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboSkill5;
        private System.Windows.Forms.ComboBox cboSkill4;
        private System.Windows.Forms.ComboBox cboSkill3;
        private System.Windows.Forms.ComboBox cboSkill2;
        private System.Windows.Forms.ComboBox cboSkill1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblFile;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEarthSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtWeaponCount;
        private System.Windows.Forms.TextBox txtWeapon1ID;
        private System.Windows.Forms.Button btnEditWeapon;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtId;
    }
}