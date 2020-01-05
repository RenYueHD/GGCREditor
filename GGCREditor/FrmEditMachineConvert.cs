using GGCREditorLib;
using GGCREditorLib.CDBItem;
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
    public partial class FrmEditMachineConvert : Form
    {
        private GundamFile gundamFile;
        private GundamInfo gundam;

        private string fromUuid;

        private List<MachineConvertInfo> converts;
        private List<GundamInfo> gundams;
        List<KeyValuePair<string, string>> actions;

        BindingSource fromSource = new BindingSource();
        BindingSource toSource = new BindingSource();

        public FrmEditMachineConvert(string fromUuid)
        {
            InitializeComponent();

            this.fromUuid = fromUuid;
        }


        private void FrmEditMachineConvert_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            this.gundamFile = new GundamFile();
            stFile.Text = this.gundamFile.FileName;


            List<MachineConvertInfo> allConverts = gundamFile.ListConvert();

            this.actions = GGCRUtil.ListConvertAction();

            foreach (MachineConvertInfo c in allConverts)
            {
                bool find = false;
                foreach (KeyValuePair<string, string> kv in actions)
                {
                    if (kv.Key == c.Action.ToString())
                    {
                        find = true;
                        break;
                    }
                }
                if (!find)
                {
                    GGCRUtil.AddConvertAction(c.Action, "未知" + c.Action);
                    this.actions = GGCRUtil.ListConvertAction();
                }
            }
            cboAction.DataSource = actions;
            cboAction.DisplayMember = "Value";
            cboAction.ValueMember = "Key";

            this.gundams = gundamFile.ListMachines();

            foreach (GundamInfo g in gundams)
            {
                if (g.UUID == this.fromUuid)
                {
                    this.gundam = g;
                    break;
                }
            }

            fromSource.DataSource = this.gundams;

            toSource.DataSource = this.gundams;

            cboTo.DataSource = toSource.DataSource;
            cboTo.ValueMember = "UUID";
            cboTo.DisplayMember = "UnitName";

            cboFrom.DataSource = fromSource;
            cboFrom.ValueMember = "UUID";
            cboFrom.DisplayMember = "UnitName";


            if (this.gundam != null)
            {
                this.converts = new List<MachineConvertInfo>();

                foreach (MachineConvertInfo c in allConverts)
                {
                    if (c.From == gundam.UUID || c.To == gundam.UUID)
                    {
                        this.converts.Add(c);
                    }
                }
            }
            else
            {
                this.converts = allConverts;
            }

            lsMain.DataSource = this.converts;
        }

        private void lsMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            MachineConvertInfo convert = lsMain.SelectedItem as MachineConvertInfo;
            if (convert != null)
            {
                cboAction.SelectedValue = convert.Action.ToString();
                cboFrom.SelectedValue = convert.From;
                cboTo.SelectedValue = convert.To;

                lbState.Text = "等待修改";
                lbState.ForeColor = Color.Black;
            }
            else
            {
                cboAction.SelectedValue = "-1";
                cboFrom.SelectedValue = "-1";
                cboTo.SelectedValue = "-1";
            }
        }

        private void lsMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            if (e.Index >= 0)
            {
                MachineConvertInfo convert = ((ListBox)sender).Items[e.Index] as MachineConvertInfo;
                StringFormat sStringFormat = new StringFormat();
                sStringFormat.LineAlignment = StringAlignment.Center;
                string from = null;
                string to = null;
                foreach (GundamInfo g in this.gundams)
                {
                    if (convert.From == g.UUID)
                    {
                        from = g.UnitName;
                    }
                    if (convert.To == g.UUID)
                    {
                        to = g.UnitName;
                    }
                    if (from != null && to != null)
                    {
                        break;
                    }
                }

                string action = null;
                foreach (KeyValuePair<string, string> a in actions)
                {
                    if (a.Key == convert.Action.ToString())
                    {
                        action = a.Value;
                        break;
                    }
                }

                e.Graphics.DrawString((from ?? "无") + "  ==" + action + "==>  " + (to ?? "无"), e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
            }
            e.DrawFocusRectangle();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gundamFile.AddConvert(cboFrom.SelectedItem as GundamInfo, cboTo.SelectedItem as GundamInfo, int.Parse(cboAction.SelectedValue.ToString()));

            loadData();

            lbState.Text = "添加成功";
            lbState.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MachineConvertInfo convert = lsMain.SelectedItem as MachineConvertInfo;
            int index = lsMain.SelectedIndex;
            if (convert != null && cboFrom.SelectedItem != null && cboTo.SelectedItem as GundamInfo != null)
            {
                convert.From = (cboFrom.SelectedItem as GundamInfo).UUID;
                convert.To = (cboTo.SelectedItem as GundamInfo).UUID;
                convert.Action = int.Parse(cboAction.SelectedValue.ToString());

                convert.Save();

                loadData();
                lsMain.SelectedIndex = index;

                lbState.Text = "保存成功";
                lbState.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("请填写完所有数据", "使用提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lsMain_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = e.ItemHeight + 24;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("此操作无法撤销,确定要删除吗", "使用说明", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MachineConvertInfo convert = lsMain.SelectedItem as MachineConvertInfo;
                int index = lsMain.SelectedIndex;
                if (convert != null)
                {
                    gundamFile.DeleteConvert(convert);

                    loadData();
                    if (lsMain.Items.Count > index)
                    {
                        lsMain.SelectedIndex = index;
                    }
                    else
                    {
                        lsMain.SelectedIndex = -1;

                        cboAction.SelectedValue = "-1";
                        cboFrom.SelectedValue = "-1";
                        cboTo.SelectedValue = "-1";
                    }

                    lbState.Text = "删除成功";
                    lbState.ForeColor = Color.Green;
                }
            }
        }
    }
}
