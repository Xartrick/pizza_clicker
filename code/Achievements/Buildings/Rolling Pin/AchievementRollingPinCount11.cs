using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementRollingPinCount11 : Achievement
{
    public override string Ident => "building_1_rolling_pin_count_11";
    public override string Name => "The rolling 500 club";
    public override string Description => "Purchase 500 Rolling Pins";
    public override string Icon => "/ui/buildings/rolling_pin.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("rolling_pin") >= 500;
	}

}

