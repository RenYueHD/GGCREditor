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

            int line = 1;

            for (int i = skip; i < data.Length; i++)
            {
                if (i == skip)
                {
                    sb.Append(0.ToString().PadLeft(4, '0').PadRight(5, ' '));
                    sb.Append("00000000");
                    sb.Append("h: ");

                    for (int j = 0; j < count; j++)
                    {
                        sb.Append(j.ToString().PadLeft(2, '0').PadRight(3, ' ').ToUpper());
                    }
                    string hex = ByteArrayToHexString(Int2Bytes(skip));
                    sb.AppendLine();
                    sb.Append(line.ToString().PadLeft(4, '0').PadRight(5, ' '));
                    sb.Append(hex);
                    sb.Append("h: ");
                }

                sb.Append(Convert.ToString(data[i], 16).PadLeft(2, '0').PadRight(3, ' ').ToUpper());

                if (i - skip != 0 && (i - skip + 1) % count == 0)
                {
                    sb.AppendLine();
                    line++;
                    sb.Append(line.ToString().PadLeft(4, '0').PadRight(5, ' '));

                    string hex = ByteArrayToHexString(Int2Bytes(i + 1));

                    sb.Append(hex);
                    sb.Append("h: ");

                }

            }

            txtData.Text = sb.ToString();
        }


        public string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
            {
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            }

            return sb.ToString().ToUpper();
        }

        public byte[] Int2Bytes(int i)
        {
            byte[] result = new byte[4];
            result[0] = (byte)((i >> 24) & 0xFF);
            result[1] = (byte)((i >> 16) & 0xFF);
            result[2] = (byte)((i >> 8) & 0xFF);
            result[3] = (byte)(i & 0xFF);
            return result;
        }
    }
}
