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
    public partial class FrmEditGundam : Form
    {
        public FrmEditGundam()
        {
            InitializeComponent();

        }

        private GundamFile gundamFile;
        private List<GundamInfo> gundams = new List<GundamInfo>();
        Dictionary<string, byte[]> head;


        public void bindAll()
        {
            this.gundamFile = new GundamFile();
            tslblFile.Text = gundamFile.FileName;

            head = ZipHelper.ZipDeCompressToDic(GGCRStaticConfig.PATH + "\\images\\schips.txd");

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

            cboEarthSize.DataSource = GGCRUtil.ListEarthSize();
            cboEarthSize.DisplayMember = "Value";
            cboEarthSize.ValueMember = "Key";

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
        }

        private void LoadData(GundamInfo gundam)
        {
            if (gundam != null)
            {
                string name = gundam.PicName;

                txtPic.Text = name;

                if (head.ContainsKey(name))
                {
                    DDSImage image = new DDSImage(head[name]);
                    pic1.Image = Image.FromHbitmap(image.images[0].GetHbitmap());
                }
                else
                {
                    if (pic1.Image != null)
                    {
                        pic1.Image.Dispose();
                        pic1.Image = null;
                    }
                }

                txtUUID.Text = gundam.UUID;

                txtGroup.Text = gundam.GroupName;
                txtPrice.Text = gundam.Price.ToString();

                txtName.Text = gundam.UnitName;
                txtAddress.Text = gundam.Address;
                txtHP.Text = gundam.HP.ToString();
                txtEN.Text = gundam.EN.ToString();
                txtAct.Text = gundam.ACT.ToString();
                txtDef.Text = gundam.DEF.ToString();
                txtSpd.Text = gundam.SPD.ToString();
                txtMove.Text = gundam.Move.ToString();
                txtWeapon1ID.Text = gundam.WeaponId.ToString();
                txtWeaponCount.Text = gundam.WeaponCount.ToString();
                txtFirstMap.Text = gundam.WeaponMapID.ToString();
                txtMapCount.Text = gundam.WeaponMapCount.ToString();

                cboEarthSize.SelectedValue = gundam.EarchSize.ToString();
                if (cboEarthSize.SelectedValue == null)
                {
                    GGCRUtil.AddEarthSize(gundam.EarchSize, "未知" + gundam.EarchSize.ToString());
                    bindAll();
                    LoadData(gundam);
                    return;
                }

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
                txtUUID.Text = null;

                txtPrice.Text = null;
                txtGroup.Text = null;
                txtName.Text = null;
                txtAddress.Text = null;
                txtHP.Text = null;
                txtEN.Text = null;
                txtAct.Text = null;
                txtDef.Text = null;
                txtSpd.Text = null;
                txtMove.Text = null;

                cboSize.SelectedValue = "-1";

                cboEarthSize.SelectedValue = "-1";

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
            e.ItemHeight = e.ItemHeight + 16;
        }

        private void lsGundam_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            if (e.Index >= 0)
            {
                GundamInfo master = ((ListBox)sender).Items[e.Index] as GundamInfo;
                StringFormat sStringFormat = new StringFormat();
                sStringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(master.GroupName + "-" + master.UnitName, e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
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
                gundam.EarchSize = short.Parse(cboEarthSize.SelectedValue.ToString());
                gundam.Price = int.Parse(txtPrice.Text);

                gundam.WeaponId = short.Parse(txtWeapon1ID.Text);
                gundam.WeaponCount = byte.Parse(txtWeaponCount.Text);
                gundam.WeaponMapID = short.Parse(txtFirstMap.Text);
                gundam.WeaponMapCount = byte.Parse(txtMapCount.Text);

                gundam.Skill1 = short.Parse(cboSkill1.SelectedValue.ToString());
                gundam.Skill2 = short.Parse(cboSkill2.SelectedValue.ToString());
                gundam.Skill3 = short.Parse(cboSkill3.SelectedValue.ToString());
                gundam.Skill4 = short.Parse(cboSkill4.SelectedValue.ToString());
                gundam.Skill5 = short.Parse(cboSkill5.SelectedValue.ToString());

                if (gundam.UnitName != txtName.Text)
                {
                    gundam.SetUnitName(txtName.Text);
                }

                string shiyin = cboE1.SelectedValue.ToString() + cboE2.SelectedValue.ToString() + cboE3.SelectedValue.ToString() + cboE4.SelectedValue.ToString() + cboE5.SelectedValue.ToString();

                gundam.Earch = shiyin;

                gundam.Save();

                gundam.Refresh();

                LoadData(gundam);

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
            }
            else
            {
                List<GundamInfo> search = new List<GundamInfo>();
                foreach (GundamInfo m in gundams)
                {
                    if ((m.GroupName + "-" + m.UnitName).IndexOf(txtSearch.Text) >= 0 || m.UUID.IndexOf(txtSearch.Text) >= 0)
                    {
                        search.Add(m);
                    }
                }
                lsGundam.DataSource = search;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            SelectedObjectCollection list = lsGundam.SelectedItems;
            if (list.Count == 1)
            {
                GundamInfo gundam = lsGundam.SelectedItem as GundamInfo;
                if (gundam != null)
                {
                    string fileName = gundam.PicName + "-" + gundam.UnitName.Replace(" ", "_") + ".machine";

                    SaveFileDialog dialog = new SaveFileDialog();
                    //dialog.RestoreDirectory = true;
                    dialog.Filter = "机体数据|*.machine";
                    dialog.FileName = fileName;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fis = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            fis.Write(gundam.Data, 0, gundam.Data.Length);
                        }
                        tsmiLblState.Text = "导出成功";
                        tsmiLblState.ForeColor = Color.Green;

                        MessageBox.Show("导出成功", "操作提示");
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
                        GundamInfo gundam = obj as GundamInfo;
                        string name = dialog.SelectedPath + "\\" + gundam.PicName + "-" + gundam.UnitName.Replace(" ", "_") + ".machine";
                        export(gundam, name);
                    }
                    tsmiLblState.Text = "导出成功";
                    tsmiLblState.ForeColor = Color.Green;

                    MessageBox.Show("导出成功", "操作提示");
                }

            }
        }

        private void export(GundamInfo gundam, string file)
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
            dialog.Filter = "机体数据|*.machine";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtSearch.Text = null;

                byte[] data = File.ReadAllBytes(dialog.FileName);

                byte[] bt = new byte[GGCRStaticConfig.GundamUIDLength];
                Array.Copy(data, 0, bt, 0, bt.Length);
                string uid = ByteHelper.ByteArrayToHexString(bt).Trim();

                GundamInfo select = null;
                foreach (GundamInfo info in gundams)
                {
                    if (info.UUID == uid)
                    {
                        select = info;
                        break;
                    }
                }
                if (select == null)
                {
                    MessageBox.Show("该机体不存在,无法导入", "导入失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    short nameId = select.UnitNameTblIndex;
                    select.Replace(data);
                    select.UnitNameTblIndex = nameId;
                    lsGundam.SelectedItem = null;
                    lsGundam.SelectedItem = select;

                    tsmiLblState.Text = "请保存";
                    tsmiLblState.ForeColor = Color.Red;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string uuid = (lsGundam.SelectedItem as GundamInfo).UUID;
            FrmEditMachineConvert form = new FrmEditMachineConvert(uuid);
            form.ShowDialog();

            bindAll();
            foreach (GundamInfo g in this.gundams)
            {
                if (g.UUID == uuid)
                {
                    lsGundam.SelectedItem = g;
                    LoadData(g);
                    break;
                }
            }
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            //dialog.RestoreDirectory = true;
            dialog.Filter = "文本文件|*.txt";
            dialog.FileName = "全部机体数据";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dialog.FileName, false, Encoding.UTF8))
                {
                    sw.Write("地址\t系列\t机体名\tHP\tEN\t攻击\t防御\t机动\t移动\tSize\t占地图面积\t适性宇");
                    sw.Write("\t适性空\t适性地\t适性水上\t适性水中\t能力1\t能力2\t能力3\t能力4\t能力5\t");
                    sw.WriteLine();

                    foreach (GundamInfo gundam in gundamFile.ListMachines())
                    {
                        sw.Write(gundam.Address + "\t");
                        sw.Write(gundam.GroupName + "\t");
                        sw.Write(gundam.UnitName + "\t");
                        sw.Write(gundam.HP + "\t");
                        sw.Write(gundam.EN + "\t");
                        sw.Write(gundam.ACT + "\t");
                        sw.Write(gundam.DEF + "\t");
                        sw.Write(gundam.SPD + "\t");
                        sw.Write(gundam.Move + "\t");
                        sw.Write(GGCRUtil.Transform(cboSize.DataSource as List<KeyValuePair<string, string>>, gundam.Size.ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboEarthSize.DataSource as List<KeyValuePair<string, string>>, gundam.EarchSize.ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboE1.DataSource as List<KeyValuePair<string, string>>, gundam.Earch[0].ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboE1.DataSource as List<KeyValuePair<string, string>>, gundam.Earch[1].ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboE1.DataSource as List<KeyValuePair<string, string>>, gundam.Earch[2].ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboE1.DataSource as List<KeyValuePair<string, string>>, gundam.Earch[3].ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboE1.DataSource as List<KeyValuePair<string, string>>, gundam.Earch[4].ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboSkill1.DataSource as List<KeyValuePair<string, string>>, gundam.Skill1.ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboSkill1.DataSource as List<KeyValuePair<string, string>>, gundam.Skill2.ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboSkill1.DataSource as List<KeyValuePair<string, string>>, gundam.Skill3.ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboSkill1.DataSource as List<KeyValuePair<string, string>>, gundam.Skill4.ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboSkill1.DataSource as List<KeyValuePair<string, string>>, gundam.Skill5.ToString()) + "\t");

                        sw.WriteLine();
                    }
                }
            }
        }

        private void btnBatchImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.RestoreDirectory = true;
            dialog.Filter = "机体数据|*.machine";
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK && dialog.FileNames.Length > 0)
            {
                txtSearch.Text = null;

                foreach (string fileName in dialog.FileNames)
                {
                    byte[] data = File.ReadAllBytes(fileName);

                    byte[] bt = new byte[GGCRStaticConfig.GundamUIDLength];
                    Array.Copy(data, 0, bt, 0, bt.Length);
                    string uid = ByteHelper.ByteArrayToHexString(bt).Trim();

                    GundamInfo select = null;
                    foreach (GundamInfo info in gundams)
                    {
                        if (info.UUID == uid)
                        {
                            select = info;
                            break;
                        }
                    }
                    if (select != null)
                    {
                        short nameId = select.UnitNameTblIndex;
                        select.Replace(data);
                        select.UnitNameTblIndex = nameId;
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
