using GGCREditor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// 角色文件数据
    /// </summary>
    public class MasterFile : GGCRPkdFile
    {
        internal string[] MasterNames { get; }
        internal Dictionary<string, string> Groups { get; }

        public MasterFile()
            : base(GGCRStaticConfig.MasterFile)
        {
            //读取姓名数据 00002cc0
            byte[] data = File.ReadAllBytes(GGCRStaticConfig.MasterTxtFile);
            int idx = ByteHelper.FindFirstIndex(data, "E5 B8 8C E7 BD 97 C2 B7", 0);

            MasterNames = Encoding.UTF8.GetString(data, idx, data.Length - idx).Split('\0');

            Groups = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader("系列代码.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        Groups[arr[1]] = arr[0];
                    }
                }
            }
        }

        /// <summary>
        /// 获取所有Master
        /// </summary>
        /// <returns></returns>
        public List<MasterInfo> ListMasters()
        {
            int start = ByteHelper.FindFirstIndex(this.Data, "4C 53 48 43", 0);
            if (start < 0)
            {
                throw new Exception("文件[" + this.FileName + "]无法解析");
            }

            int count = BitConverter.ToInt32(this.Data, start + 8);

            List<MasterInfo> list = new List<MasterInfo>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new MasterInfo(this, start + 28 + i * GGCRStaticConfig.MasterLength, i));
            }
            return list;
        }

    }
}
