using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.GGCRResource
{
    public class GGCRPkdInnerFile
    {

        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件起始索引
        /// </summary>
        public int StartIndex { get; set; }

        /// <summary>
        /// 文件起始索引在PKD中的地址
        /// </summary>
        public int StartIndexLocation { get; set; }

    }
}
