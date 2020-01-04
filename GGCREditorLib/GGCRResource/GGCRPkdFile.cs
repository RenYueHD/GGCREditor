using GGCREditorLib.GGCRResource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    public abstract class GGCRPkdFile : GGCRResourceFile
    {
        public GGCRPkdFile(string file) : base(file)
        {

        }

        public GGCRPkdInnerFile GetInnerFile(string name)
        {
            List<GGCRPkdInnerFile> list = this.ListInnerFiles();
            foreach (GGCRPkdInnerFile file in list)
            {
                if (file.FileName == name)
                {
                    return file;
                }
            }
            return null;
        }

        public List<GGCRPkdInnerFile> ListInnerFiles()
        {
            //取PKD中文件数量
            int count = BitConverter.ToInt32(this.Data, 8);
            //文件头的总数据量(去除最后的00位)
            int headLength = BitConverter.ToInt32(this.Data, 16) - 1;
            //文件名起始索引
            int cdbNamesIndexStart = 20 + count * 12;
            //文件名终止索引
            byte[] cdbNamesData = new byte[headLength - count * 12];
            Array.Copy(this.Data, 20 + count * 12, cdbNamesData, 0, cdbNamesData.Length);

            string[] cdbNames = Encoding.UTF8.GetString(cdbNamesData).Split('\0');

            List<GGCRPkdInnerFile> files = new List<GGCRPkdInnerFile>();
            //取每个文件名和地址
            for (int i = 0; i < count; i++)
            {
                GGCRPkdInnerFile f = new GGCRPkdInnerFile();
                f.FileName = cdbNames[i];
                f.StartIndex = BitConverter.ToInt32(this.Data, 20 + 12 * i);

                files.Add(f);
            }
            return files;
        }

    }
}
