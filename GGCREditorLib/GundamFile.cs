using GGCREditor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// 机体文件数据
    /// </summary>
    public class GundamFile
    {
        public GundamFile(string file)
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
        public List<GundamInfo> ListMachines()
        {
            int start = ByteHelper.FindFirstIndex(this.Data, "4C 53 43 4D", 0);
            if (start < 0)
            {
                throw new Exception("文件[" + this.FileName + "]无法解析");
            }

            int count = BitConverter.ToInt32(this.Data, start + 8);
            int count2 = BitConverter.ToInt32(this.Data, start + 12);

            List<GundamInfo> list = new List<GundamInfo>();
            for (int i = 0; i < count + count2; i++)
            {
                list.Add(getGundam(start + 32 + i * GGCRStaticConfig.GundamLength));
            }
            return list;
        }

        /// <summary>
        /// 通过地址获取机体信息
        /// </summary>
        /// <param name="addressHex"></param>
        /// <returns></returns>
        public GundamInfo getGundam(string addressHex)
        {
            int index = ByteHelper.Bytes2Int(ByteHelper.HexStringToByteArray(addressHex));
            return getGundam(index);
        }

        /// <summary>
        /// 通过索引获取机体信息
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public GundamInfo getGundam(int index)
        {
            return new GundamInfo(this, index);
        }

        public List<WeaponInfo> ListWeapons()
        {
            int start = ByteHelper.FindFirstIndex(this.Data, "4C 53 50 57", 0);
            if (start < 0)
            {
                throw new Exception("文件[" + this.FileName + "]无法解析");
            }

            int count = BitConverter.ToInt32(this.Data, start + 8);
            int count2 = BitConverter.ToInt32(this.Data, start + 12);

            List<WeaponInfo> list = new List<WeaponInfo>();
            for (int i = 0; i < count + count2; i++)
            {
                list.Add(getWeapon(start + 28 + i * GGCRStaticConfig.WeaponLength));
            }
            return list;
        }

        /// <summary>
        /// 通过地址获取武器信息
        /// </summary>
        /// <param name="addressHex"></param>
        /// <returns></returns>
        public WeaponInfo getWeapon(string addressHex)
        {
            int index = ByteHelper.Bytes2Int(ByteHelper.HexStringToByteArray(addressHex));
            return getWeapon(index);
        }

        /// <summary>
        /// 通过地址获取武器信息
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public WeaponInfo getWeapon(int index)
        {
            return new WeaponInfo(this, index);
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
