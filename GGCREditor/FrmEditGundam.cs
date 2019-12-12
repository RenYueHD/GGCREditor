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
    public partial class FrmEditGundam : Form
    {
        public FrmEditGundam()
        {
            InitializeComponent();
            this.gundamFile = new GundamFile();
            tslblFile.Text = gundamFile.FileName;
        }

        private GundamFile gundamFile;
        private List<GundamInfo> gundams = new List<GundamInfo>();
        private List<KeyValuePair<string, string>> skill1 = new List<KeyValuePair<string, string>>();
        private List<KeyValuePair<string, string>> skill2 = new List<KeyValuePair<string, string>>();
        private List<KeyValuePair<string, string>> skill3 = new List<KeyValuePair<string, string>>();
        private List<KeyValuePair<string, string>> skill4 = new List<KeyValuePair<string, string>>();
        private List<KeyValuePair<string, string>> skill5 = new List<KeyValuePair<string, string>>();
        private List<KeyValuePair<string, string>> size = new List<KeyValuePair<string, string>>();

        private void FrmEditGundam_Load(object sender, EventArgs e)
        {
            e1 = buildEarth();
            e2 = buildEarth();
            e3 = buildEarth();
            e4 = buildEarth();
            e5 = buildEarth();
            size = buildSize();

            cboE1.DataSource = e1;
            cboE1.DisplayMember = "Value";
            cboE1.ValueMember = "Key";
            cboE2.DataSource = e2;
            cboE2.DisplayMember = "Value";
            cboE2.ValueMember = "Key";
            cboE3.DataSource = e3;
            cboE3.DisplayMember = "Value";
            cboE3.ValueMember = "Key";
            cboE4.DataSource = e4;
            cboE4.DisplayMember = "Value";
            cboE4.ValueMember = "Key";
            cboE5.DataSource = e5;
            cboE5.DisplayMember = "Value";
            cboE5.ValueMember = "Key";

            cboSize.DataSource = size;
            cboSize.DisplayMember = "Value";
            cboSize.ValueMember = "Key";

            using (StreamReader sr = new StreamReader("机体能力.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> info = new KeyValuePair<string, string>(arr[0], arr[1]);
                        skill1.Add(info);
                        skill2.Add(info);
                        skill3.Add(info);
                        skill4.Add(info);
                        skill5.Add(info);
                    }
                }
            }

            cboSkill1.DataSource = skill1;
            cboSkill2.DataSource = skill2;
            cboSkill3.DataSource = skill3;
            cboSkill4.DataSource = skill4;
            cboSkill5.DataSource = skill5;

            cboSkill1.DisplayMember = "Value";
            cboSkill2.DisplayMember = "Value";
            cboSkill3.DisplayMember = "Value";
            cboSkill4.DisplayMember = "Value";
            cboSkill5.DisplayMember = "Value";

            cboSkill1.ValueMember = "Key";
            cboSkill2.ValueMember = "Key";
            cboSkill3.ValueMember = "Key";
            cboSkill4.ValueMember = "Key";
            cboSkill5.ValueMember = "Key";


            gundams = gundamFile.ListMachines();

            lsGundam.DataSource = gundams;
            lsGundam.DisplayMember = "GundamName";
            lsGundam.ValueMember = "Address";
        }

        private List<KeyValuePair<string, string>> buildSize()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("1", "S"));
            list.Add(new KeyValuePair<string, string>("2", "M"));
            list.Add(new KeyValuePair<string, string>("3", "L"));
            list.Add(new KeyValuePair<string, string>("5", "XL"));
            list.Add(new KeyValuePair<string, string>("6", "XXL"));
            return list;
        }

        private List<KeyValuePair<string, string>> buildEarth()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("0", "-"));
            list.Add(new KeyValuePair<string, string>("1", "D"));
            list.Add(new KeyValuePair<string, string>("2", "C"));
            list.Add(new KeyValuePair<string, string>("3", "B"));
            list.Add(new KeyValuePair<string, string>("4", "A"));
            list.Add(new KeyValuePair<string, string>("5", "S"));
            return list;
        }

        private List<KeyValuePair<string, string>> e1;
        private List<KeyValuePair<string, string>> e2;
        private List<KeyValuePair<string, string>> e3;
        private List<KeyValuePair<string, string>> e4;
        private List<KeyValuePair<string, string>> e5;

        private void LoadData(GundamInfo gundam)
        {
            if (gundam != null)
            {
                txtGroup.Text = gundam.GroupName;
                txtId.Text = gundam.ID.ToString();
                txtName.Text = gundam.GundamName;
                txtAddress.Text = ByteHelper.ByteArrayToHexString(ByteHelper.Int2Bytes(gundam.Index));
                txtHP.Text = gundam.HP.ToString();
                txtEN.Text = gundam.EN.ToString();
                txtAct.Text = gundam.ACT.ToString();
                txtDef.Text = gundam.DEF.ToString();
                txtSpd.Text = gundam.SPD.ToString();
                txtMove.Text = gundam.Move.ToString();
                txtEarthSize.Text = gundam.EarchSize.ToString();
                cboSize.SelectedValue = gundam.Size.ToString();

                txtWeapon1ID.Text = gundam.WeaponId.ToString();
                txtWeaponCount.Text = gundam.WeaponCount.ToString();


                string shiyin = gundam.Earch;

                cboE1.SelectedValue = shiyin[0].ToString();
                cboE2.SelectedValue = shiyin[1].ToString();
                cboE3.SelectedValue = shiyin[2].ToString();
                cboE4.SelectedValue = shiyin[3].ToString();
                cboE5.SelectedValue = shiyin[4].ToString();

                cboSkill1.SelectedValue = gundam.Skill1.ToString();
                cboSkill2.SelectedValue = gundam.Skill2.ToString();
                cboSkill3.SelectedValue = gundam.Skill3.ToString();
                cboSkill4.SelectedValue = gundam.Skill4.ToString();
                cboSkill5.SelectedValue = gundam.Skill5.ToString();


                btnSave.Enabled = true;
            }
            else
            {
                txtId.Text = null;
                txtGroup.Text = null;
                txtName.Text = null;
                txtAddress.Text = null;
                txtHP.Text = null;
                txtEN.Text = null;
                txtAct.Text = null;
                txtDef.Text = null;
                txtSpd.Text = null;
                txtMove.Text = null;
                txtEarthSize.Text = null;
                cboSize.SelectedValue = "1";

                cboE1.SelectedValue = "-1";
                cboE2.SelectedValue = "-1";
                cboE3.SelectedValue = "-1";
                cboE4.SelectedValue = "-1";
                cboE5.SelectedValue = "-1";

                cboSkill1.SelectedValue = "-1";
                cboSkill2.SelectedValue = "-1";
                cboSkill3.SelectedValue = "-1";
                cboSkill4.SelectedValue = "-1";
                cboSkill5.SelectedValue = "-1";

                txtWeapon1ID.Text = null;
                txtWeaponCount.Text = null;

                btnSave.Enabled = false;
            }
        }

        private void lsGundam_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = e.ItemHeight + 6;
        }

        private void lsGundam_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            if (e.Index >= 0)
            {
                GundamInfo master = ((ListBox)sender).Items[e.Index] as GundamInfo;
                StringFormat sStringFormat = new StringFormat();
                sStringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(master.GroupName + "-" + master.GundamName, e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
            }
            e.DrawFocusRectangle();
        }

        private void lsGundam_SelectedIndexChanged(object sender, EventArgs e)
        {
            GundamInfo master = lsGundam.SelectedItem as GundamInfo;
            if (master != null)
            {
                LoadData(master);
            }
            else
            {
                LoadData(null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GundamInfo gundam = lsGundam.SelectedItem as GundamInfo;
            if (gundam != null)
            {
                btnSave.Enabled = false;

                gundam.HP = short.Parse(txtHP.Text);
                gundam.EN = short.Parse(txtEN.Text);
                gundam.ACT = short.Parse(txtAct.Text);
                gundam.DEF = short.Parse(txtDef.Text);
                gundam.SPD = short.Parse(txtSpd.Text);
                gundam.Move = byte.Parse(txtMove.Text);
                gundam.Size = byte.Parse(cboSize.SelectedValue.ToString());
                gundam.EarchSize = short.Parse(txtEarthSize.Text);

                gundam.Skill1 = short.Parse(cboSkill1.SelectedValue.ToString());
                gundam.Skill2 = short.Parse(cboSkill2.SelectedValue.ToString());
                gundam.Skill3 = short.Parse(cboSkill3.SelectedValue.ToString());
                gundam.Skill4 = short.Parse(cboSkill4.SelectedValue.ToString());
                gundam.Skill5 = short.Parse(cboSkill5.SelectedValue.ToString());

                string shiyin = cboE1.SelectedValue.ToString() + cboE2.SelectedValue.ToString() + cboE3.SelectedValue.ToString() + cboE4.SelectedValue.ToString() + cboE5.SelectedValue.ToString();

                gundam.Earch = shiyin;

                gundamFile.Save();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lsGundam.SelectedItem = null;
            if (txtSearch.Text == null || txtSearch.Text == "")
            {
                lsGundam.DataSource = gundams;
                lsGundam.DisplayMember = "GundamName";
                lsGundam.ValueMember = "Address";
                //lsGundam.SelectedItem = null;
            }
            else
            {
                List<GundamInfo> search = new List<GundamInfo>();
                foreach (GundamInfo m in gundams)
                {
                    if ((m.GroupName + "-" + m.GundamName).IndexOf(txtSearch.Text) >= 0)
                    {
                        search.Add(m);
                    }
                }
                lsGundam.DataSource = search;
                lsGundam.DisplayMember = "GundamName";
                lsGundam.ValueMember = "Address";
                //lsGundam.SelectedItem = null;
            }
        }

        private void btnEditWeapon_Click(object sender, EventArgs e)
        {
            GundamInfo info = lsGundam.SelectedItem as GundamInfo;
            if (info != null)
            {
                FrmEditWeapon form = new FrmEditWeapon(gundamFile, info);
                form.ShowDialog();
            }
        }
    }
}
