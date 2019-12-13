﻿using System;
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

        internal byte[] Data { get; }
        public string FileName { get; set; }


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
        }
    }
}
