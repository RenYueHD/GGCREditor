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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchWeapon = new System.Windows.Forms.Button();
            this.btnEditWeapon = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblDir = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 25);
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
            this.btnEditMaster.Enabled = false;
            this.btnEditMaster.Location = new System.Drawing.Point(12, 28);
            this.btnEditMaster.Name = "btnEditMaster";
            this.btnEditMaster.Size = new System.Drawing.Size(77, 54);
            this.btnEditMaster.TabIndex = 1;
            this.btnEditMaster.Text = "修改角色";
            this.btnEditMaster.UseVisualStyleBackColor = true;
            this.btnEditMaster.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnEditGundam
            // 
            this.btnEditGundam.Enabled = false;
            this.btnEditGundam.Location = new System.Drawing.Point(95, 28);
            this.btnEditGundam.Name = "btnEditGundam";
            this.btnEditGundam.Size = new System.Drawing.Size(92, 54);
            this.btnEditGundam.TabIndex = 2;
            this.btnEditGundam.Text = "修改机体/战舰";
            this.btnEditGundam.UseVisualStyleBackColor = true;
            this.btnEditGundam.Click += new System.EventHandler(this.btnEditGundam_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(276, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 54);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "机体/战舰搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchWeapon
            // 
            this.btnSearchWeapon.Enabled = false;
            this.btnSearchWeapon.Location = new System.Drawing.Point(374, 28);
            this.btnSearchWeapon.Name = "btnSearchWeapon";
            this.btnSearchWeapon.Size = new System.Drawing.Size(77, 54);
            this.btnSearchWeapon.TabIndex = 5;
            this.btnSearchWeapon.Text = "武器搜索";
            this.btnSearchWeapon.UseVisualStyleBackColor = true;
            this.btnSearchWeapon.Click += new System.EventHandler(this.btnSearchWeapon_Click);
            // 
            // btnEditWeapon
            // 
            this.btnEditWeapon.Enabled = false;
            this.btnEditWeapon.Location = new System.Drawing.Point(193, 28);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 120);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(460, 22);
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "感谢: 泷泽透明 lxdlxd99 gundamdxhk hgjzorro hj mediar";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSearchWeapon);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEditWeapon);
            this.Controls.Add(this.btnEditGundam);
            this.Controls.Add(this.btnEditMaster);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "火线纵横-静态修改器 v1.01beta - Power By RenYueHD";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择路径ToolStripMenuItem;
        private System.Windows.Forms.Button btnEditMaster;
        private System.Windows.Forms.Button btnEditGundam;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchWeapon;
        private System.Windows.Forms.Button btnEditWeapon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblDir;
        private System.Windows.Forms.Label label1;
    }
}

