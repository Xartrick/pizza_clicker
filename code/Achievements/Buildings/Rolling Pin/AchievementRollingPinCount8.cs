using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementRollingPinCount8 : Achievement
{
    public override string Ident => "building_1_rolling_pin_count_08";
    public override string Name => "Flour power";
    public override string Description => "Purchase 350 Rolling Pins";
    public override string Icon => "/ui/buildings/rolling_pin.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("rolling_pin") >= 350;
	}

}

