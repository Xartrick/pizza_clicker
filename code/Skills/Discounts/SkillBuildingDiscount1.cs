using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class SkillBuildingDiscount1 : Skill
{
    public override string Ident => "building_discount_01";
    public override string Name => "Divine discount";
    public override string Description => "Buildings are 1% cheaper";
    public override double Cost => 99_999;

    public override bool CheckUnlockCondition(Player player)
    {
        return false;
    }

}

