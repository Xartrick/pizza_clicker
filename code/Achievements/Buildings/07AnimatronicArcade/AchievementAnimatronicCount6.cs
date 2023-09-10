using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementAnimatronicCount6 : Achievement
{
    public override string Ident => "building_07_animatronic_arcade_count_06";
    public override string Name => "Mechanical marvel";
    public override string Description => "Purchase 250 Animatronic Arcades";
    public override string Icon => "/ui/buildings/animatronic_arcade.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("animatronic_arcade") >= 250;
	}

}

