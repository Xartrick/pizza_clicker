using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementMozzaMineCount1 : Achievement
{
    public override string Ident => "building_09_mozza_mine_count_01";
    public override string Name => "Minor mozzarella";
    public override string Description => "Purchase 1 Mozzarella Mine";
    public override string Icon => "/ui/buildings/mozzarella_mine.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("mozzarella_mine") >= 1;
	}

}

