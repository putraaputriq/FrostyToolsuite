using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ContainsAbilityUpgradeIdDataEntityData))]
	public class ContainsAbilityUpgradeIdDataEntity : CompareEntityBase, IEntityData<FrostySdk.Ebx.ContainsAbilityUpgradeIdDataEntityData>
	{
		public new FrostySdk.Ebx.ContainsAbilityUpgradeIdDataEntityData Data => data as FrostySdk.Ebx.ContainsAbilityUpgradeIdDataEntityData;
		public override string DisplayName => "ContainsAbilityUpgradeIdData";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ContainsAbilityUpgradeIdDataEntity(FrostySdk.Ebx.ContainsAbilityUpgradeIdDataEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}
