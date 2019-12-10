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
    public partial class FrmSearchWeapon : Form
    {
        private FrmSearchWeapon(string file)
        {
            InitializeComponent();

            this.gundamFile = new GundamFile(file);
        }
        static FrmSearchWeapon form;

        public static FrmSearchWeapon CreateForm(string file)
        {
            if (form == null)
            {
                form = new FrmSearchWeapon(file);
            }
            return form;
        }

        private GundamFile gundamFile;
        private int idx;

        private void search(int index)
        {
            txtAddress.Text = null;

            int power = int.Parse(txtPower.Text);
            short en = short.Parse(txtEn.Text);
            short mp = short.Parse(txtMP.Text);
            byte hitRate = byte.Parse(txtHitRate.Text);
            byte ct = byte.Parse(txtCt.Text);

            WeaponInfo info = new WeaponInfo(gundamFile, 0);
            for (idx = index; idx < gundamFile.Data.Length - 80; idx++)
            {
                info.Index = idx;
                if (info.POWER == power && info.EN == en && info.MP == mp && info.HitRate == hitRate && info.CT == ct)
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
                using (StreamWriter sw = new StreamWriter("武器数据.txt", true, Encoding.UTF8))
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
                MessageBox.Show("请输入武器名称", "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmSearchGundam_FormClosed(object sender, FormClosedEventArgs e)
        {
            form = null;
        }
    }
}
