using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    public class GGCRTblFile : GGCRResourceFile
    {
        private int count;
        public int Count { get { return count; } }
        //首个字符位置
        private int CharStart;
        private List<string> texts;
        private bool simple;
        public bool Simple { get; }
        public GGCRTblFile(string file) : base(file)
        {
            load();
        }

        private void load()
        {
            this.CharStart = BitConverter.ToInt32(this.Data, 16);
            this.count = BitConverter.ToInt32(this.Data, 8);
            this.simple = true;

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
                    if (last != 0)
                    {
                        this.simple = false;
                    }
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
            texts = strs;
        }

        public override void Reload()
        {
            base.Reload();
            load();
        }

        public List<string> ListAllText()
        {
            return texts;
        }

        public void Save(List<string> list)
        {
            if (list.Count == this.Count)
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

                Reload();
            }
            else
            if (simple)
            {

                //计算地址偏移
                int newcharStart = 16 + list.Count * 8;
                if (list.Count % 2 != 0)
                {
                    newcharStart += 8;
                }

                MemoryStream head = new MemoryStream();
                head.Write(this.Data, 0, 16);
                head.Position = 8;
                head.Write(BitConverter.GetBytes(list.Count), 0, 4);
                head.Position = 16;

                MemoryStream ms = new MemoryStream();
                foreach (string s in list)
                {
                    byte[] add = BitConverter.GetBytes(newcharStart);
                    head.Write(add, 0, 4);
                    head.WriteByte(0);
                    head.WriteByte(0);
                    head.WriteByte(0);
                    head.WriteByte(0);

                    byte[] b = Encoding.UTF8.GetBytes(s);
                    ms.Write(b, 0, b.Length);
                    ms.WriteByte(0);

                    newcharStart += b.Length + 1;
                }

                if (list.Count % 2 != 0)
                {
                    head.WriteByte(0);
                    head.WriteByte(0);
                    head.WriteByte(0);
                    head.WriteByte(0);
                    head.WriteByte(0);
                    head.WriteByte(0);
                    head.WriteByte(0);
                    head.WriteByte(0);
                }

                using (FileStream fs = new FileStream(this.FileName, FileMode.Create, FileAccess.Write))
                {
                    head.WriteTo(fs);
                    ms.WriteTo(fs);
                    fs.Flush();
                }

                Reload();
            }
            else
            {
                throw new Exception("此文本不自持添加数据");
            }
        }
    }
}
