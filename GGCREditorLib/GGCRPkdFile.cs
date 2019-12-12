using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    public abstract class GGCRPkdFile
    {

        public GGCRPkdFile(string file)
        {
            this.FileName = file;
            this.Data = File.ReadAllBytes(file);
        }

        internal byte[] Data { get; set; }
        public string FileName { get; set; }


        /// <summary>
        /// 保存文件
        /// </summary>
        public void Save()
        {
            using (FileStream fs = new FileStream(this.FileName, FileMode.Create, FileAccess.Write))
            {
                fs.Write(this.Data, 0, this.Data.Length);
                fs.Flush();
            }
        }
    }
}
