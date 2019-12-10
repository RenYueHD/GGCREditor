﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
                    enableAll();
                    lblPath.Text = this.currentDir;
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string url = this.currentDir + "\\resident\\CharacterSpecList.pkd";
            FrmEditPeople form = FrmEditPeople.CreateForm(url);
            form.Show();
            form.BringToFront();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings["path"] != null)
            {
                this.currentDir = config.AppSettings.Settings["path"].Value;
                lblPath.Text = this.currentDir;
                enableAll();
            }
        }

        private void enableAll()
        {
            btnEditMaster.Enabled = true;
            btnEditGundam.Enabled = true;
            btnSearch.Enabled = true;
        }

        private void btnEditGundam_Click(object sender, EventArgs e)
        {
            string url = this.currentDir + "\\resident\\MachineSpecList.pkd";

            new FrmEditGundam(url).ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string url = this.currentDir + "\\resident\\MachineSpecList.pkd";

            FrmSearchGundam form = FrmSearchGundam.CreateForm(url);
            form.Show();
            form.BringToFront();
        }
    }
}
