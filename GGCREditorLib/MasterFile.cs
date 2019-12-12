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
    public class MasterFile
    {
        public MasterFile(string file)
        {
            this.FileName = file;
            this.Data = File.ReadAllBytes(file);
        }

        public byte[] Data { get; set; }
        public string FileName { get; set; }

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
                list.Add(getMaster(start + 28 + i * GGCRStaticConfig.MasterLength));
            }
            return list;
        }

        /// <summary>
        /// 通过地址获取角色信息
        /// </summary>
        /// <param name="addressHex"></param>
        /// <returns></returns>
        public MasterInfo getMaster(string addressHex)
        {
            int index = ByteHelper.Bytes2Int(ByteHelper.HexStringToByteArray(addressHex));
            return getMaster(index);
        }

        /// <summary>
        /// 通过索引获取角色信息
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public MasterInfo getMaster(int index)
        {
            return new MasterInfo(this, index);
        }

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
