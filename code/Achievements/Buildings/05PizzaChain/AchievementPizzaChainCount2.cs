using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaChainCount2 : Achievement
{
    public override string Ident => "building_05_pizza_chain_count_02";
    public override string Name => "Chain of command";
    public override string Description => "Purchase 50 Pizza Chains";
    public override string Icon => "/ui/buildings/pizza_chain.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_chain") >= 50;
	}

}

