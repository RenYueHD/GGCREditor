﻿using GGCREditorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace GGCREditor
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private string currentDir = null;

        private void 选择路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请设置火线纵横data文件夹所在目录";
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings["path"] != null)
            {
                dialog.SelectedPath = config.AppSettings.Settings["path"].Value;
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!dialog.SelectedPath.EndsWith("data"))
                {
                    MessageBox.Show("请选择[火线纵横]的data文件夹", "目录无效", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (config.AppSettings.Settings["path"] == null)
                    {
                        config.AppSettings.Settings.Add("path", null);
                    }
                    config.AppSettings.Settings["path"].Value = dialog.SelectedPath;
                    config.Save();

                    this.currentDir = dialog.SelectedPath;
                    GGCRStaticConfig.PATH = this.currentDir;
                    enableAll();
                    tslblDir.Text = this.currentDir;
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            FrmEditPeople form = FrmEditPeople.CreateForm();
            form.Show();
            form.BringToFront();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings["path"] != null)
            {
                this.currentDir = config.AppSettings.Settings["path"].Value;
                tslblDir.Text = this.currentDir;
                GGCRStaticConfig.PATH = this.currentDir;
                enableAll();
            }

        }

        private void enableAll()
        {
            flowContainer.Enabled = true;

        }

        private void btnEditGundam_Click(object sender, EventArgs e)
        {
            new FrmEditGundam().ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmEditWeapon form = new FrmEditWeapon();
            form.ShowDialog();
        }

        private void btnEditText_Click(object sender, EventArgs e)
        {
            FrmEditText form = new FrmEditText(GGCRStaticConfig.PATH + @"\language\schinese\CharacterSpecList.tbl");
            form.ShowDialog();
        }

        private void btnEditMachineTxt_Click(object sender, EventArgs e)
        {
            FrmEditText form = new FrmEditText(GGCRStaticConfig.PATH + @"\language\schinese\MachineSpecList.tbl");
            form.ShowDialog();
        }

        private void btnEditMachineDesc_Click(object sender, EventArgs e)
        {
            FrmEditText form = new FrmEditText(GGCRStaticConfig.PATH + @"\language\schinese\SpecProfileList.tbl");
            form.ShowDialog();
        }

        private void btnEditAbility_Click(object sender, EventArgs e)
        {
            FrmEditText form = new FrmEditText(GGCRStaticConfig.PATH + @"\language\schinese\AbilitySpecList.tbl");
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "TBL文件|*.tbl";
            dialog.InitialDirectory = GGCRStaticConfig.PATH;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FrmEditText form = new FrmEditText(dialog.FileName);
                form.ShowDialog();
            }
        }
    }
}
