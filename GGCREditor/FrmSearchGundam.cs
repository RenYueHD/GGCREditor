using GGCREditorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GGCREditor
{
    public partial class FrmSearchGundam : Form
    {
        private FrmSearchGundam(string file)
        {
            InitializeComponent();

            this.gundamFile = new GundamFile(file);
        }
        static FrmSearchGundam form;

        public static FrmSearchGundam CreateForm(string file)
        {
            if (form == null)
            {
                form = new FrmSearchGundam(file);
            }
            return form;
        }

        private GundamFile gundamFile;
        private int idx;

        private void search(int index)
        {
            txtAddress.Text = null;

            short hp = short.Parse(txtHP.Text);
            short en = short.Parse(txtEN.Text);
            short act = short.Parse(txtAct.Text);
            short def = short.Parse(txtDef.Text);
            short spd = short.Parse(txtSpd.Text);
            byte mov = byte.Parse(txtMove.Text);

            GundamInfo info = new GundamInfo(gundamFile, 0);
            for (idx = index; idx < gundamFile.Data.Length - 80; idx++)
            {
                info.Index = idx;
                if (info.HP == hp && info.EN == en && info.ACT == act && info.DEF == def && info.SPD == spd && info.Move == mov)
                {
                    txtAddress.Text = info.Address;
                    btnSave.Enabled = true;
                    txtName.Enabled = true;
                    txtName.Text = "";
                    break;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            idx = 0;
            search(idx);
        }

        private void FrmSearchGundam_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idx++;
            search(idx);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtName.Text != "")
            {
                using (StreamWriter sw = new StreamWriter("机体数据.txt", true, Encoding.UTF8))
                {
                    sw.WriteLine();
                    sw.Write(txtName.Text + ":" + txtAddress.Text.Replace(" ", ""));
                    sw.Flush();
                    btnSave.Enabled = false;
                    txtName.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("请输入机体名称", "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmSearchGundam_FormClosed(object sender, FormClosedEventArgs e)
        {
            form = null;
        }
    }
}
