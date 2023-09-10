using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPlanetOfPizzaCount6 : Achievement
{
    public override string Ident => "building_14_planet_of_pizza_count_06";
    public override string Name => "Lunar landing";
    public override string Description => "Purchase 250 Planet of Pizzas";
    public override string Icon => "/ui/buildings/planet_of_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("planet_of_pizza") >= 250;
	}

}

