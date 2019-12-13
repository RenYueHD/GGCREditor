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
            filterLs();
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
                txtEdit.Text = txt.Text;
            }
        }

        private void btnEnsure_Click(object sender, EventArgs e)
        {
            IndexText kv = lsMain.SelectedItem as IndexText;
            kv.Text = txtEdit.Text;
            lsMain.DataSource = null;
            lsMain.DataSource = list;
            lsMain.ValueMember = "Index";
            lsMain.DisplayMember = "Text";
          //  filterLs();
            lsMain.SelectedItem = kv;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            foreach (IndexText kv in list)
            {
                data.Add(kv.Text);
            }
            tblFile.Save(data);
            MessageBox.Show("写入成功");
        }

        private void filterLs()
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

        private void txtEdit_TextChanged(object sender, EventArgs e)
        {
            if (txtEdit.Text == null || txtEdit.Text.Length == 0)
            {
                btnEnsure.Enabled = true;
            }
        }
    }
}
