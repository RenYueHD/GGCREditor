using GGCREditorLib;
using GGCREditorLib.CDBItem.Ability;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GGCREditor
{
    public partial class FrmEditAbility : Form
    {
        public FrmEditAbility()
        {
            InitializeComponent();
        }

        AbilitySpecFile file;
        List<AbstractAbility> abilitys;
        List<XiaoGuoAbility> xiaoguos;

        private void FrmEditAbility_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            file = new AbilitySpecFile();
            abilitys = file.ListAbilitys();
            xiaoguos = file.ListXiaoGuo();

            tsmiFile.Text = file.FileName;

            cboSkill.DataSource = xiaoguos;
            cboSkill.ValueMember = "SkillId";

            lsAbility.DataSource = abilitys;
        }

        private void lsMasters_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = e.ItemHeight + 16;
        }

        private void lsMasters_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            if (e.Index >= 0)
            {
                AbstractAbility ability = ((ListBox)sender).Items[e.Index] as AbstractAbility;
                StringFormat sStringFormat = new StringFormat();
                sStringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(ability.TypeName + "-" + ability.UnitName, e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
            }
            e.DrawFocusRectangle();
        }

        private void lsAbility_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbstractAbility ability = lsAbility.SelectedItem as AbstractAbility;
            if (ability != null)
            {
                cboSkill.SelectedValue = ability.SkillId;
                XiaoGuoAbility xiaoguo = cboSkill.SelectedItem as XiaoGuoAbility;

                if (ability is XiaoGuoAbility)
                {
                    cboSkill.Enabled = false;
                    txtRemarkId.Enabled = true;
                    txtName.Text = ability.UnitName;
                    txtName.ReadOnly = true;
                }
                else
                {
                    cboSkill.Enabled = true;
                    txtRemarkId.Enabled = false;
                    txtName.Text = ability.UnitName;
                    txtName.ReadOnly = false;
                }

                txtAddress.Text = ability.Address;

                if (ability is XiaoGuoAbility)
                {
                    btnCopy.Enabled = true;
                }
                else
                {
                    btnCopy.Enabled = false;
                }
            }
            else
            {
                cboSkill.SelectedValue = "-1";
                btnCopy.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lsAbility.SelectedItem = null;
            if (txtSearch.Text == null || txtSearch.Text == "")
            {
                lsAbility.DataSource = abilitys;
            }
            else
            {
                List<AbstractAbility> search = new List<AbstractAbility>();
                foreach (AbstractAbility m in abilitys)
                {
                    if ((m.TypeName + "-" + m.UnitName).ToUpper().IndexOf(txtSearch.Text.ToUpper()) >= 0 || m is XiaoGuoAbility && (m as XiaoGuoAbility).RemarkDetail != null && (m as XiaoGuoAbility).RemarkDetail.ToUpper().IndexOf(txtSearch.Text.ToUpper()) >= 0)
                    {
                        search.Add(m);
                    }
                }
                lsAbility.DataSource = search;
            }
        }

        private void cboSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSkill(cboSkill.SelectedItem as XiaoGuoAbility);
        }

        private void loadSkill(XiaoGuoAbility xiaoguo)
        {
            if (xiaoguo != null)
            {
                //   txtXiaoGuoRemark.Text = xiaoguo.RemarkDetail.Replace("\n", "\r\n");
                txtRemarkId.Text = xiaoguo.RemarkId.ToString();

                changePanel(true);

                txtHP.Text = xiaoguo.MachHP.ToString();
                txtPowerGeDou.Text = xiaoguo.PowerGeDou.ToString();
                txtEN.Text = xiaoguo.MachEN.ToString();
                txtPowerWuLi.Text = xiaoguo.PowerWuLi.ToString();
                txtMachAct.Text = xiaoguo.MachACT.ToString();
                txtPowerBean.Text = xiaoguo.PowerBean.ToString();
                txtMachDef.Text = xiaoguo.MachDEF.ToString();
                txtPowerMap.Text = xiaoguo.PowerMap.ToString();
                txtMachSpd.Text = xiaoguo.MachSPD.ToString();
                txtPowerZhanJianUnion.Text = xiaoguo.PowerZhanJianUnion.ToString();
                txtPowerSheJi.Text = xiaoguo.PowerSheJi.ToString();
                txtPowerXiaoDuiUnion.Text = xiaoguo.PowerYouJiUnion.ToString();
                txtPerSheJi.Text = xiaoguo.PeoSheJi.ToString();
                txtPerShouBei.Text = xiaoguo.PeoShouBei.ToString();
                txtPerGedou.Text = xiaoguo.PeoGeDou.ToString();
                txtPerCaoDuo.Text = xiaoguo.PeoCaoDuo.ToString();
                txtPerFanYin.Text = xiaoguo.PeoFanYin.ToString();
                txtPerZhiHui.Text = xiaoguo.PeoZhiHui.ToString();
                txtPerJueXin.Text = xiaoguo.PeoJueXin.ToString();
                txtPerTongXun.Text = xiaoguo.PeoTongXun.ToString();
                txtPerFuZuo.Text = xiaoguo.PeoFuZuo.ToString();
                txtPerWeiXiu.Text = xiaoguo.PeoWeiXiu.ToString();
                txtPerMeiLi.Text = xiaoguo.PeoMeiLi.ToString();
                txtPerZhanYi.Text = xiaoguo.PeoZhanYiMP.ToString();
                txtHPRec.Text = xiaoguo.MachHPRec.ToString();
                txtENRec.Text = xiaoguo.MachENRec.ToString();
                txtShiXin1.Text = xiaoguo.ShiYin1.ToString();
                txtShiXin2.Text = xiaoguo.ShiYin2.ToString();
                txtShiXin3.Text = xiaoguo.ShiYin3.ToString();
                txtShiXin4.Text = xiaoguo.ShiYin4.ToString();
                txtShiXin5.Text = xiaoguo.ShiYin5.ToString();
                txtDmgWuLiGeDou.Text = xiaoguo.DmgWuLiGeDou.ToString();
                txtDmgWuLiSheJi.Text = xiaoguo.DmgWuLiSheJi.ToString();
                txtDmgBeanSheJi.Text = xiaoguo.DmgBeanSheJi.ToString();
                txtDmgBeanGeDou.Text = xiaoguo.DmgBeanGeDou.ToString();
                txtDmgUnknow35.Text = xiaoguo.DmgTeShuSheJi.ToString();
                txtDmgUnknow36.Text = xiaoguo.DmgTeShuGeDou.ToString();
                txtDmgMap.Text = xiaoguo.DmgMap.ToString();
                txtWuXiaoWuLiGeDou.Text = xiaoguo.WuXiaoWuLiGeDou.ToString();
                txtWuXiaoWuLiSheJi.Text = xiaoguo.WuXiaoWuLiSheJi.ToString();
                txtWuXiaoBeanSheJi.Text = xiaoguo.WuXiaoBeanSheJi.ToString();
                txtWuXiaoBeanGeDou.Text = xiaoguo.WuXiaoBeanGeDou.ToString();
                txtWuXiaoUnknow42.Text = xiaoguo.WuXiaoTeShuSheJi.ToString();
                txtWuXiaoUnKnow43.Text = xiaoguo.WuXiaoTeShuGeDou.ToString();
                txtWuXiaoMap.Text = xiaoguo.WuXiaoMap.ToString();
                txtShangHaiFinal.Text = xiaoguo.ShangHaiFinal.ToString();
                txtShangHaiFinalSelf.Text = xiaoguo.ShangHaiFinalSelf.ToString();
                txtUnknow47.Text = xiaoguo.UnKnow47.ToString();
                txtUnknow48.Text = xiaoguo.UnKnow48.ToString();
                txtUnknow49.Text = xiaoguo.UnKnow49.ToString();
                txtUnknow50.Text = xiaoguo.UnKnow50.ToString();
                txtMove.Text = xiaoguo.Mov.ToString();
                txtJinYan.Text = xiaoguo.JinYan.ToString();
                txtJiFen.Text = xiaoguo.JiFen.ToString();
                txtJinE.Text = xiaoguo.Money.ToString();
                txtSheChenSheJi.Text = xiaoguo.SheChenSheJi.ToString();
                txtSheChenGeDou.Text = xiaoguo.SheChenGeDou.ToString();
                txtSheChenWuLi.Text = xiaoguo.SheChenWuLi.ToString();
                txtSheChenBean.Text = xiaoguo.SheChenBean.ToString();
                txtSheChenMap.Text = xiaoguo.SheChenMap.ToString();
                txtENXiaoHaoSheJi.Text = xiaoguo.XiaoHaoEnSheJi.ToString();
                txtENXiaoHaoGeDou.Text = xiaoguo.XiaoHaoEnGeDou.ToString();
                txtENXiaoHaoWuLi.Text = xiaoguo.XiaoHaoEnWuLi.ToString();
                txtENXiaoHaoBean.Text = xiaoguo.XiaoHaoEnBean.ToString();
                txtENXiaoHaoMap.Text = xiaoguo.XiaoHaoEnMap.ToString();
                txtXiaoHaoMP.Text = xiaoguo.XiaoHaoMP.ToString();
                txtBaoJiSheJi.Text = xiaoguo.BaoJiSheJi.ToString();
                txtBaoJiGeDou.Text = xiaoguo.BaoJiGeDou.ToString();
                txtBaoJiWuLI.Text = xiaoguo.BaoJiWuLi.ToString();
                txtBaoJiBean.Text = xiaoguo.BaoJiBean.ToString();
                txtBaoJiUnKnow72.Text = xiaoguo.BaoJiUnKnow.ToString();
                txtMinZhong.Text = xiaoguo.MinZhong.ToString();
                txtShanBi.Text = xiaoguo.ShanBi.ToString();
                txtUnKnow75.Text = xiaoguo.UnKnow75.ToString();
                txtPerEWaiXinDong.Text = xiaoguo.EWaiXinDong.ToString();
                txtAreaZhiHui.Text = xiaoguo.AreaZhiHui.ToString();
                txtAreaUnknow78.Text = xiaoguo.UnKnow78.ToString();
                txtAreaJiNen.Text = xiaoguo.AreaJiNen.ToString();
                txtUnknow80.Text = xiaoguo.UnKnow80.ToString();


            }
            else
            {
                txtXiaoGuoRemark.Text = null;

                changePanel(false);
            }


            tsmiState.Text = "等待修改";
            tsmiState.ForeColor = Color.Black;
        }


        private void changePanel(bool enable)
        {
            foreach (Control c in pan1.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = null;
                }
                c.Enabled = enable;
            }
            foreach (Control c in pan2.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = null;
                }
                c.Enabled = enable;
            }
            foreach (Control c in pan3.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = null;
                }
                c.Enabled = enable;
            }
            foreach (Control c in pan4.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = null;
                }
                c.Enabled = enable;
            }
        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                if (txt.Text != "0")
                {
                    txt.BackColor = Color.Yellow;
                }
                else
                {
                    txt.BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //取当前选中的技能
            XiaoGuoAbility xiaoguo = cboSkill.SelectedItem as XiaoGuoAbility;
            AbstractAbility ability = lsAbility.SelectedItem as AbstractAbility;
            if (xiaoguo != null && ability != null)
            {
                //将ability的技能编号改为现有
                if (!(ability is XiaoGuoAbility))
                {
                    ability.SkillId = xiaoguo.SkillId;
                    if (ability.UnitName != txtName.Text)
                    {
                        ability.SetUnitName(txtName.Text);
                    }
                    //保存技能编号
                    ability.Save();
                }

                xiaoguo.MachHP = short.Parse(txtHP.Text);
                xiaoguo.PowerGeDou = short.Parse(txtPowerGeDou.Text);
                xiaoguo.MachEN = short.Parse(txtEN.Text);
                xiaoguo.PowerWuLi = short.Parse(txtPowerWuLi.Text);
                xiaoguo.MachACT = short.Parse(txtMachAct.Text);

                xiaoguo.PowerBean = short.Parse(txtPowerBean.Text);
                xiaoguo.MachDEF = short.Parse(txtMachDef.Text);
                xiaoguo.PowerMap = short.Parse(txtPowerMap.Text);
                xiaoguo.MachSPD = short.Parse(txtMachSpd.Text);
                xiaoguo.PowerZhanJianUnion = short.Parse(txtPowerZhanJianUnion.Text);
                xiaoguo.PowerSheJi = short.Parse(txtPowerSheJi.Text);
                xiaoguo.PowerYouJiUnion = short.Parse(txtPowerXiaoDuiUnion.Text);
                xiaoguo.PeoSheJi = short.Parse(txtPerSheJi.Text);
                xiaoguo.PeoShouBei = short.Parse(txtPerShouBei.Text);
                xiaoguo.PeoGeDou = short.Parse(txtPerGedou.Text);
                xiaoguo.PeoCaoDuo = short.Parse(txtPerCaoDuo.Text);
                xiaoguo.PeoFanYin = short.Parse(txtPerFanYin.Text);
                xiaoguo.PeoZhiHui = short.Parse(txtPerZhiHui.Text);
                xiaoguo.PeoJueXin = short.Parse(txtPerJueXin.Text);
                xiaoguo.PeoTongXun = short.Parse(txtPerTongXun.Text);
                xiaoguo.PeoFuZuo = short.Parse(txtPerFuZuo.Text);
                xiaoguo.PeoWeiXiu = short.Parse(txtPerWeiXiu.Text);
                xiaoguo.PeoMeiLi = short.Parse(txtPerMeiLi.Text);
                xiaoguo.PeoZhanYiMP = short.Parse(txtPerZhanYi.Text);
                xiaoguo.MachHPRec = short.Parse(txtHPRec.Text);
                xiaoguo.MachENRec = short.Parse(txtENRec.Text);
                xiaoguo.ShiYin1 = byte.Parse(txtShiXin1.Text);
                xiaoguo.ShiYin2 = byte.Parse(txtShiXin2.Text);
                xiaoguo.ShiYin3 = byte.Parse(txtShiXin3.Text);
                xiaoguo.ShiYin4 = byte.Parse(txtShiXin4.Text);
                xiaoguo.ShiYin5 = byte.Parse(txtShiXin5.Text);
                xiaoguo.DmgWuLiGeDou = short.Parse(txtDmgWuLiGeDou.Text);
                xiaoguo.DmgWuLiSheJi = short.Parse(txtDmgWuLiSheJi.Text);
                xiaoguo.DmgBeanSheJi = short.Parse(txtDmgBeanSheJi.Text);
                xiaoguo.DmgBeanGeDou = short.Parse(txtDmgBeanGeDou.Text);
                xiaoguo.DmgTeShuSheJi = short.Parse(txtDmgUnknow35.Text);
                xiaoguo.DmgTeShuGeDou = short.Parse(txtDmgUnknow36.Text);
                xiaoguo.DmgMap = short.Parse(txtDmgMap.Text);
                xiaoguo.WuXiaoWuLiGeDou = short.Parse(txtWuXiaoWuLiGeDou.Text);
                xiaoguo.WuXiaoWuLiSheJi = short.Parse(txtWuXiaoWuLiSheJi.Text);
                xiaoguo.WuXiaoBeanSheJi = short.Parse(txtWuXiaoBeanSheJi.Text);
                xiaoguo.WuXiaoBeanGeDou = short.Parse(txtWuXiaoBeanGeDou.Text);
                xiaoguo.WuXiaoTeShuSheJi = short.Parse(txtWuXiaoUnknow42.Text);
                xiaoguo.WuXiaoTeShuGeDou = short.Parse(txtWuXiaoUnKnow43.Text);
                xiaoguo.WuXiaoMap = short.Parse(txtWuXiaoMap.Text);
                xiaoguo.ShangHaiFinal = short.Parse(txtShangHaiFinal.Text);
                xiaoguo.ShangHaiFinalSelf = short.Parse(txtShangHaiFinalSelf.Text);
                xiaoguo.UnKnow47 = short.Parse(txtUnknow47.Text);
                xiaoguo.UnKnow48 = short.Parse(txtUnknow48.Text);
                xiaoguo.UnKnow49 = short.Parse(txtUnknow49.Text);
                xiaoguo.UnKnow50 = short.Parse(txtUnknow50.Text);
                xiaoguo.Mov = byte.Parse(txtMove.Text);
                xiaoguo.JinYan = short.Parse(txtJinYan.Text);
                xiaoguo.JiFen = short.Parse(txtJiFen.Text);
                xiaoguo.Money = short.Parse(txtJinE.Text);
                xiaoguo.SheChenSheJi = byte.Parse(txtSheChenSheJi.Text);
                xiaoguo.SheChenGeDou = byte.Parse(txtSheChenGeDou.Text);
                xiaoguo.SheChenWuLi = byte.Parse(txtSheChenWuLi.Text);
                xiaoguo.SheChenBean = byte.Parse(txtSheChenBean.Text);
                xiaoguo.SheChenMap = byte.Parse(txtSheChenMap.Text);
                xiaoguo.XiaoHaoEnSheJi = byte.Parse(txtENXiaoHaoSheJi.Text);
                xiaoguo.XiaoHaoEnGeDou = byte.Parse(txtENXiaoHaoGeDou.Text);
                xiaoguo.XiaoHaoEnWuLi = byte.Parse(txtENXiaoHaoWuLi.Text);
                xiaoguo.XiaoHaoEnBean = byte.Parse(txtENXiaoHaoBean.Text);
                xiaoguo.XiaoHaoEnMap = byte.Parse(txtENXiaoHaoMap.Text);
                xiaoguo.XiaoHaoMP = byte.Parse(txtXiaoHaoMP.Text);
                xiaoguo.BaoJiSheJi = byte.Parse(txtBaoJiSheJi.Text);
                xiaoguo.BaoJiGeDou = byte.Parse(txtBaoJiGeDou.Text);
                xiaoguo.BaoJiWuLi = byte.Parse(txtBaoJiWuLI.Text);
                xiaoguo.BaoJiBean = byte.Parse(txtBaoJiBean.Text);
                xiaoguo.BaoJiUnKnow = byte.Parse(txtBaoJiUnKnow72.Text);
                xiaoguo.MinZhong = byte.Parse(txtMinZhong.Text);
                xiaoguo.ShanBi = byte.Parse(txtShanBi.Text);
                xiaoguo.UnKnow75 = byte.Parse(txtUnKnow75.Text);
                xiaoguo.EWaiXinDong = byte.Parse(txtPerEWaiXinDong.Text);
                xiaoguo.AreaZhiHui = byte.Parse(txtAreaZhiHui.Text);
                xiaoguo.UnKnow78 = byte.Parse(txtAreaUnknow78.Text);
                xiaoguo.AreaJiNen = byte.Parse(txtAreaJiNen.Text);

                xiaoguo.UnKnow80 = short.Parse(txtUnknow80.Text);

                xiaoguo.RemarkId = short.Parse(txtRemarkId.Text);

                //写技能文本
                if (txtXiaoGuoRemark.Enabled && txtXiaoGuoRemark.Text.Replace("\r\n", "\n") != xiaoguo.RemarkDetail)
                {
                    xiaoguo.RemarkDetail = txtXiaoGuoRemark.Text.Replace("\r\n", "\n");
                }

                xiaoguo.Save();

                tsmiState.Text = "写入成功";
                tsmiState.ForeColor = Color.Green;
            }
            else
            {
                tsmiState.Text = "保存失败,请选择技能";
                tsmiState.ForeColor = Color.Red;
            }
        }

        private void cboSkill_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            if (e.Index >= 0)
            {
                XiaoGuoAbility ability = ((ComboBox)sender).Items[e.Index] as XiaoGuoAbility;
                StringFormat sStringFormat = new StringFormat();
                sStringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("技能效果" + ability.SkillId, e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
            }
            e.DrawFocusRectangle();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {

            //  file.CreateNewXiaoGuo();

            reload();

            lsAbility.SelectedItem = abilitys[abilitys.Count - 1];

            MessageBox.Show("创建成功,请修改数据", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtRemarkId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (file.AbilityText.Count > int.Parse(txtRemarkId.Text))
                {
                    txtXiaoGuoRemark.Text = file.AbilityText[int.Parse(txtRemarkId.Text)].Replace("\n", "\r\n");
                    txtXiaoGuoRemark.Enabled = true;
                }
                else
                {
                    txtXiaoGuoRemark.Text = null;
                    txtXiaoGuoRemark.Enabled = false;
                }
            }
            catch
            {
                txtXiaoGuoRemark.Text = null;
                txtXiaoGuoRemark.Enabled = false;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            AbstractAbility ability = lsAbility.SelectedItem as AbstractAbility;
            if (ability != null)
            {
                file.CopyAndCreate(ability);

                reload();

                lsAbility.SelectedItem = abilitys[abilitys.Count - 1];

                MessageBox.Show("创建成功,请修改数据", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
