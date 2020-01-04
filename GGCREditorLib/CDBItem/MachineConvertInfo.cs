using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.CDBItem
{
    public class MachineConvertInfo : GGCRUnitInfo<GundamFile>
    {

        private string From { get; }

        private string To { get; }

        private int Convert { get; }

        public MachineConvertInfo(GundamFile file, int index, int no) : base(file, index, no)
        {
            byte[] bt = new byte[8];
            Array.Copy(PkdFile.Data, Index, bt, 0, 8);
            this.From = ByteHelper.ByteArrayToHexString(bt).Trim();

            bt = new byte[8];
            Array.Copy(PkdFile.Data, Index + 8, bt, 0, 8);
            this.To = ByteHelper.ByteArrayToHexString(bt).Trim();

            this.Convert = BitConverter.ToInt32(PkdFile.Data, Index + 16);
        }

        public override int UnitLength => 20;

        public override int UUID_START => 0;

        public override int UUID_LENGTH => throw new NotImplementedException();

        public override string UnitName => throw new NotImplementedException();
    }
}
