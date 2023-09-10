using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaGPT1 : Upgrade
{
    public override string Ident => "upgrade_pizza_gpt_1";
    public override string Name => "Bronze PizzaGPT";
    public override string Description => "PizzaGPTs are twice as effective";
    public override double Cost => 140_000_000_000_000;
    public override string Icon => "ui/upgrades/pizza_gpt_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_gpt") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_gpt", 2);
    }

}

