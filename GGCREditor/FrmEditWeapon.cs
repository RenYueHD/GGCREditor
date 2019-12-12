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
        public FrmEditWeapon()
        {
            InitializeComponent();
            this.gundamFile = new GundamFile();
            tslblFile.Text = gundamFile.FileName;


        }

        public FrmEditWeapon(GundamFile gundanFile, GundamInfo gundamInfo)
        {
            InitializeComponent();
            tslblFile.Text = gundanFile.FileName;

            this.gundamFile = gundanFile;
            this.gundamInfo = gundamInfo;
        }

        private GundamInfo gundamInfo;
        private GundamFile gundamFile;
        private List<WeaponInfo> weapons = new List<WeaponInfo>();

        List<KeyValuePair<string, string>> icos = new List<KeyValuePair<string, string>>();
        List<KeyValuePair<string, string>> prop = new List<KeyValuePair<string, string>>();
        List<KeyValuePair<string, string>> spec = new List<KeyValuePair<string, string>>();
        List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();

        private void FrmEditGundam_Load(object sender, EventArgs e)
        {
            List<short> limit = null;
            if (gundamInfo != null)
            {
                limit = new List<short>();
                short wid = gundamInfo.WeaponId;
                if (wid >= 0 && gundamInfo.WeaponCount > 0)
                {
                    for (short i = 0; i < gundamInfo.WeaponCount; i++)
                    {
                        limit.Add((short)(wid + i));
                    }
                }
            }


            cboAE1.DataSource = buildActEarch();
            cboAE2.DataSource = buildActEarch();
            cboAE3.DataSource = buildActEarch();
            cboAE4.DataSource = buildActEarch();
            cboAE5.DataSource = buildActEarch();

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

            cboMpLimit.DataSource = buildMP();
            cboMpLimit.DisplayMember = "Value";
            cboMpLimit.ValueMember = "Key";

            using (StreamReader sr = new StreamReader("武器属性.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        prop.Add(kv);
                        icos.Add(kv);
                    }
                }
            }

            cboProp.DataSource = prop;
            cboProp.DisplayMember = "Value";
            cboProp.ValueMember = "Key";
            cboIco.DataSource = icos;
            cboIco.DisplayMember = "Value";
            cboIco.ValueMember = "Key";

            using (StreamReader sr = new StreamReader("武器效果.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        spec.Add(kv);
                    }
                }
            }

            cboSpec.DataSource = spec;
            cboSpec.DisplayMember = "Value";
            cboSpec.ValueMember = "Key";

            using (StreamReader sr = new StreamReader("射程代码.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        range.Add(kv);
                    }
                }
            }

            cboRange.DataSource = range;
            cboRange.DisplayMember = "Value";
            cboRange.ValueMember = "Key";

            weapons = new List<WeaponInfo>();

            foreach (WeaponInfo w in gundamFile.ListWeapons())
            {
                if (limit == null || limit.Contains(w.ID))
                {
                    weapons.Add(w);
                }
            }

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

        private List<KeyValuePair<string, string>> buildMP()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("0", "普通"));
            list.Add(new KeyValuePair<string, string>("4", "超强势"));
            list.Add(new KeyValuePair<string, string>("5", "超一击"));
            return list;
        }

        private void LoadData(WeaponInfo weapon)
        {
            if (weapon != null)
            {
                txtId.Text = weapon.ID.ToString();

                txtName.Text = weapon.WeaponName;
                txtAddress.Text = ByteHelper.ByteArrayToHexString(ByteHelper.Int2Bytes(weapon.Index));
                txtPower.Text = weapon.POWER.ToString();
                txtEN.Text = weapon.EN.ToString();
                txtMP.Text = weapon.MP.ToString();
                txtMoveAct.Text = weapon.MoveACT.ToString();

                cboMpLimit.SelectedValue = weapon.MPLimit.ToString();

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

                cboProp.SelectedValue = weapon.PROPER.ToString();
                cboIco.SelectedValue = weapon.ICO.ToString();
                cboSpec.SelectedValue = weapon.Spec.ToString();
                cboRange.SelectedValue = weapon.Range.ToString();

                txtUnKnow.Text = weapon.Range.ToString();


                btnSave.Enabled = true;
            }
            else
            {
                txtId.Text = null;
                txtUnKnow.Text = null;

                txtName.Text = null;
                txtAddress.Text = null;
                txtPower.Text = null;
                txtEN.Text = null;
                txtMP.Text = null;
                txtMoveAct.Text = null;

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
                weapon.MPLimit = short.Parse(cboMpLimit.SelectedValue.ToString());
                weapon.UseEarth = (chkUse5.Checked ? "1" : "0") + (chkUse4.Checked ? "1" : "0") + (chkUse3.Checked ? "1" : "0") + (chkUse2.Checked ? "1" : "0") + (chkUse1.Checked ? "1" : "0");
                weapon.ActEarth = cboAE5.SelectedValue.ToString() + cboAE4.SelectedValue.ToString() + cboAE3.SelectedValue.ToString() + cboAE2.SelectedValue.ToString() + cboAE1.SelectedValue.ToString();
                weapon.HitRate = byte.Parse(txtHitRate.Text);
                weapon.CT = byte.Parse(txtCT.Text);
                weapon.HitCount = byte.Parse(txtHitCount.Text);
                weapon.PROPER = byte.Parse(cboProp.SelectedValue.ToString());
                weapon.ICO = byte.Parse(cboIco.SelectedValue.ToString());
                weapon.Spec = byte.Parse(cboSpec.SelectedValue.ToString());

                weapon.Range = short.Parse(cboRange.SelectedValue.ToString());

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
