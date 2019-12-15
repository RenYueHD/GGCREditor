using GGCREditor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.CDBItem.Ability
{
    /// <summary>
    /// 机体能力
    /// </summary>
    public class GundamAbility : AbstractAbility
    {
        public GundamAbility(AbilitySpecFile file, int index, int no) : base(file, index, no)
        {

        }

        public override int IDInGroup => No;

        public override int UnitLength => GGCRStaticConfig.GundamAbilityLength;

        public override string TypeName => "机体能力";
    }
}
