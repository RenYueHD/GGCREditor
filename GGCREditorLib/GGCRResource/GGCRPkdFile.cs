using GGCREditorLib.GGCRResource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    public class GGCRPkdFile : GGCRResourceFile
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
                f.StartIndexLocation = 20 + 12 * i;
                files.Add(f);
            }
            return files;
        }

        /// <summary>
        /// 在某一个内部文件的某个索引(以内部文件的文件头作为索引0)处插入新的数据,并同时调整后续所有文件的地址数据,并直接写入文件
        /// </summary>
        /// <param name="file"></param>
        /// <param name="newIndex"></param>
        public void AppendInnerFile(GGCRPkdInnerFile file, int insertIndex, byte[] data)
        {
            //寻找后续文件并重排位置
            foreach (GGCRPkdInnerFile next in ListInnerFiles())
            {
                if (next.StartIndex > file.StartIndex)
                {
                    byte[] arr = BitConverter.GetBytes(next.StartIndex + data.Length);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        this.Data[next.StartIndexLocation + i] = arr[i];
                    }
                }
            }
            this.Insert(file.StartIndex + insertIndex, data);
        }

        /// <summary>
        /// 在某一个内部文件的某个索引(以pkd文件头作为索引0)处删除数据,并同时调整后续所有文件的地址数据,并直接写入文件
        /// </summary>
        /// <param name="file"></param>
        /// <param name="from"></param>
        /// <param name="length"></param>
        public void DeleteInnerFile(GGCRPkdInnerFile file, int from, int length)
        {
            //寻找后续文件并重排位置
            foreach (GGCRPkdInnerFile next in ListInnerFiles())
            {
                if (next.StartIndex > file.StartIndex)
                {
                    byte[] arr = BitConverter.GetBytes(next.StartIndex - length);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        this.Data[next.StartIndexLocation + i] = arr[i];
                    }
                }
            }
            this.Delete(from, length);
        }
    }
}
