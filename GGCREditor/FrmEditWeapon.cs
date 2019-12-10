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

        List<KeyValuePair<string, string>> actEarch1;
        List<KeyValuePair<string, string>> actEarch2;
        List<KeyValuePair<string, string>> actEarch3;
        List<KeyValuePair<string, string>> actEarch4;
        List<KeyValuePair<string, string>> actEarch5;

        private void FrmEditGundam_Load(object sender, EventArgs e)
        {
            actEarch1 = buildActEarch();
            actEarch2 = buildActEarch();
            actEarch3 = buildActEarch();
            actEarch4 = buildActEarch();
            actEarch5 = buildActEarch();


            cboAE1.DataSource = actEarch1;
            cboAE2.DataSource = actEarch2;
            cboAE3.DataSource = actEarch3;
            cboAE4.DataSource = actEarch4;
            cboAE5.DataSource = actEarch5;

            cboAE1.DisplayMember = "Value";
            cboAE2.DisplayMember = "Value";
            cboAE3.DisplayMember = "Value";
            cboAE4.DisplayMember = "Value";
            cboAE5.DisplayMember = "Value";

            cboAE1.ValueMember = "Key";
            cboAE2.ValueMember = "Key";
            cboAE3.ValueMember = "Key";
            cboAE4.ValueMember = "Key";
            cboAE5.ValueMember = "Key";


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

        private List<KeyValuePair<string, string>> buildActEarch()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("00", "无效"));
            list.Add(new KeyValuePair<string, string>("01", "减半"));
            list.Add(new KeyValuePair<string, string>("10", "正常"));
            return list;
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
                txtMoveAct.Text = weapon.MoveACT.ToString();
                txtIco1.Text = weapon.ICO.ToString();
                txtIco2.Text = weapon.ICO2.ToString();
                txtSpec.Text = weapon.Spec.ToString();
                txtMpLimit.Text = weapon.MPLimit.ToString();
                txtRange.Text = weapon.Range.ToString();
                txtHitRate.Text = weapon.HitRate.ToString();
                txtCT.Text = weapon.CT.ToString();
                txtHitCount.Text = weapon.HitCount.ToString();

                string useEarth = weapon.UseEarth;
                chkUse1.Checked = useEarth[4] == '1';
                chkUse2.Checked = useEarth[3] == '1';
                chkUse3.Checked = useEarth[2] == '1';
                chkUse4.Checked = useEarth[1] == '1';
                chkUse5.Checked = useEarth[0] == '1';

                string actEarch = weapon.ActEarth;

                cboAE1.SelectedValue = "" + actEarch[8] + actEarch[9];
                cboAE2.SelectedValue = "" + actEarch[6] + actEarch[7];
                cboAE3.SelectedValue = "" + actEarch[4] + actEarch[5];
                cboAE4.SelectedValue = "" + actEarch[2] + actEarch[3];
                cboAE5.SelectedValue = "" + actEarch[0] + actEarch[1];

                btnSave.Enabled = true;
            }
            else
            {

                txtName.Text = null;
                txtAddress.Text = null;
                txtPower.Text = null;
                txtEN.Text = null;
                txtMP.Text = null;
                txtMoveAct.Text = null;
                txtIco1.Text = null;
                txtIco2.Text = null;
                txtSpec.Text = null;

                chkUse1.Checked = false;
                chkUse2.Checked = false;
                chkUse3.Checked = false;
                chkUse4.Checked = false;
                chkUse5.Checked = false;

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

                weapon.POWER = int.Parse(txtPower.Text);
                weapon.EN = short.Parse(txtEN.Text);
                weapon.MP = short.Parse(txtMP.Text);
                weapon.MoveACT = byte.Parse(txtMoveAct.Text);
                weapon.ICO = byte.Parse(txtIco1.Text);
                weapon.ICO2 = byte.Parse(txtIco2.Text);
                weapon.Spec = byte.Parse(txtSpec.Text);
                weapon.MPLimit = short.Parse(txtMpLimit.Text);
                weapon.UseEarth = (chkUse5.Checked ? "1" : "0") + (chkUse4.Checked ? "1" : "0") + (chkUse3.Checked ? "1" : "0") + (chkUse2.Checked ? "1" : "0") + (chkUse1.Checked ? "1" : "0");
                weapon.ActEarth = cboAE5.SelectedValue.ToString() + cboAE4.SelectedValue.ToString() + cboAE3.SelectedValue.ToString() + cboAE2.SelectedValue.ToString() + cboAE1.SelectedValue.ToString();
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
