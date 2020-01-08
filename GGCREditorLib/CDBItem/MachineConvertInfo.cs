using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.CDBItem
{
    public class MachineConvertInfo : GGCRUnitInfo<GundamFile>
    {
        public MachineConvertInfo(GundamFile file, int index, int no) : base(file, index, no)
        {

        }

        public string From
        {
            get
            {
                byte[] bt = new byte[8];
                Array.Copy(this.Data, 0, bt, 0, 8);
                return ByteHelper.ByteArrayToHexString(bt).Trim();
            }
            set
            {
                this.save(0, ByteHelper.HexStringToByteArray(value));
            }
        }

        public string To
        {
            get
            {
                byte[] bt = new byte[8];
                Array.Copy(this.Data, 8, bt, 0, 8);
                return ByteHelper.ByteArrayToHexString(bt).Trim();
            }
            set
            {
                this.save(8, ByteHelper.HexStringToByteArray(value));
            }
        }

        public int Action
        {
            get
            {
                return BitConverter.ToInt32(this.Data, 16);
            }
            set
            {
                this.save(16, value);
            }
        }


        public override int UnitLength => 20;

        public override int UUID_START => 0;

        public override int UUID_LENGTH => 20;

        public override string UnitName => "未知";

        public override void SaveUnitName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
