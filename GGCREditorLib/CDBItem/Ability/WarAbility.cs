using GGCREditor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.CDBItem.Ability
{
    public class WarAbility : AbstractAbility
    {
        public WarAbility(AbilitySpecFile file, int index, int no) : base(file, index, no)
        {
        }

        public override int IDInGroup => (No - PkdFile.MachineAbilityCount - PkdFile.OPCount - PkdFile.PersonAbilityCount) / 2;

        public override int UnitLength => GGCRStaticConfig.WarAbilityLength;

        public override string TypeName => "战场技能";
    }
}
