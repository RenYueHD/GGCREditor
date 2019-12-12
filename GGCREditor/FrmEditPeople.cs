using GGCREditorLib;
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

namespace GGCREditor
{
    public partial class FrmEditPeople : Form
    {
        private FrmEditPeople(string file)
        {
            InitializeComponent();
            tslblFIle.Text = file;
            masterFile = new MasterFile(file);

        }

        public static FrmEditPeople CreateForm(string file)
        {
            if (form == null)
            {
                form = new FrmEditPeople(file);
            }
            return form;
        }

        private static FrmEditPeople form;

        MasterFile masterFile = null;
        List<MasterSkill> skills1 = new List<MasterSkill>();
        List<MasterSkill> skills2 = new List<MasterSkill>();
        List<MasterSkill> skills3 = new List<MasterSkill>();
        List<MasterInfo> masters = new List<MasterInfo>();

        private void LoadData(MasterInfo master)
        {
            if (master != null)
            {
                txtId.Text = master.ID.ToString();
                txtUnKnow.Text = master.Unknow.ToString();
                txtName.Text = master.MasterName;
                txtAddress.Text = ByteHelper.ByteArrayToHexString(ByteHelper.Int2Bytes(master.Index));
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
                txtChenZhang.Text = master.ChengZhang.ToString();

                cboGuYou1.SelectedValue = master.GuYou1;
                cboGuYou2.SelectedValue = master.GuYou2;
                cboGuYou3.SelectedValue = master.GuYou3;

                txtLast4.Text = master.Last4.ToString();

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
                txtChenZhang.Text = null;

                cboGuYou1.SelectedValue = -1;
                cboGuYou2.SelectedValue = -1;
                cboGuYou3.SelectedValue = -1;

                txtLast4.Text = null;

                btnSave.Enabled = false;
            }
        }

        private void Clean()
        {

        }

        private void FrmEditPeople_Load(object sender, EventArgs e)
        {
            //读取姓名数据 00002cc0
            byte[] data = File.ReadAllBytes(GGCRStaticConfig.PATH + "\\language\\schinese\\CharacterSpecList.tbl");
            int idx = ByteHelper.FindFirstIndex(data, "2F 9F 00 00 00 00 00 00 00 00 00 00 00 00 00 00", 0) + 16;

            string[] names = Encoding.UTF8.GetString(data, idx, data.Length - idx).Split('\0');

            using (StreamReader sr = new StreamReader("固有技能.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        MasterSkill skill = new MasterSkill() { SkillId = Convert.ToInt16(arr[0]), SkillName = arr[1] };
                        skills1.Add(skill);
                        skills2.Add(skill);
                        skills3.Add(skill);
                    }
                }
            }

            cboGuYou1.DataSource = skills1;
            cboGuYou1.ValueMember = "SkillId";
            cboGuYou1.DisplayMember = "SkillName";

            cboGuYou2.DataSource = skills2;
            cboGuYou2.ValueMember = "SkillId";
            cboGuYou2.DisplayMember = "SkillName";

            cboGuYou3.DataSource = skills3;
            cboGuYou3.ValueMember = "SkillId";
            cboGuYou3.DisplayMember = "SkillName";

            Dictionary<string, string> groups = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader("系列代码.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        groups[arr[1]] = arr[0];
                    }
                }
            }

            masters = masterFile.ListMasters();
            foreach (MasterInfo m in masters)
            {
                if (groups.ContainsKey(m.Group.ToString()))
                {
                    m.GroupName = groups[m.Group.ToString()];
                }
                else
                {
                    m.GroupName = "未知系列";
                }

                if (m.ID < 0 || names[m.ID] == null || names[m.ID].Trim().Length == 0)
                {
                    m.MasterName = "未知";
                }
                else
                {
                    m.MasterName = names[m.ID];
                }
            }


            lsMasters.DataSource = masters;
            lsMasters.DisplayMember = "MasterName";
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
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == null || txtSearch.Text == "")
            {
                lsMasters.DataSource = masters;
                lsMasters.DisplayMember = "MasterName";
                lsMasters.SelectedItem = null;
            }
            else
            {
                List<MasterInfo> search = new List<MasterInfo>();
                foreach (MasterInfo m in masters)
                {
                    if (m.MasterName.IndexOf(txtSearch.Text) >= 0)
                    {
                        search.Add(m);
                    }
                }
                lsMasters.DataSource = search;
                lsMasters.DisplayMember = "MasterName";
                lsMasters.SelectedItem = null;
            }
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            MasterInfo master = lsMasters.SelectedItem as MasterInfo;
            if (master != null)
            {
                btnSave.Enabled = false;

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
                master.ChengZhang = short.Parse(txtChenZhang.Text);

                master.GuYou1 = (short)cboGuYou1.SelectedValue;
                master.GuYou2 = (short)cboGuYou2.SelectedValue;
                master.GuYou3 = (short)cboGuYou3.SelectedValue;


                masterFile.Save();
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
                e.Graphics.DrawString(master.GroupName + "-" + master.MasterName, e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
            }
            e.DrawFocusRectangle();
        }

        private void lsMasters_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = e.ItemHeight + 6;
        }

        private void FrmEditPeople_FormClosed(object sender, FormClosedEventArgs e)
        {
            form = null;
        }
    }
}
