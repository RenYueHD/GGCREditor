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
    public partial class FrmEditWeapon : Form
    {
        public FrmEditWeapon(string file)
        {
            InitializeComponent();
            tslblFile.Text = file;

            this.gundamFile = new GundamFile(file);
        }

        private GundamFile gundamFile;
        private List<WeaponInfo> weapons = new List<WeaponInfo>();

        private void FrmEditGundam_Load(object sender, EventArgs e)
        {


            using (StreamReader sr = new StreamReader("武器数据.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        WeaponInfo info = gundamFile.getWeapon(arr[1]);
                        info.WeaponName = arr[0];
                        weapons.Add(info);
                    }
                }
            }
            weapons.Sort();

            lsGundam.DataSource = weapons;
            lsGundam.DisplayMember = "WeaponName";
            lsGundam.ValueMember = "Address";
        }

        private void LoadData(WeaponInfo weapon)
        {
            if (weapon != null)
            {
                txtName.Text = weapon.WeaponName;
                txtAddress.Text = ByteHelper.ByteArrayToHexString(ByteHelper.Int2Bytes(weapon.Index));
                txtPower.Text = weapon.POWER.ToString();
                txtEN.Text = weapon.EN.ToString();
                txtMP.Text = weapon.MP.ToString();
                txtActEarth.Text = weapon.ACTEarth.ToString();
                txtMoveAct.Text = weapon.MoveACT.ToString();
                txtIco1.Text = weapon.ICO.ToString();
                txtIco2.Text = weapon.ICO2.ToString();
                txtSpec.Text = weapon.Spec.ToString();
                txtMpLimit.Text = weapon.MPLimit.ToString();
                txtUseEarth.Text = weapon.UseEarth.ToString();
                txtRange.Text = weapon.Range.ToString();
                txtHitRate.Text = weapon.HitRate.ToString();
                txtCT.Text = weapon.CT.ToString();
                txtHitCount.Text = weapon.HitCount.ToString();

                btnSave.Enabled = true;
            }
            else
            {

                txtName.Text = null;
                txtAddress.Text = null;
                txtPower.Text = null;
                txtEN.Text = null;
                txtMP.Text = null;
                txtActEarth.Text = null;
                txtMoveAct.Text = null;
                txtIco1.Text = null;
                txtIco2.Text = null;
                txtSpec.Text = null;

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
                WeaponInfo master = ((ListBox)sender).Items[e.Index] as WeaponInfo;
                StringFormat sStringFormat = new StringFormat();
                sStringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(master.WeaponName, e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
            }
            e.DrawFocusRectangle();
        }

        private void lsGundam_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaponInfo master = lsGundam.SelectedItem as WeaponInfo;
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
            WeaponInfo weapon = lsGundam.SelectedItem as WeaponInfo;
            if (weapon != null)
            {
                btnSave.Enabled = false;

                txtName.Text = weapon.WeaponName;
                txtAddress.Text = ByteHelper.ByteArrayToHexString(ByteHelper.Int2Bytes(weapon.Index));
                txtPower.Text = weapon.POWER.ToString();
                txtEN.Text = weapon.EN.ToString();
                txtMP.Text = weapon.MP.ToString();
                txtActEarth.Text = weapon.ACTEarth.ToString();
                txtMoveAct.Text = weapon.MoveACT.ToString();
                txtIco1.Text = weapon.ICO.ToString();
                txtIco2.Text = weapon.ICO2.ToString();
                txtSpec.Text = weapon.Spec.ToString();
                txtMpLimit.Text = weapon.MPLimit.ToString();
                txtUseEarth.Text = weapon.UseEarth.ToString();
                txtRange.Text = weapon.Range.ToString();
                txtHitRate.Text = weapon.HitRate.ToString();
                txtCT.Text = weapon.CT.ToString();
                txtHitCount.Text = weapon.HitCount.ToString();

                weapon.POWER = int.Parse(txtPower.Text);
                weapon.EN = short.Parse(txtEN.Text);
                weapon.MP = short.Parse(txtMP.Text);
                weapon.ACTEarth = short.Parse(txtActEarth.Text);
                weapon.MoveACT = byte.Parse(txtMoveAct.Text);
                weapon.ICO = byte.Parse(txtIco1.Text);
                weapon.ICO2 = byte.Parse(txtIco2.Text);
                weapon.Spec = byte.Parse(txtSpec.Text);
                weapon.MPLimit = short.Parse(txtMpLimit.Text);
                weapon.UseEarth = short.Parse(txtUseEarth.Text);
                weapon.Range = short.Parse(txtRange.Text);
                weapon.HitRate = byte.Parse(txtHitRate.Text);
                weapon.CT = byte.Parse(txtCT.Text);
                weapon.HitCount = byte.Parse(txtHitCount.Text);

                gundamFile.Save();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lsGundam.SelectedItem = null;
            if (txtSearch.Text == null || txtSearch.Text == "")
            {
                lsGundam.DataSource = weapons;
                lsGundam.DisplayMember = "WeaponName";
                lsGundam.ValueMember = "Address";
                //lsGundam.SelectedItem = null;
            }
            else
            {
                List<WeaponInfo> search = new List<WeaponInfo>();
                foreach (WeaponInfo m in weapons)
                {
                    if (m.WeaponName.IndexOf(txtSearch.Text) >= 0)
                    {
                        search.Add(m);
                    }
                }
                lsGundam.DataSource = search;
                lsGundam.DisplayMember = "WeaponName";
                lsGundam.ValueMember = "Address";
                //lsGundam.SelectedItem = null;
            }
        }
    }
}
