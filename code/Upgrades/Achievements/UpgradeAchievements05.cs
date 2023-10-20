using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeAchievements5 : Upgrade
{
	public override string Ident => "upgrade_achievements_05";
	public override string Name => "Pizza Cutter V";
	public override string Description => "You gain 2% more pizzas/sec for every achievement you have";
	public override double Cost => double.Parse( "900,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/pizza_cutter.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.AchievementResearch >= 100;
	}

	public override void OnPurchase( Player player )
	{
		player.AchievementMultiplier += 0.02d;
	}
}
