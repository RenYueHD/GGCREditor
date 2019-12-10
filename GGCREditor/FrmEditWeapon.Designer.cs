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
            this.label18 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMpLimit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.txtUseEarth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIco2 = new System.Windows.Forms.TextBox();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHitCount = new System.Windows.Forms.TextBox();
            this.txtMoveAct = new System.Windows.Forms.TextBox();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.txtIco1 = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHitRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtActEarth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblFile = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtMpLimit);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtPower);
            this.groupBox1.Controls.Add(this.txtUseEarth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEN);
            this.groupBox1.Controls.Add(this.txtSpec);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtIco2);
            this.groupBox1.Controls.Add(this.txtCT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHitCount);
            this.groupBox1.Controls.Add(this.txtMoveAct);
            this.groupBox1.Controls.Add(this.txtRange);
            this.groupBox1.Controls.Add(this.txtIco1);
            this.groupBox1.Controls.Add(this.txtMP);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtHitRate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtActEarth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(266, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 532);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "属性";
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
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(275, 23);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "地址";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "武器名";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(263, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "MP限制";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Power";
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
            // txtMpLimit
            // 
            this.txtMpLimit.Location = new System.Drawing.Point(309, 58);
            this.txtMpLimit.Name = "txtMpLimit";
            this.txtMpLimit.Size = new System.Drawing.Size(144, 21);
            this.txtMpLimit.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(251, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "使用适性";
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(78, 58);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(144, 21);
            this.txtPower.TabIndex = 0;
            // 
            // txtUseEarth
            // 
            this.txtUseEarth.Location = new System.Drawing.Point(309, 95);
            this.txtUseEarth.Name = "txtUseEarth";
            this.txtUseEarth.Size = new System.Drawing.Size(144, 21);
            this.txtUseEarth.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "EN";
            // 
            // txtEN
            // 
            this.txtEN.Location = new System.Drawing.Point(78, 95);
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(144, 21);
            this.txtEN.TabIndex = 1;
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(78, 317);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(144, 21);
            this.txtSpec.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(233, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "射程(无效?)";
            // 
            // txtIco2
            // 
            this.txtIco2.Location = new System.Drawing.Point(78, 280);
            this.txtIco2.Name = "txtIco2";
            this.txtIco2.Size = new System.Drawing.Size(144, 21);
            this.txtIco2.TabIndex = 5;
            // 
            // txtCT
            // 
            this.txtCT.Location = new System.Drawing.Point(309, 206);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(144, 21);
            this.txtCT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "MP";
            // 
            // txtHitCount
            // 
            this.txtHitCount.Location = new System.Drawing.Point(309, 243);
            this.txtHitCount.Name = "txtHitCount";
            this.txtHitCount.Size = new System.Drawing.Size(144, 21);
            this.txtHitCount.TabIndex = 4;
            // 
            // txtMoveAct
            // 
            this.txtMoveAct.Location = new System.Drawing.Point(78, 206);
            this.txtMoveAct.Name = "txtMoveAct";
            this.txtMoveAct.Size = new System.Drawing.Size(144, 21);
            this.txtMoveAct.TabIndex = 4;
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(309, 132);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(144, 21);
            this.txtRange.TabIndex = 2;
            // 
            // txtIco1
            // 
            this.txtIco1.Location = new System.Drawing.Point(78, 243);
            this.txtIco1.Name = "txtIco1";
            this.txtIco1.Size = new System.Drawing.Size(144, 21);
            this.txtIco1.TabIndex = 4;
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(78, 132);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(144, 21);
            this.txtMP.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "命中";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "武器效果";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "适性";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "暴击";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "图标2";
            // 
            // txtHitRate
            // 
            this.txtHitRate.Location = new System.Drawing.Point(309, 169);
            this.txtHitRate.Name = "txtHitRate";
            this.txtHitRate.Size = new System.Drawing.Size(144, 21);
            this.txtHitRate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "移动后攻击";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "HIT数";
            // 
            // txtActEarth
            // 
            this.txtActEarth.Location = new System.Drawing.Point(78, 169);
            this.txtActEarth.Name = "txtActEarth";
            this.txtActEarth.Size = new System.Drawing.Size(144, 21);
            this.txtActEarth.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "图标1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblFile});
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
        private System.Windows.Forms.TextBox txtIco2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIco1;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtActEarth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoveAct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblFile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMpLimit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUseEarth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.TextBox txtHitCount;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHitRate;
        private System.Windows.Forms.Label label8;
    }
}