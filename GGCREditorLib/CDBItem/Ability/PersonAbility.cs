using GGCREditor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.CDBItem.Ability
{
    /// <summary>
    /// 个人能力
    /// </summary>
    public class PersonAbility : AbstractAbility
    {
        public PersonAbility(AbilitySpecFile file, int index, int no) : base(file, index, no)
        {
        }

        public override int IDInGroup => No - PkdFile.MachineAbilityCount - PkdFile.OPCount;

        public override int UnitLength => GGCRStaticConfig.PeopleAbilityLength;

        public override string TypeName => "个人技能";
    }
}
