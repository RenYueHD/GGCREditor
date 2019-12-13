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


        public void bindAll()
        {
            cboE1.DataSource = GGCRUtil.ListGundamEarth();
            cboE1.DisplayMember = "Value";
            cboE1.ValueMember = "Key";
            cboE2.DataSource = GGCRUtil.ListGundamEarth();
            cboE2.DisplayMember = "Value";
            cboE2.ValueMember = "Key";
            cboE3.DataSource = GGCRUtil.ListGundamEarth();
            cboE3.DisplayMember = "Value";
            cboE3.ValueMember = "Key";
            cboE4.DataSource = GGCRUtil.ListGundamEarth();
            cboE4.DisplayMember = "Value";
            cboE4.ValueMember = "Key";
            cboE5.DataSource = GGCRUtil.ListGundamEarth();
            cboE5.DisplayMember = "Value";
            cboE5.ValueMember = "Key";

            cboSize.DataSource = GGCRUtil.ListGundamSize();
            cboSize.DisplayMember = "Value";
            cboSize.ValueMember = "Key";

            cboSkill1.DataSource = GGCRUtil.ListGundamAbility();
            cboSkill2.DataSource = GGCRUtil.ListGundamAbility();
            cboSkill3.DataSource = GGCRUtil.ListGundamAbility();
            cboSkill4.DataSource = GGCRUtil.ListGundamAbility();
            cboSkill5.DataSource = GGCRUtil.ListGundamAbility();

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
        }

        private void FrmEditGundam_Load(object sender, EventArgs e)
        {

            bindAll();

            gundams = gundamFile.ListMachines();

            lsGundam.DataSource = gundams;
            lsGundam.DisplayMember = "GundamName";
            lsGundam.ValueMember = "Address";
        }

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
                txtWeapon1ID.Text = gundam.WeaponId.ToString();
                txtWeaponCount.Text = gundam.WeaponCount.ToString();

                cboSize.SelectedValue = gundam.Size.ToString();
                if (cboSize.SelectedValue == null)
                {
                    GGCRUtil.AddGundamSize(gundam.Size, "未知" + gundam.Size);
                    bindAll();
                    LoadData(gundam);
                    return;
                }

                string shiyin = gundam.Earch;

                cboE1.SelectedValue = shiyin[0].ToString();
                if (cboE1.SelectedValue == null)
                {
                    GGCRUtil.AddGundamSize(short.Parse(shiyin[0].ToString()), "未知" + shiyin[0].ToString());
                    bindAll();
                    LoadData(gundam);
                    return;
                }
                cboE2.SelectedValue = shiyin[1].ToString();
                if (cboE2.SelectedValue == null)
                {
                    GGCRUtil.AddGundamEarth(short.Parse(shiyin[1].ToString()), "未知" + shiyin[1].ToString());
                    bindAll();
                    LoadData(gundam);
                    return;
                }
                cboE3.SelectedValue = shiyin[2].ToString();
                if (cboE3.SelectedValue == null)
                {
                    GGCRUtil.AddGundamEarth(short.Parse(shiyin[2].ToString()), "未知" + shiyin[2].ToString());
                    bindAll();
                    LoadData(gundam);
                    return;
                }
                cboE4.SelectedValue = shiyin[3].ToString();
                if (cboE4.SelectedValue == null)
                {
                    GGCRUtil.AddGundamEarth(short.Parse(shiyin[3].ToString()), "未知" + shiyin[3].ToString());
                    bindAll();
                    LoadData(gundam);
                    return;
                }
                cboE5.SelectedValue = shiyin[4].ToString();
                if (cboE5.SelectedValue == null)
                {
                    GGCRUtil.AddGundamEarth(short.Parse(shiyin[4].ToString()), "未知" + shiyin[4].ToString());
                    bindAll();
                    LoadData(gundam);
                    return;
                }

                cboSkill1.SelectedValue = gundam.Skill1.ToString();
                if (cboSkill1.SelectedValue == null)
                {
                    GGCRUtil.AddGundamAbility(gundam.Skill1, "未知" + gundam.Skill1);
                    bindAll();
                    LoadData(gundam);
                    return;
                }
                cboSkill2.SelectedValue = gundam.Skill2.ToString();
                if (cboSkill2.SelectedValue == null)
                {
                    GGCRUtil.AddGundamAbility(gundam.Skill2, "未知" + gundam.Skill2);
                    bindAll();
                    LoadData(gundam);
                    return;
                }
                cboSkill3.SelectedValue = gundam.Skill3.ToString();
                if (cboSkill3.SelectedValue == null)
                {
                    GGCRUtil.AddGundamAbility(gundam.Skill3, "未知" + gundam.Skill3);
                    bindAll();
                    LoadData(gundam);
                    return;
                }
                cboSkill4.SelectedValue = gundam.Skill4.ToString();
                if (cboSkill4.SelectedValue == null)
                {
                    GGCRUtil.AddGundamAbility(gundam.Skill4, "未知" + gundam.Skill4);
                    bindAll();
                    LoadData(gundam);
                    return;
                }
                cboSkill5.SelectedValue = gundam.Skill5.ToString();
                if (cboSkill5.SelectedValue == null)
                {
                    GGCRUtil.AddGundamAbility(gundam.Skill5, "未知" + gundam.Skill5);
                    bindAll();
                    LoadData(gundam);
                    return;
                }

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
            tsmiLblState.Text = "等待修改";
            tsmiLblState.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GundamInfo gundam = lsGundam.SelectedItem as GundamInfo;
            if (gundam != null)
            {
                gundam.HP = int.Parse(txtHP.Text);
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

                gundam.Save();

                tsmiLblState.Text = "保存成功";
                tsmiLblState.ForeColor = Color.Green;
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
