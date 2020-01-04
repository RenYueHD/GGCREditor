using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    public class GGCRResourceFile
    {
        public GGCRResourceFile(string file)
        {
            this.FileName = file;
            this.data = File.ReadAllBytes(file);
        }

        private byte[] data;
        internal byte[] Data { get { return data; } }
        public string FileName { get; }

        public virtual void Reload()
        {
            this.data = File.ReadAllBytes(FileName);
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        internal void Write(int index, byte[] dt)
        {
            using (FileStream fs = new FileStream(this.FileName, FileMode.Open, FileAccess.Write))
            {
                fs.Position = index;
                fs.Write(dt, 0, dt.Length);
                fs.Flush();
            }
            if (this.data.Length < index + dt.Length)
            {
                this.data = File.ReadAllBytes(FileName);
            }
            else
            {
                for (int i = 0; i < dt.Length; i++)
                {
                    this.data[index + i] = dt[i];
                }
            }
        }

        internal void Insert(int index, byte[] dt)
        {
            byte[] newData = new byte[this.Data.Length + dt.Length];
            Array.Copy(this.Data, 0, newData, 0, index);
            Array.Copy(dt, 0, newData, index, dt.Length);
            Array.Copy(this.Data, index, newData, index + dt.Length, this.data.Length - index);

            using (FileStream fs = new FileStream(this.FileName, FileMode.Truncate, FileAccess.Write))
            {
                fs.Write(newData, 0, newData.Length);
                fs.Flush();
            }
            this.Reload();
        }

        internal void Delete(int index, int count)
        {
            byte[] newData = new byte[this.Data.Length - count];
            Array.Copy(this.Data, 0, newData, 0, index);
            Array.Copy(this.Data, index + count, newData, index, this.data.Length - index - count);

            using (FileStream fs = new FileStream(this.FileName, FileMode.Truncate, FileAccess.Write))
            {
                fs.Write(newData, 0, newData.Length);
                fs.Flush();
            }
            this.Reload();
        }
    }
}
