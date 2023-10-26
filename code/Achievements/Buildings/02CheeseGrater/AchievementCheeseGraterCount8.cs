using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementCheeseGraterCount8 : Achievement
{
	public override string Ident => "building_02_cheese_grater_count_08";
	public override string Name => "The great cheese grate";
	public override string Description => "Purchase 350 Cheese Graters";
	public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) >= 350;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) / 350d;
	}
}
