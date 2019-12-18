using GGCREditorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GGCREditor
{
    public partial class FrmEditText : Form
    {
        GGCRTblFile tblFile;


        public FrmEditText(string file)
        {
            InitializeComponent();
            this.tblFile = new GGCRTblFile(file);
            tsmiFile.Text = tblFile.FileName;
        }

        List<IndexText> list;

        private void FrmEditText_Load(object sender, EventArgs e)
        {
            list = new List<IndexText>();

            List<string> data = tblFile.ListAllText();
            for (int i = 0; i < data.Count; i++)
            {
                list.Add(new IndexText() { Index = i, Text = data[i] });
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = list;

            lsMain.DataSource = bs;
            lsMain.ValueMember = "Index";
            lsMain.DisplayMember = "Text";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtEdit.Text = null;
            if (txtSearch.Text == null || txtSearch.Text.Length == 0)
            {
                lsMain.DataSource = list;
            }
            else
            {
                List<IndexText> search = new List<IndexText>();
                foreach (IndexText kv in list)
                {
                    if (kv.Text.Contains(txtSearch.Text))
                    {
                        search.Add(kv);
                    }
                }
                lsMain.DataSource = search;
            }
        }

        private void lsMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexText txt = lsMain.SelectedItem as IndexText;
            if (txt == null)
            {
                txtEdit.Enabled = false;
                btnEnsure.Enabled = false;
            }
            else
            {
                txtEdit.Enabled = true;
                btnEnsure.Enabled = true;
                txtEdit.Text = txt.Text.Replace("\n", "\r\n");
            }
            tsmiState.Text = "等待修改";
            tsmiState.ForeColor = Color.Black;
        }

        private void btnEnsure_Click(object sender, EventArgs e)
        {
            IndexText kv = lsMain.SelectedItem as IndexText;
            kv.Text = txtEdit.Text.Replace("\r\n", "\n");

            btnSave.Enabled = true;

            lsMain.Refresh();

            tsmiState.Text = "修改成功,等待写入";
            tsmiState.ForeColor = Color.Blue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            foreach (IndexText kv in list)
            {
                data.Add(kv.Text);
            }
            tblFile.Save(data);

            tsmiState.Text = "写入成功";
            tsmiState.ForeColor = Color.Green;
        }

        private void txtEdit_TextChanged(object sender, EventArgs e)
        {
            if (txtEdit.Text == null || txtEdit.Text.Length == 0)
            {
                btnEnsure.Enabled = true;
            }
        }

        private void lsMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                IndexText master = ((ListBox)sender).Items[e.Index] as IndexText;
                e.Graphics.DrawString(master.Index.ToString(), e.Font, new SolidBrush(Color.Red), e.Bounds);
                e.Graphics.DrawString(master.Text.Replace('\n', ' '), e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + 32, e.Bounds.Top);
            }
        }
    }
}
