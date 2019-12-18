namespace GGCREditor
{
    partial class FrmEditText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditText));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.btnEnsure = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmiState = new System.Windows.Forms.ToolStripStatusLabel();
            this.lsMain = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(35, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(806, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(847, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "复位";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "搜";
            // 
            // txtEdit
            // 
            this.txtEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdit.Enabled = false;
            this.txtEdit.Location = new System.Drawing.Point(3, 3);
            this.txtEdit.Multiline = true;
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEdit.Size = new System.Drawing.Size(817, 138);
            this.txtEdit.TabIndex = 4;
            this.txtEdit.TextChanged += new System.EventHandler(this.txtEdit_TextChanged);
            // 
            // btnEnsure
            // 
            this.btnEnsure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnsure.Enabled = false;
            this.btnEnsure.Location = new System.Drawing.Point(823, 3);
            this.btnEnsure.Name = "btnEnsure";
            this.btnEnsure.Size = new System.Drawing.Size(86, 91);
            this.btnEnsure.TabIndex = 5;
            this.btnEnsure.Text = "确定";
            this.btnEnsure.UseVisualStyleBackColor = true;
            this.btnEnsure.Click += new System.EventHandler(this.btnEnsure_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(823, 95);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "写入文件";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(936, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(131, 17);
            this.tsmiFile.Text = "toolStripStatusLabel1";
            // 
            // tsmiState
            // 
            this.tsmiState.Name = "tsmiState";
            this.tsmiState.Size = new System.Drawing.Size(790, 17);
            this.tsmiState.Spring = true;
            this.tsmiState.Text = "toolStripStatusLabel1";
            this.tsmiState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lsMain
            // 
            this.lsMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsMain.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lsMain.ItemHeight = 12;
            this.lsMain.Location = new System.Drawing.Point(0, 0);
            this.lsMain.Name = "lsMain";
            this.lsMain.ScrollAlwaysVisible = true;
            this.lsMain.Size = new System.Drawing.Size(912, 340);
            this.lsMain.TabIndex = 0;
            this.lsMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsMain_DrawItem);
            this.lsMain.SelectedIndexChanged += new System.EventHandler(this.lsMain_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.lsMain);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 487);
            this.panel1.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 340);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(912, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEdit);
            this.panel2.Controls.Add(this.btnEnsure);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 144);
            this.panel2.TabIndex = 2;
            // 
            // FrmEditText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文本修改";
            this.Load += new System.EventHandler(this.FrmEditText_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btnEnsure;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsmiFile;
        private System.Windows.Forms.ToolStripStatusLabel tsmiState;
        private System.Windows.Forms.ListBox lsMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
    }
}