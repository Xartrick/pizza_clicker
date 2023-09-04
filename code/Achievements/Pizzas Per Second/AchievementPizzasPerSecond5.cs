using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzasPerSecond5 : Achievement
{
    public override string Ident => "pizzas_per_second_05";
    public override string Name => "Hypersonic slicing";
    public override string Description => "Bake 10,000 pizzas/sec";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 10_000;
	}

}

