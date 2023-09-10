using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementInterdimensionalCount5 : Achievement
{
    public override string Ident => "building_13_interdimensional_count_05";
    public override string Name => "Reality cheque, please";
    public override string Description => "Purchase 200 Interdimensional Pizzerias";
    public override string Icon => "/ui/buildings/interdimensional_pizzeria.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("interdimensional_pizzeria") >= 200;
	}

}

