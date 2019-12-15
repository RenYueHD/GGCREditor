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
            file = new AbilitySpecFile();
            abilitys = file.ListAbilitys();
            xiaoguos = file.ListXiaoGuo();

            tsmiFile.Text = file.FileName;

            lsAbility.DataSource = abilitys;

            cboSkill.DataSource = xiaoguos;
            cboSkill.ValueMember = "SkillId";
            cboSkill.DisplayMember = "SkillId";
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
                }
                else
                {
                    cboSkill.Enabled = true;
                    txtRemarkId.Enabled = false;

                }

                txtAddress.Text = ability.Address;
                txtIdInGroup.Text = ability.IDInGroup.ToString();
            }
            else
            {
                cboSkill.SelectedValue = "-1";
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
                    if ((m.TypeName + "-" + m.UnitName).IndexOf(txtSearch.Text) >= 0 || m is XiaoGuoAbility && (m as XiaoGuoAbility).RemarkDetail.IndexOf(txtSearch.Text) >= 0)
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
                txtXiaoGuoRemark.Text = xiaoguo.RemarkDetail;
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
                txtShiXin5.Text = xiaoguo.ShiYin4.ToString();
                txtDmgWuLiGeDou.Text = xiaoguo.DmgWuLiGeDou.ToString();
                txtDmgWuLiSheJi.Text = xiaoguo.DmgWuLiSheJi.ToString();
                txtDmgBeanSheJi.Text = xiaoguo.DmgBeanSheJi.ToString();
                txtDmgBeanGeDou.Text = xiaoguo.DmgBeanGeDou.ToString();
                txtDmgUnknow35.Text = xiaoguo.DmgUnknow35.ToString();
                txtDmgUnknow36.Text = xiaoguo.DmgUnknow36.ToString();
                txtDmgMap.Text = xiaoguo.DmgMap.ToString();
                txtWuXiaoWuLiGeDou.Text = xiaoguo.WuXiaoWuLiGeDou.ToString();
                txtWuXiaoWuLiSheJi.Text = xiaoguo.WuXiaoWuLiSheJi.ToString();
                txtWuXiaoBeanSheJi.Text = xiaoguo.WuXiaoBeanSheJi.ToString();
                txtWuXiaoBeanGeDou.Text = xiaoguo.WuXiaoBeanGeDou.ToString();
                txtWuXiaoUnknow42.Text = xiaoguo.WuXiaoUnknow42.ToString();
                txtWuXiaoUnKnow43.Text = xiaoguo.WuXiaoUnknow43.ToString();
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
    }
}
