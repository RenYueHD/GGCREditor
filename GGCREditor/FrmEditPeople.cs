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
        private FrmEditPeople()
        {
            InitializeComponent();
            masterFile = new MasterFile();
            tslblFIle.Text = masterFile.FileName;
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

        MasterFile masterFile = null;
        List<MasterInfo> masters = new List<MasterInfo>();

        private void bindAll()
        {
            cboGuYou1.DataSource = GGCRUtil.ListPeopleSkill();
            cboGuYou1.ValueMember = "Key";
            cboGuYou1.DisplayMember = "Value";

            cboGuYou2.DataSource = GGCRUtil.ListPeopleSkill();
            cboGuYou2.ValueMember = "Key";
            cboGuYou2.DisplayMember = "Value";

            cboGuYou3.DataSource = GGCRUtil.ListPeopleSkill();
            cboGuYou3.ValueMember = "Key";
            cboGuYou3.DisplayMember = "Value";
        }

        private void FrmEditPeople_Load(object sender, EventArgs e)
        {
            bindAll();

            masters = masterFile.ListMasters();

            lsMasters.DataSource = masters;
            lsMasters.DisplayMember = "MasterName";
        }


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
                lsMasters.DisplayMember = "MasterName";
                lsMasters.SelectedItem = null;
            }
            else
            {
                List<MasterInfo> search = new List<MasterInfo>();
                foreach (MasterInfo m in masters)
                {
                    if ((m.GroupName + "-" + m.MasterName).IndexOf(txtSearch.Text) >= 0)
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

                master.Last4 = short.Parse(txtLast4.Text);

                master.Save();

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
                e.Graphics.DrawString(master.GroupName + "-" + master.MasterName, e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
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
    }
}
