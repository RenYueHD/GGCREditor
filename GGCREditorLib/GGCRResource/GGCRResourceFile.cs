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
    }
}
