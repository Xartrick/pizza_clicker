using Sandbox;
using System;
using System.Linq;

namespace PizzaClicker.Buildings;

[Library]
public class Building
{
	public virtual string Ident => "none";
	public virtual string Name => "None";
	public virtual double Cost => 0;
	public virtual double PizzasPerSecond => 0;

	public double GetCost( Player player, ulong count )
	{
		var cost = Cost * Math.Pow( 1.15, count );

		if ( player.HasBlessing( "building_discount_01" ) )
		{
			cost *= 0.99d;
		}

		return Math.Floor( cost );
	}

	public double GetIndividualPizzasPerSecond( Player player )
	{
		return PizzasPerSecond * player.GetBuildingMultiplier( Ident ) * player.GetTemporaryMultiplier( Ident );
	}

	public double GetPizzasPerSecond( Player player, ulong count )
	{
		var val = PizzasPerSecond
				 * count
				 * player.GetBuildingMultiplier( Ident )
				 * player.GetTemporaryMultiplier( Ident )
				 * player.TotalMultiplier;

		if ( player.HeavenlyPercent > 0 )
		{
			val *= 1d + ((player.LegacyDough * player.HeavenlyPercent) / 100d);
		}

		if ( player.AchievementMultiplier > 0 )
		{
			val *= 1d + (player.AchievementCount * player.AchievementMultiplier);
		}

		if ( player.HasBlessing( "pizzas_per_friend_01" ) )
		{
			val *= 1d + (GameMenu.Instance.Lobby.MemberCount / 100d);
		}

		if ( GoldenSwitch.Enabled )
		{
			val *= 1.5d + (player.Upgrades.Where( x => x.Key.Contains( "gold_pizza" ) ).Count() * 0.1d);
		}

		if ( player.FrenzyTime > 0 )
		{
			val *= 7;
		}

		return val;
	}
}
