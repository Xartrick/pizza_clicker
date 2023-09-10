using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaChainCount11 : Achievement
{
    public override string Ident => "building_05_pizza_chain_count_11";
    public override string Name => "A chain without end";
    public override string Description => "Purchase 500 Pizza Chains";
    public override string Icon => "/ui/buildings/pizza_chain.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_chain") >= 500;
	}

}

