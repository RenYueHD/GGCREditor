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
        internal Dictionary<short, string> SeriesCode { get; }

        public MasterFile()
            : base(GGCRStaticConfig.MasterFile)
        {
            MasterNames = new GGCRTblFile(GGCRStaticConfig.MasterTxtFile).ListAllText().ToArray();

            SeriesCode = GGCRUtil.ListSeriesCode();
        }

        /// <summary>
        /// 获取所有Master
        /// </summary>
        /// <returns></returns>
        public List<MasterInfo> ListMasters()
        {
            int start = this.GetInnerFile("CharacterSpecList.cdb").StartIndex;
            if (start < 0)
            {
                throw new Exception("文件[" + this.FileName + "]无法解析");
            }

            int count = BitConverter.ToInt32(this.Data, start + 8);

            List<MasterInfo> list = new List<MasterInfo>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new MasterInfo(this, start + 28 + i * GGCRStaticConfig.MasterLength, i, list));
            }
            return list;
        }

    }
}
