namespace GGCREditor
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditMaster = new System.Windows.Forms.Button();
            this.btnEditGundam = new System.Windows.Forms.Button();
            this.btnEditWeapon = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblDir = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditText = new System.Windows.Forms.Button();
            this.btnEditMachineTxt = new System.Windows.Forms.Button();
            this.btnEditMachineDesc = new System.Windows.Forms.Button();
            this.btnEditAbility = new System.Windows.Forms.Button();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.flowContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择路径ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 选择路径ToolStripMenuItem
            // 
            this.选择路径ToolStripMenuItem.Name = "选择路径ToolStripMenuItem";
            this.选择路径ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.选择路径ToolStripMenuItem.Text = "设置data文件夹路径";
            this.选择路径ToolStripMenuItem.Click += new System.EventHandler(this.选择路径ToolStripMenuItem_Click);
            // 
            // btnEditMaster
            // 
            this.btnEditMaster.Location = new System.Drawing.Point(3, 3);
            this.btnEditMaster.Name = "btnEditMaster";
            this.btnEditMaster.Size = new System.Drawing.Size(77, 54);
            this.btnEditMaster.TabIndex = 1;
            this.btnEditMaster.Text = "修改角色";
            this.btnEditMaster.UseVisualStyleBackColor = true;
            this.btnEditMaster.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnEditGundam
            // 
            this.btnEditGundam.Location = new System.Drawing.Point(86, 3);
            this.btnEditGundam.Name = "btnEditGundam";
            this.btnEditGundam.Size = new System.Drawing.Size(77, 54);
            this.btnEditGundam.TabIndex = 2;
            this.btnEditGundam.Text = "修改机体/战舰";
            this.btnEditGundam.UseVisualStyleBackColor = true;
            this.btnEditGundam.Click += new System.EventHandler(this.btnEditGundam_Click);
            // 
            // btnEditWeapon
            // 
            this.btnEditWeapon.Location = new System.Drawing.Point(169, 3);
            this.btnEditWeapon.Name = "btnEditWeapon";
            this.btnEditWeapon.Size = new System.Drawing.Size(77, 54);
            this.btnEditWeapon.TabIndex = 3;
            this.btnEditWeapon.Text = "修改武器";
            this.btnEditWeapon.UseVisualStyleBackColor = true;
            this.btnEditWeapon.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblDir});
            this.statusStrip1.Location = new System.Drawing.Point(0, 122);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(690, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblDir
            // 
            this.tslblDir.Name = "tslblDir";
            this.tslblDir.Size = new System.Drawing.Size(188, 17);
            this.tslblDir.Text = "请点击-文件-设置data文件夹路径";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "感谢: 泷泽透明 lxdlxd99 gundamdxhk hgjzorro hj mediar";
            // 
            // btnEditText
            // 
            this.btnEditText.Location = new System.Drawing.Point(252, 3);
            this.btnEditText.Name = "btnEditText";
            this.btnEditText.Size = new System.Drawing.Size(77, 54);
            this.btnEditText.TabIndex = 3;
            this.btnEditText.Text = "修改角色相关文本";
            this.btnEditText.UseVisualStyleBackColor = true;
            this.btnEditText.Click += new System.EventHandler(this.btnEditText_Click);
            // 
            // btnEditMachineTxt
            // 
            this.btnEditMachineTxt.Location = new System.Drawing.Point(335, 3);
            this.btnEditMachineTxt.Name = "btnEditMachineTxt";
            this.btnEditMachineTxt.Size = new System.Drawing.Size(77, 54);
            this.btnEditMachineTxt.TabIndex = 3;
            this.btnEditMachineTxt.Text = "修改机体/武器文本";
            this.btnEditMachineTxt.UseVisualStyleBackColor = true;
            this.btnEditMachineTxt.Click += new System.EventHandler(this.btnEditMachineTxt_Click);
            // 
            // btnEditMachineDesc
            // 
            this.btnEditMachineDesc.Location = new System.Drawing.Point(418, 3);
            this.btnEditMachineDesc.Name = "btnEditMachineDesc";
            this.btnEditMachineDesc.Size = new System.Drawing.Size(77, 54);
            this.btnEditMachineDesc.TabIndex = 3;
            this.btnEditMachineDesc.Text = "修改角色/机体描述";
            this.btnEditMachineDesc.UseVisualStyleBackColor = true;
            this.btnEditMachineDesc.Click += new System.EventHandler(this.btnEditMachineDesc_Click);
            // 
            // btnEditAbility
            // 
            this.btnEditAbility.Location = new System.Drawing.Point(501, 3);
            this.btnEditAbility.Name = "btnEditAbility";
            this.btnEditAbility.Size = new System.Drawing.Size(77, 54);
            this.btnEditAbility.TabIndex = 3;
            this.btnEditAbility.Text = "修改技能相关文本";
            this.btnEditAbility.UseVisualStyleBackColor = true;
            this.btnEditAbility.Click += new System.EventHandler(this.btnEditAbility_Click);
            // 
            // flowContainer
            // 
            this.flowContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowContainer.Controls.Add(this.btnEditMaster);
            this.flowContainer.Controls.Add(this.btnEditGundam);
            this.flowContainer.Controls.Add(this.btnEditWeapon);
            this.flowContainer.Controls.Add(this.btnEditText);
            this.flowContainer.Controls.Add(this.btnEditMachineTxt);
            this.flowContainer.Controls.Add(this.btnEditMachineDesc);
            this.flowContainer.Controls.Add(this.btnEditAbility);
            this.flowContainer.Controls.Add(this.button1);
            this.flowContainer.Enabled = false;
            this.flowContainer.Location = new System.Drawing.Point(12, 28);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(667, 64);
            this.flowContainer.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "修改其他TBL文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 144);
            this.Controls.Add(this.flowContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "火线纵横-静态修改器 v1.2 - Power By RenYueHD";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择路径ToolStripMenuItem;
        private System.Windows.Forms.Button btnEditMaster;
        private System.Windows.Forms.Button btnEditGundam;
        private System.Windows.Forms.Button btnEditWeapon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditText;
        private System.Windows.Forms.Button btnEditMachineTxt;
        private System.Windows.Forms.Button btnEditMachineDesc;
        private System.Windows.Forms.Button btnEditAbility;
        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private System.Windows.Forms.Button button1;
    }
}

