using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    public abstract class GGCRUnitInfo<T>
        where T : GGCRResourceFile
    {
        /// <summary>
        /// 该单位的实际数据(Copy)
        /// </summary>
        public byte[] Data { get; }

        /// <summary>
        /// 该单位在整个CDB数据集合中的索引(第一单位为0)
        /// </summary>
        internal int No { get; }

        /// <summary>
        /// 该单位所处的PKD文件
        /// </summary>
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
                byte[] bt = new byte[UUID_LENGTH];
                Array.Copy(PkdFile.Data, Index + UUID_START, bt, 0, UUID_LENGTH);
                return ByteHelper.ByteArrayToHexString(bt).Trim();
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
                return ByteHelper.ByteArrayToHexString(ByteHelper.Int2Bytes(this.Index)).Replace(" ", "");
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

        private string tempName;
        public abstract string UnitName { get; }
        public void SetUnitName(string name)
        {
            this.tempName = name;
        }

        public abstract void SaveUnitName(string name);

        public override string ToString()
        {
            return UnitName;
        }

        protected void save(int index, byte value)
        {
            this.Data[index] = value;
        }

        protected void save(int index, byte[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                this.Data[index + i] = arr[i];
            }
        }

        protected void save(int index, short value)
        {
            byte[] arr = BitConverter.GetBytes(value);
            save(index, arr);
        }

        protected void save(int index, int value)
        {
            byte[] arr = BitConverter.GetBytes(value);
            save(index, arr);
        }

        public void Replace(byte[] data)
        {
            if (data.Length != this.UnitLength)
            {
                throw new Exception("数据不正确,无法导入");
            }
            Array.Copy(data, this.Data, data.Length);
        }

        public virtual void Save()
        {
            if (tempName != null)
            {
                SaveUnitName(tempName);
                tempName = null;
            }
            PkdFile.Write(this.Index, this.Data);
            Refresh();
        }

        public void Refresh()
        {
            Array.Copy(PkdFile.Data, this.Index, this.Data, 0, this.UnitLength);
        }
    }
}
