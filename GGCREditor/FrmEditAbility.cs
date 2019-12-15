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
                txtAddress.Text = ability.Address;
                txtIdInGroup.Text = ability.IDInGroup.ToString();
                txtSkillID.Text = ability.SkillId.ToString();

                XiaoGuoAbility xiaoguo = null;
                if (ability is XiaoGuoAbility)
                {
                    xiaoguo = ability as XiaoGuoAbility;
                    txtSkillID.Enabled = false;
                    txtRemarkId.Enabled = true;
                }
                else
                {
                    txtSkillID.Enabled = true;
                    txtRemarkId.Enabled = false;

                    foreach (XiaoGuoAbility x in xiaoguos)
                    {
                        if (x.SkillId == ability.SkillId)
                        {
                            xiaoguo = x;
                            break;
                        }
                    }
                }
                if (xiaoguo != null)
                {
                    txtXiaoGuoRemark.Text = xiaoguo.RemarkDetail;
                    txtRemarkId.Text = xiaoguo.RemarkId.ToString();

                }


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
    }
}
