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

        /// <summary>
        /// 保存文件
        /// </summary>
        internal void Write(int index, byte[] data)
        {
            using (FileStream fs = new FileStream(this.FileName, FileMode.Open, FileAccess.Write))
            {
                fs.Position = index;
                fs.Write(data, 0, data.Length);
                fs.Flush();
            }

            this.data = File.ReadAllBytes(FileName);
        }
    }
}
