using GGCREditorLib.GGCRResource;
using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.CDBItem
{
    public class SpecProfileInfo : GGCRUnitInfo<SpecProfileCdbFile>
    {
        public SpecProfileInfo(SpecProfileCdbFile file, int index, int no) : base(file, index, no)
        {
        }

        public short DetailId
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 28);
            }
            set
            {
                save(28, value);
            }
        }

        public override int UnitLength => 36;

        public override int UUID_START => 0;

        public override int UUID_LENGTH => 8;

        public override string UnitName => null;

        public override void SaveUnitName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
