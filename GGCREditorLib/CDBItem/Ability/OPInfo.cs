using GGCREditor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.CDBItem.Ability
{
    public class OPInfo : AbstractAbility
    {
        public OPInfo(AbilitySpecFile file, int index, int no) : base(file, index, no)
        {
        }

        public override int IDInGroup => No - PkdFile.MachineAbilityCount;

        public override int UnitLength => GGCRStaticConfig.OPAbilityLength;

        public override string TypeName => "OP";
    }
}
