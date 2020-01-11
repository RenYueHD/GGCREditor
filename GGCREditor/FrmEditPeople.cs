using GGCREditorLib;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.ListBox;

namespace GGCREditor
{
    public partial class FrmEditPeople : Form
    {
        private FrmEditPeople()
        {
            InitializeComponent();
            
        }

        public static FrmEditPeople CreateForm()
        {
            if (form == null)
            {
                form = new FrmEditPeople();
            }
            return form;
        }

        private static FrmEditPeople form;
        Dictionary<string, byte[]> head;
        MasterFile masterFile = null;
        List<MasterInfo> masters = new List<MasterInfo>();

        private void bindAll()
        {
            masterFile = new MasterFile();
            tslblFIle.Text = masterFile.FileName;

            head = ZipHelper.ZipDeCompressToDic(GGCRStaticConfig.PATH + "\\images\\schips.txd");

            cboGuYou1.DataSource = GGCRUtil.ListPeopleSkill();
            cboGuYou1.ValueMember = "Key";
            cboGuYou1.DisplayMember = "Value";

            cboGuYou2.DataSource = GGCRUtil.ListPeopleSkill();
            cboGuYou2.ValueMember = "Key";
            cboGuYou2.DisplayMember = "Value";

            cboGuYou3.DataSource = GGCRUtil.ListPeopleSkill();
            cboGuYou3.ValueMember = "Key";
            cboGuYou3.DisplayMember = "Value";

            cboGrown.DataSource = GGCRUtil.ListMasterGrown();
            cboGrown.ValueMember = "Key";
            cboGrown.DisplayMember = "Value";

            cboLast4.DataSource = GGCRUtil.ListMasterZhaoPin();
            cboLast4.ValueMember = "Key";
            cboLast4.DisplayMember = "Value";
        }

        private void FrmEditPeople_Load(object sender, EventArgs e)
        {

            bindAll();

            masters = masterFile.ListMasters();

            lsMasters.DataSource = masters;
            lsMasters.DisplayMember = "UnitName";
        }


        private void LoadData(MasterInfo master)
        {
            if (master != null)
            {
                string name = master.PicName;
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

                txtPic.Text = name;
                txtId.Text = master.ID.ToString();
                txtUnKnow.Text = master.Unknow.ToString();
                txtName.Text = master.UnitName;
                txtAddress.Text = master.Address;
                txtSheJi.Text = master.SheJi.ToString();
                txtGeDou.Text = master.GeDou.ToString();
                txtShouBei.Text = master.ShouBei.ToString();
                txtFanYin.Text = master.FanYin.ToString();
                txtJueXin.Text = master.JueXin.ToString();
                txtZhiHui.Text = master.ZhiHui.ToString();
                txtFuZuo.Text = master.FuZuo.ToString();
                txtTongXun.Text = master.TongXun.ToString();
                txtCaoDuo.Text = master.CaoDuo.ToString();
                txtWeiXiu.Text = master.WeiXiu.ToString();
                txtMeiLi.Text = master.MeiLi.ToString();
                txtJinYan.Text = master.JinYan.ToString();

                cboGrown.SelectedValue = master.ChengZhang.ToString();
                if (cboGrown.SelectedValue == null)
                {
                    GGCRUtil.AddMasterGrown(master.ChengZhang, "未知" + master.ChengZhang);
                    bindAll();
                    LoadData(master);
                    return;
                }

                cboGuYou1.SelectedValue = master.GuYou1.ToString();
                if (cboGuYou1.SelectedValue == null)
                {
                    GGCRUtil.AddPeopleSkill(master.GuYou1, "未知" + master.GuYou1);
                    bindAll();
                    LoadData(master);
                    return;
                }
                cboGuYou2.SelectedValue = master.GuYou2.ToString();
                if (cboGuYou2.SelectedValue == null)
                {
                    GGCRUtil.AddPeopleSkill(master.GuYou2, "未知" + master.GuYou2);
                    bindAll();
                    LoadData(master);
                    return;
                }
                cboGuYou3.SelectedValue = master.GuYou3.ToString();
                if (cboGuYou3.SelectedValue == null)
                {
                    GGCRUtil.AddPeopleSkill(master.GuYou3, "未知" + master.GuYou3);
                    bindAll();
                    LoadData(master);
                    return;
                }

                cboLast4.SelectedValue = master.Last4.ToString();
                if (cboLast4.SelectedValue == null)
                {
                    GGCRUtil.AddMasterZhaoPin(master.Last4, "未知" + master.Last4);
                    bindAll();
                    LoadData(master);
                    return;
                }

                btnSave.Enabled = true;
            }
            else
            {
                txtId.Text = null;
                txtUnKnow.Text = null;
                txtName.Text = null;
                txtSheJi.Text = null;
                txtGeDou.Text = null;
                txtShouBei.Text = null;
                txtFanYin.Text = null;
                txtJueXin.Text = null;
                txtZhiHui.Text = null;
                txtFuZuo.Text = null;
                txtTongXun.Text = null;
                txtCaoDuo.Text = null;
                txtWeiXiu.Text = null;
                txtMeiLi.Text = null;
                txtJinYan.Text = null;

                cboGrown.SelectedValue = -1;
                cboGuYou1.SelectedValue = -1;
                cboGuYou2.SelectedValue = -1;
                cboGuYou3.SelectedValue = -1;

                cboLast4.SelectedValue = -1;

                btnSave.Enabled = false;
            }
        }


        private void lsMasters_SelectedIndexChanged(object sender, EventArgs e)
        {
            MasterInfo master = lsMasters.SelectedItem as MasterInfo;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == null || txtSearch.Text == "")
            {
                lsMasters.DataSource = masters;
                lsMasters.DisplayMember = "UnitName";
                lsMasters.SelectedItem = null;
            }
            else
            {
                List<MasterInfo> search = new List<MasterInfo>();
                foreach (MasterInfo m in masters)
                {
                    if ((m.GroupName + "-" + m.UnitName).IndexOf(txtSearch.Text) >= 0)
                    {
                        search.Add(m);
                    }
                }
                lsMasters.DataSource = search;
                lsMasters.DisplayMember = "UnitName";
                lsMasters.SelectedItem = null;
            }
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            MasterInfo master = lsMasters.SelectedItem as MasterInfo;
            if (master != null)
            {
                master.SheJi = short.Parse(txtSheJi.Text);
                master.GeDou = short.Parse(txtGeDou.Text);
                master.ShouBei = short.Parse(txtShouBei.Text);
                master.FanYin = short.Parse(txtFanYin.Text);
                master.JueXin = short.Parse(txtJueXin.Text);
                master.ZhiHui = short.Parse(txtZhiHui.Text);
                master.FuZuo = short.Parse(txtFuZuo.Text);
                master.TongXun = short.Parse(txtTongXun.Text);
                master.CaoDuo = short.Parse(txtCaoDuo.Text);
                master.WeiXiu = short.Parse(txtWeiXiu.Text);
                master.MeiLi = short.Parse(txtMeiLi.Text);
                master.JinYan = short.Parse(txtJinYan.Text);
                master.ChengZhang = short.Parse(cboGrown.SelectedValue.ToString());

                try
                {
                    master.GuYou1 = short.Parse(cboGuYou1.SelectedValue.ToString());
                }
                catch
                {
                    MessageBox.Show("固有技能1编号未知,已使用原始能力" + master.GuYou1);
                }
                try
                {
                    master.GuYou2 = short.Parse(cboGuYou2.SelectedValue.ToString());
                }
                catch
                {
                    MessageBox.Show("固有技能2编号未知,已使用原始能力" + master.GuYou2);
                }
                try
                {
                    master.GuYou3 = short.Parse(cboGuYou3.SelectedValue.ToString());
                }
                catch
                {
                    MessageBox.Show("固有技能3编号未知,已使用原始能力" + master.GuYou3);
                }

                master.Last4 = short.Parse(cboLast4.SelectedValue.ToString());

                master.Save();

                master.Refresh();
                LoadData(master);

                tsmiLblState.Text = "保存成功";
                tsmiLblState.ForeColor = Color.Green;
            }
        }

        private void lsMasters_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            if (e.Index >= 0)
            {
                MasterInfo master = ((ListBox)sender).Items[e.Index] as MasterInfo;
                StringFormat sStringFormat = new StringFormat();
                sStringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(master.GroupName + "-" + master.UnitName, e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
            }
            e.DrawFocusRectangle();
        }

        private void lsMasters_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = e.ItemHeight + 16;
        }

        private void FrmEditPeople_FormClosed(object sender, FormClosedEventArgs e)
        {
            form = null;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SelectedObjectCollection list = lsMasters.SelectedItems;
            if (list.Count == 1)
            {
                MasterInfo gundam = lsMasters.SelectedItem as MasterInfo;
                if (gundam != null)
                {
                    string fileName = gundam.PicName + "-" + gundam.UnitName.Replace(" ", "_") + ".master";

                    SaveFileDialog dialog = new SaveFileDialog();
                    //dialog.RestoreDirectory = true;
                    dialog.Filter = "人物数据|*.master";

                    dialog.FileName = fileName;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        export(gundam, dialog.FileName);
                    }
                    tsmiLblState.Text = "导出成功";
                    tsmiLblState.ForeColor = Color.Green;

                    MessageBox.Show("导出成功", "操作提示");
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
                        MasterInfo gundam = obj as MasterInfo;
                        string name = dialog.SelectedPath + "\\" + gundam.PicName + "-" + gundam.UnitName.Replace(" ", "_") + ".master";
                        export(gundam, name);
                    }
                    tsmiLblState.Text = "导出成功";
                    tsmiLblState.ForeColor = Color.Green;

                    MessageBox.Show("导出成功", "操作提示");
                }
            }
        }

        private void export(MasterInfo gundam, string file)
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
            dialog.Filter = "人物数据|*.master";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtSearch.Text = null;

                byte[] data = File.ReadAllBytes(dialog.FileName);

                byte[] bt = new byte[GGCRStaticConfig.MasterUIDLength];
                Array.Copy(data, 0, bt, 0, bt.Length);
                string uid = ByteHelper.ByteArrayToHexString(bt).Trim();

                MasterInfo select = null;
                foreach (MasterInfo info in masters)
                {
                    if (info.UUID == uid)
                    {
                        select = info;
                        break;
                    }
                }
                if (select == null)
                {
                    MessageBox.Show("该角色不存在,无法导入", "导入失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    select.Replace(data);
                    lsMasters.SelectedItem = null;
                    lsMasters.SelectedItem = select;

                    tsmiLblState.Text = "请保存";
                    tsmiLblState.ForeColor = Color.Red;
                }
            }
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            //dialog.RestoreDirectory = true;
            dialog.Filter = "文本文件|*.txt";
            dialog.FileName = "全部人物数据";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dialog.FileName, false, Encoding.UTF8))
                {
                    sw.Write("地址\t系列\t姓名\t射击\t格斗\t守备\t反应\t觉醒\t经验值\t指挥\t辅佐\t通讯\t操舵\t维修\t魅力");
                    sw.Write("\t成长\t技能1\t技能2\t技能3\t招聘可能");
                    sw.WriteLine();

                    foreach (MasterInfo master in masterFile.ListMasters())
                    {

                        sw.Write(master.Address + "\t");
                        sw.Write(master.GroupName + "\t");
                        sw.Write(master.UnitName + "\t");
                        sw.Write(master.SheJi + "\t");
                        sw.Write(master.GeDou + "\t");
                        sw.Write(master.ShouBei + "\t");
                        sw.Write(master.FanYin + "\t");
                        sw.Write(master.JueXin + "\t");
                        sw.Write(master.JinYan + "\t");
                        sw.Write(master.ZhiHui + "\t");
                        sw.Write(master.FuZuo + "\t");
                        sw.Write(master.TongXun + "\t");
                        sw.Write(master.CaoDuo + "\t");
                        sw.Write(master.WeiXiu + "\t");
                        sw.Write(master.MeiLi + "\t");
                        sw.Write(GGCRUtil.Transform(cboGrown.DataSource as List<KeyValuePair<string, string>>, master.ChengZhang.ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboGuYou1.DataSource as List<KeyValuePair<string, string>>, master.GuYou1.ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboGuYou2.DataSource as List<KeyValuePair<string, string>>, master.GuYou1.ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboGuYou3.DataSource as List<KeyValuePair<string, string>>, master.GuYou1.ToString()) + "\t");
                        sw.Write(GGCRUtil.Transform(cboLast4.DataSource as List<KeyValuePair<string, string>>, master.Last4.ToString()) + "\t");

                        sw.WriteLine();
                    }
                }
            }
        }

        private void btnImportBatch_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.RestoreDirectory = true;
            dialog.Filter = "人物数据|*.master";
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK && dialog.FileNames.Length > 0)
            {
                txtSearch.Text = null;

                foreach (string fileName in dialog.FileNames)
                {
                    byte[] data = File.ReadAllBytes(fileName);

                    byte[] bt = new byte[GGCRStaticConfig.MasterUIDLength];
                    Array.Copy(data, 0, bt, 0, bt.Length);
                    string uid = ByteHelper.ByteArrayToHexString(bt).Trim();

                    MasterInfo select = null;
                    foreach (MasterInfo info in masters)
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

                lsMasters.SelectedItem = null;

                bindAll();

                MessageBox.Show("导入成功,已自动保存", "操作提示");
                // lsGundam.SelectedIndex = 0;
            }
        }
    }
}
