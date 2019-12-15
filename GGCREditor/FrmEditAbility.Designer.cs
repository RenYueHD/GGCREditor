namespace GGCREditor
{
    partial class FrmEditAbility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditAbility));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lsAbility = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdInGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSkillID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXiaoGuoRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarkId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Location = new System.Drawing.Point(33, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 21);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lsAbility
            // 
            this.lsAbility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsAbility.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lsAbility.FormattingEnabled = true;
            this.lsAbility.ItemHeight = 16;
            this.lsAbility.Location = new System.Drawing.Point(12, 46);
            this.lsAbility.Name = "lsAbility";
            this.lsAbility.Size = new System.Drawing.Size(281, 522);
            this.lsAbility.TabIndex = 9;
            this.lsAbility.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsMasters_DrawItem);
            this.lsAbility.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lsMasters_MeasureItem);
            this.lsAbility.SelectedIndexChanged += new System.EventHandler(this.lsAbility_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 8;
            this.label19.Text = "搜";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(907, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "地址";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(384, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(199, 21);
            this.txtAddress.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "组内序号";
            // 
            // txtIdInGroup
            // 
            this.txtIdInGroup.Location = new System.Drawing.Point(681, 12);
            this.txtIdInGroup.Name = "txtIdInGroup";
            this.txtIdInGroup.ReadOnly = true;
            this.txtIdInGroup.Size = new System.Drawing.Size(199, 21);
            this.txtIdInGroup.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "对应效果编号";
            // 
            // txtSkillID
            // 
            this.txtSkillID.Location = new System.Drawing.Point(384, 41);
            this.txtSkillID.Name = "txtSkillID";
            this.txtSkillID.Size = new System.Drawing.Size(199, 21);
            this.txtSkillID.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "效果说明";
            // 
            // txtXiaoGuoRemark
            // 
            this.txtXiaoGuoRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXiaoGuoRemark.Location = new System.Drawing.Point(299, 387);
            this.txtXiaoGuoRemark.Multiline = true;
            this.txtXiaoGuoRemark.Name = "txtXiaoGuoRemark";
            this.txtXiaoGuoRemark.Size = new System.Drawing.Size(568, 151);
            this.txtXiaoGuoRemark.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "效果说明编号";
            // 
            // txtRemarkId
            // 
            this.txtRemarkId.Location = new System.Drawing.Point(681, 41);
            this.txtRemarkId.Name = "txtRemarkId";
            this.txtRemarkId.Size = new System.Drawing.Size(199, 21);
            this.txtRemarkId.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(168, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "搜索功能支持效果说明";
            // 
            // FrmEditAbility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 597);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdInGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXiaoGuoRemark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRemarkId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSkillID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lsAbility);
            this.Controls.Add(this.label19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditAbility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "能力/技能/OP修改";
            this.Load += new System.EventHandler(this.FrmEditAbility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lsAbility;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdInGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSkillID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXiaoGuoRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarkId;
        private System.Windows.Forms.Label label6;
    }
}