using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PkdAnalysis
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            byte[] data = File.ReadAllBytes(txtFile.Text);

            int skip = int.Parse(txtSkip.Text);
            int count = int.Parse(txtLine.Text);

            for (int i = skip; i < data.Length; i++)
            {
                sb.Append(Convert.ToString(data[i], 16).PadLeft(2, '0').PadRight(3, ' '));

                if (i - skip != 0 && (i - skip + 1) % count == 0)
                {
                    sb.AppendLine();
                }

            }

            txtData.Text = sb.ToString().ToUpper();
        }
    }
}
