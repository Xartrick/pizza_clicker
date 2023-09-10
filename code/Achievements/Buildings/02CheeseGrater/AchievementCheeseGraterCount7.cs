using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementCheeseGraterCount7 : Achievement
{
    public override string Ident => "building_02_cheese_grater_count_07";
    public override string Name => "Three cheese moon";
    public override string Description => "Purchase 300 Cheese Graters";
    public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("cheese_grater") >= 300;
	}

}

