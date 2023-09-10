using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaChainCount7 : Achievement
{
    public override string Ident => "building_05_pizza_chain_count_07";
    public override string Name => "Tri-generational franchise";
    public override string Description => "Purchase 300 Pizza Chains";
    public override string Icon => "/ui/buildings/pizza_chain.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_chain") >= 300;
	}

}

