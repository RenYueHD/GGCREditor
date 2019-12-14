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
    public class AbilitySpecFile : GGCRPkdFile
    {
        internal string[] abilitySpecNames;

        public AbilitySpecFile()
            : base(GGCRStaticConfig.AbilityFile)
        {
            //读取姓名数据 00002cc0
            byte[] data = File.ReadAllBytes(GGCRStaticConfig.AbilityTxtFile);
            int idx = ByteHelper.FindFirstIndex(data, "E9 98 B2 E6 8A A4 E7 9B", 0);

            abilitySpecNames = Encoding.UTF8.GetString(data, idx, data.Length - idx).Split('\0');


        }


        public int AbilityCount
        {
            get
            {
                int start = ByteHelper.FindFirstIndex(this.Data, "4C 4C 42 41", 0);
                if (start < 0)
                {
                    throw new Exception("文件[" + this.FileName + "]无法解析");
                }

                return BitConverter.ToInt32(this.Data, start + 8);
            }
        }

    }
}
