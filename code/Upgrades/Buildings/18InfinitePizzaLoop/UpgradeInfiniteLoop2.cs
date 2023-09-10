using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeInfiniteLoop2 : Upgrade
{
    public override string Ident => "upgrade_pizza_loop_2";
    public override string Name => "Silver Infinite Pizza Loop";
    public override string Description => "Infinite Pizza Loops are twice as effective";
    public override double Cost => double.Parse("600,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_loop_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("infinite_pizza_loop") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("infinite_pizza_loop", 2);
    }

}

