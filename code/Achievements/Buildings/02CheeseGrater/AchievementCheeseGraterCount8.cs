using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementCheeseGraterCount8 : Achievement
{
    public override string Ident => "building_02_cheese_grater_count_08";
    public override string Name => "The great cheese grate";
    public override string Description => "Purchase 350 Cheese Graters";
    public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("cheese_grater") >= 350;
	}

}

