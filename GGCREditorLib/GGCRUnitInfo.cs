using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    public class GGCRUnitInfo<T>
        where T : GGCRPkdFile
    {
        internal int No;

        public T PkdFile { get; }

        public GGCRUnitInfo(T file, int index, int no)
        {
            this.PkdFile = file;
            this.Index = index;
            this.No = no;
        }


        /// <summary>
        /// 当前数据所在pkd文件索引
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 取当前数据地址
        /// </summary>
        public string Address
        {
            get
            {
                return ByteHelper.ByteArrayToHexString(ByteHelper.Int2Bytes(this.Index));
            }
        }

        protected void save(int index, short value)
        {
            byte[] arr = BitConverter.GetBytes(value);
            for (int i = 0; i < arr.Length; i++)
            {
                PkdFile.Data[index + i] = arr[i];
            }
        }

        protected void save(int index, int value)
        {
            byte[] arr = BitConverter.GetBytes(value);
            for (int i = 0; i < arr.Length; i++)
            {
                PkdFile.Data[index + i] = arr[i];
            }
        }

    }
}
