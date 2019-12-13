using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    public abstract class GGCRUnitInfo<T>
        where T : GGCRPkdFile
    {
        internal byte[] Data;

        internal int No;

        public T PkdFile { get; }

        public GGCRUnitInfo(T file, int index, int no)
        {
            this.PkdFile = file;
            this.Index = index;
            this.No = no;
            this.Data = new byte[this.UnitLength];
            Array.Copy(file.Data, index, this.Data, 0, this.UnitLength);
        }

        public string UUID
        {
            get
            {
                byte[] bt = new byte[UnitLength];
                Array.Copy(PkdFile.Data, Index + UUID_START, bt, 0, UnitLength);
                return ByteHelper.ByteArrayToHexString(bt);
            }
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

        /// <summary>
        /// 当前单位的数据长度
        /// </summary>
        public abstract int UnitLength { get; }

        /// <summary>
        /// 当前单位UUID的起始索引
        /// </summary>
        public abstract int UUID_START { get; }

        /// <summary>
        /// 当前单位UUID的长度
        /// </summary>
        public abstract int UUID_LENGTH { get; }

        protected void save(int index, byte value)
        {
            this.Data[index] = value;
        }

        protected void save(int index, short value)
        {
            byte[] arr = BitConverter.GetBytes(value);
            for (int i = 0; i < arr.Length; i++)
            {
                this.Data[index + i] = arr[i];
            }
        }

        protected void save(int index, int value)
        {
            byte[] arr = BitConverter.GetBytes(value);
            for (int i = 0; i < arr.Length; i++)
            {
                this.Data[index + i] = arr[i];
            }
        }

        public void Replace(byte[] data)
        {
            if (data.Length != this.UnitLength)
            {
                throw new Exception("数据不正确,无法替换");
            }
            Array.Copy(data, this.Data, data.Length);
        }

        public void Save()
        {
            PkdFile.Write(this.Index, this.Data);
        }

    }
}
