using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    public class GGCRTblFile : GGCRResourceFile
    {
        //首个字符位置
        private int CharStart;
        public GGCRTblFile(string file) : base(file)
        {
            this.CharStart = BitConverter.ToInt32(this.Data, 16);

        }

        public List<string> ListAllText()
        {
            List<int> addresses = new List<int>();

            //跳过头,读取数据
            for (int i = 16; i <= this.CharStart - 8; i += 8)
            {
                //读取地址位
                int address = BitConverter.ToInt32(this.Data, i);
                //读取地址后跟着的位数
                int last = BitConverter.ToInt32(this.Data, i + 4);
                //非0则为地址位,否则为填充位
                if (address != 0)
                {
                    addresses.Add(address);
                }
            }

            List<string> strs = new List<string>();
            for (int i = 0; i < addresses.Count; i++)
            {
                string str = null;
                if (i == addresses.Count - 1)
                {
                    str = Encoding.UTF8.GetString(this.Data, addresses[i], this.Data.Length - addresses[i] - 1);
                }
                else
                {
                    str = Encoding.UTF8.GetString(this.Data, addresses[i], addresses[i + 1] - addresses[i] - 1);
                }
                strs.Add(str);
            }

            return strs;
        }

        public void Save(List<string> list)
        {
            //计算地址偏移
            int addressSpan = this.CharStart;

            MemoryStream all = new MemoryStream();
            all.Write(this.Data, 0, CharStart);

            int allStart = 16;

            MemoryStream ms = new MemoryStream();
            foreach (string s in list)
            {
                byte[] add = BitConverter.GetBytes(addressSpan);
                all.Position = allStart;
                all.Write(add, 0, 4);

                byte[] b = Encoding.UTF8.GetBytes(s);
                ms.Write(b, 0, b.Length);
                ms.WriteByte(0);

                addressSpan += b.Length + 1;
                allStart += 8;
            }

            if (list.Count % 2 != 0)
            {
                all.WriteByte(0);
                all.WriteByte(0);
                all.WriteByte(0);
                all.WriteByte(0);
                all.WriteByte(0);
                all.WriteByte(0);
                all.WriteByte(0);
                all.WriteByte(0);
            }

            using (FileStream fs = new FileStream(this.FileName, FileMode.Create, FileAccess.Write))
            {
                all.WriteTo(fs);
                ms.WriteTo(fs);
                fs.Flush();
            }
        }
    }
}
