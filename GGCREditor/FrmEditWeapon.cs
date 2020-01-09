using GGCREditorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

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


        private void bindAll()
        {
            #region 绑定元素

            cboAE1.DataSource = GGCRUtil.ListActEarch();
            cboAE2.DataSource = GGCRUtil.ListActEarch();
            cboAE3.DataSource = GGCRUtil.ListActEarch();
            cboAE4.DataSource = GGCRUtil.ListActEarch();
            cboAE5.DataSource = GGCRUtil.ListActEarch();

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

            cboMpLimit.DataSource = GGCRUtil.ListWeaponMPLimit();
            cboMpLimit.DisplayMember = "Value";
            cboMpLimit.ValueMember = "Key";

            List<KeyValuePair<string, string>> specList = gundamFile.ListWeaponSpec();
            specList.Insert(0, new KeyValuePair<string, string>("0", "无"));

            cboSpec.DataSource = specList;
            cboSpec.DisplayMember = "Value";
            cboSpec.ValueMember = "Key";

            cboRange.DataSource = GGCRUtil.ListWeaponRange();
            cboRange.DisplayMember = "Value";
            cboRange.ValueMember = "Key";

            cboWeaponType.DataSource = GGCRUtil.ListWeaponType();
            cboWeaponType.DisplayMember = "Value";
            cboWeaponType.ValueMember = "Key";
            #endregion
        }


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
                short map = gundamInfo.WeaponMapID;
                if (map >= 0 && gundamInfo.WeaponMapCount > 0)
                {
                    for (short i = 0; i < gundamInfo.WeaponMapCount; i++)
                    {
                        limit.Add((short)(map + i + gundamFile.WeaponNormalCount));
                    }
                }
            }

            bindAll();

            weapons = new List<WeaponInfo>();

            foreach (WeaponInfo w in gundamFile.ListWeapons())
            {
                if (limit == null || limit.Contains(w.ID))
                {
                    weapons.Add(w);
                }
            }

            lsGundam.DataSource = weapons;
            lsGundam.DisplayMember = "UnitName";
            lsGundam.ValueMember = "Address";
        }



        private void LoadData(WeaponInfo weapon)
        {
            if (weapon != null)
            {
                txtId.Text = weapon.ID.ToString();

                txtName.Text = weapon.UnitName;
                txtAddress.Text = weapon.Address;
                txtPower.Text = weapon.POWER.ToString();
                txtEN.Text = weapon.EN.ToString();
                txtMP.Text = weapon.MP.ToString();
                txtMoveAct.Text = weapon.MoveACT.ToString();

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

                cboMpLimit.SelectedValue = weapon.MPLimit.ToString();
                if (cboMpLimit.SelectedValue == null)
                {
                    GGCRUtil.AddWeaponMPLimit(weapon.MPLimit, "未知" + weapon.MPLimit);
                    bindAll();
                    LoadData(weapon);
                    return;
                }


                if (weapon is WeaponNormalInfo)
                {
                    panNormal.Enabled = true;
                    panMap.Enabled = false;

                    cboProp.DataSource = this.gundamFile.ListWeaponProp();
                    cboProp.DisplayMember = "Value";
                    cboProp.ValueMember = "Key";
                    cboIco.DataSource = this.gundamFile.ListWeaponProp();
                    cboIco.DisplayMember = "Value";
                    cboIco.ValueMember = "Key";

                    txtHitRate.Text = (weapon as WeaponNormalInfo).HitRate.ToString();
                    txtCT.Text = (weapon as WeaponNormalInfo).CT.ToString();
                    txtHitCount.Text = (weapon as WeaponNormalInfo).HitCount.ToString();

                    txtMapTurn.Text = null;
                    txtAttMaxCount.Text = null;

                    cboWeaponType.SelectedValue = -1;
                }
                else
                {
                    panNormal.Enabled = false;
                    panMap.Enabled = true;

                    cboProp.DataSource = this.gundamFile.ListWeaponProp();
                    cboProp.DisplayMember = "Value";
                    cboProp.ValueMember = "Key";
                    cboIco.DataSource = this.gundamFile.ListWeaponProp();
                    cboIco.DisplayMember = "Value";
                    cboIco.ValueMember = "Key";

                    txtHitRate.Text = null;
                    txtCT.Text = null;
                    txtHitCount.Text = null;

                    txtMapTurn.Text = (weapon as WeaponMapInfo).MapTurn.ToString();
                    txtAttMaxCount.Text = (weapon as WeaponMapInfo).AttMaxCount.ToString();

                    cboWeaponType.SelectedValue = (weapon as WeaponMapInfo).WeaponType.ToString();
                    if (cboWeaponType.SelectedValue == null)
                    {
                        GGCRUtil.AddWeaponType((weapon as WeaponMapInfo).WeaponType, "未知" + (weapon as WeaponMapInfo).WeaponType);
                        bindAll();
                        LoadData(weapon);
                        return;
                    }
                }

                cboProp.SelectedValue = weapon.PROPER.ToString();
                cboIco.SelectedValue = weapon.ICO.ToString();

                cboSpec.SelectedValue = weapon.Spec.ToString();

                cboRange.SelectedValue = weapon.Range.ToString();
                if (cboRange.SelectedValue == null)
                {
                    GGCRUtil.AddWeaponRange(weapon.Range, "未知" + weapon.Range);
                    bindAll();
                    LoadData(weapon);
                    return;
                }

                btnSave.Enabled = true;
            }
            else
            {
                txtId.Text = null;

                txtName.Text = null;
                txtAddress.Text = null;
                txtPower.Text = null;
                txtEN.Text = null;
                txtMP.Text = null;
                txtMoveAct.Text = null;

                txtHitRate.Text = null;
                txtCT.Text = null;
                txtHitCount.Text = null;
                txtMapTurn.Text = null;
                txtAttMaxCount.Text = null;

                chkUse1.Checked = false;
                chkUse2.Checked = false;
                chkUse3.Checked = false;
                chkUse4.Checked = false;
                chkUse5.Checked = false;

                cboAE1.SelectedValue = -1;
                cboAE2.SelectedValue = -1;
                cboAE3.SelectedValue = -1;
                cboAE4.SelectedValue = -1;
                cboAE5.SelectedValue = -1;

                cboProp.SelectedValue = -1;
                cboIco.SelectedValue = -1;
                cboSpec.SelectedValue = -1;
                cboWeaponType.SelectedValue = -1;

                btnSave.Enabled = false;
            }
        }

        private void lsGundam_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = e.ItemHeight + 16;
        }

        private void lsGundam_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            if (e.Index >= 0)
            {
                WeaponInfo master = ((ListBox)sender).Items[e.Index] as WeaponInfo;

                StringFormat sStringFormat = new StringFormat();
                sStringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(master.IsMap ? ("(MAP)" + master.UnitName) : master.UnitName, e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
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
            tsmiLblState.Text = "等待修改";
            tsmiLblState.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WeaponInfo weapon = lsGundam.SelectedItem as WeaponInfo;
            if (weapon != null)
            {
                weapon.POWER = int.Parse(txtPower.Text);
                weapon.EN = short.Parse(txtEN.Text);
                weapon.MP = short.Parse(txtMP.Text);
                weapon.MoveACT = byte.Parse(txtMoveAct.Text);
                weapon.MPLimit = short.Parse(cboMpLimit.SelectedValue.ToString());
                weapon.UseEarth = (chkUse5.Checked ? "1" : "0") + (chkUse4.Checked ? "1" : "0") + (chkUse3.Checked ? "1" : "0") + (chkUse2.Checked ? "1" : "0") + (chkUse1.Checked ? "1" : "0");
                weapon.ActEarth = cboAE5.SelectedValue.ToString() + cboAE4.SelectedValue.ToString() + cboAE3.SelectedValue.ToString() + cboAE2.SelectedValue.ToString() + cboAE1.SelectedValue.ToString();
                weapon.PROPER = byte.Parse(cboProp.SelectedValue.ToString());
                weapon.ICO = byte.Parse(cboIco.SelectedValue.ToString());
                weapon.Spec = byte.Parse(cboSpec.SelectedValue.ToString());

                weapon.Range = short.Parse(cboRange.SelectedValue.ToString());

                if (txtName.Text != weapon.UnitName)
                {
                    weapon.SetUnitName(txtName.Text);
                }

                if (weapon is WeaponNormalInfo)
                {
                    (weapon as WeaponNormalInfo).HitRate = byte.Parse(txtHitRate.Text);
                    (weapon as WeaponNormalInfo).CT = byte.Parse(txtCT.Text);
                    (weapon as WeaponNormalInfo).HitCount = byte.Parse(txtHitCount.Text);
                }
                else
                {
                    (weapon as WeaponMapInfo).MapTurn = short.Parse(txtMapTurn.Text);
                    (weapon as WeaponMapInfo).WeaponType = byte.Parse(cboWeaponType.SelectedValue.ToString());
                    (weapon as WeaponMapInfo).AttMaxCount = byte.Parse(txtAttMaxCount.Text);
                }

                weapon.Save();

                weapon.Refresh();
                LoadData(weapon);

                tsmiLblState.Text = "保存成功";
                tsmiLblState.ForeColor = Color.Green;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lsGundam.SelectedItem = null;
            if (txtSearch.Text == null || txtSearch.Text == "")
            {
                lsGundam.DataSource = weapons;
                lsGundam.DisplayMember = "UnitName";
                lsGundam.ValueMember = "Address";
                //lsGundam.SelectedItem = null;
            }
            else
            {
                List<WeaponInfo> search = new List<WeaponInfo>();
                foreach (WeaponInfo m in weapons)
                {
                    if (m.UnitName.IndexOf(txtSearch.Text) >= 0)
                    {
                        search.Add(m);
                    }
                }
                lsGundam.DataSource = search;
                lsGundam.DisplayMember = "UnitName";
                lsGundam.ValueMember = "Address";
                //lsGundam.SelectedItem = null;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SelectedObjectCollection list = lsGundam.SelectedItems;
            if (list.Count == 1)
            {
                WeaponInfo gundam = lsGundam.SelectedItem as WeaponInfo;
                if (gundam != null)
                {
                    string fileName = gundam.UUID.Replace(" ", "_") + "-" + gundam.UnitName.Replace(" ", "_") + ".weapon";

                    SaveFileDialog dialog = new SaveFileDialog();
                    //dialog.RestoreDirectory = true;
                    dialog.Filter = "武器数据|*.weapon";
                    dialog.FileName = fileName;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fis = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            fis.Write(gundam.Data, 0, gundam.Data.Length);
                        }
                        tsmiLblState.Text = "导出成功";
                        tsmiLblState.ForeColor = Color.Green;
                    }
                }
            }
            else if (list.Count > 0)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择导出目录(自动覆盖)";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (Object obj in list)
                    {
                        WeaponInfo gundam = obj as WeaponInfo;
                        string name = dialog.SelectedPath + "\\" + gundam.UUID.Replace(" ", "_") + "-" + gundam.UnitName.Replace(" ", "_") + ".weapon";
                        export(gundam, name);
                    }
                    tsmiLblState.Text = "导出成功";
                    tsmiLblState.ForeColor = Color.Green;

                    MessageBox.Show("导出成功", "操作提示");
                }
            }
        }

        private void export(WeaponInfo gundam, string file)
        {
            using (FileStream fis = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                fis.Write(gundam.Data, 0, gundam.Data.Length);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.RestoreDirectory = true;
            dialog.Filter = "武器数据|*.weapon";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtSearch.Text = null;

                byte[] data = File.ReadAllBytes(dialog.FileName);

                byte[] bt = new byte[GGCRStaticConfig.WeaponUIDLength];
                Array.Copy(data, 0, bt, 0, bt.Length);
                string uid = ByteHelper.ByteArrayToHexString(bt).Trim();

                WeaponInfo select = null;
                foreach (WeaponInfo info in weapons)
                {
                    if (info.UUID == uid)
                    {
                        select = info;
                        break;
                    }
                }
                if (select == null)
                {
                    MessageBox.Show("该武器不存在,无法导入", "导入失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    select.Replace(data);
                    lsGundam.SelectedItem = null;
                    lsGundam.SelectedItem = select;

                    tsmiLblState.Text = "请保存";
                    tsmiLblState.ForeColor = Color.Red;
                }
            }
        }

        private void btnBatchImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.RestoreDirectory = true;
            dialog.Filter = "武器数据|*.weapon";
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK && dialog.FileNames.Length > 0)
            {
                txtSearch.Text = null;

                foreach (string fileName in dialog.FileNames)
                {
                    byte[] data = File.ReadAllBytes(fileName);

                    byte[] bt = new byte[GGCRStaticConfig.WeaponUIDLength];
                    Array.Copy(data, 0, bt, 0, bt.Length);
                    string uid = ByteHelper.ByteArrayToHexString(bt).Trim();

                    WeaponInfo select = null;
                    foreach (WeaponInfo info in weapons)
                    {
                        if (info.UUID == uid)
                        {
                            select = info;
                            break;
                        }
                    }
                    if (select != null)
                    {
                        select.Replace(data);
                        select.Save();
                    }
                }

                lsGundam.SelectedItem = null;

                bindAll();

                MessageBox.Show("导入成功,已自动保存", "操作提示");
                // lsGundam.SelectedIndex = 0;
            }
        }
    }
}
