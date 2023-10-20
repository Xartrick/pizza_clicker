using Sandbox;
using System.Linq;

namespace PizzaClicker.Achievements;

[Library]
public class Achievement
{
	public virtual string Ident => "none";
	public virtual string Name => "None";
	public virtual string Description => "";
	public virtual string Icon => "ui/icons/trophy.png";

	public virtual bool CheckUnlockCondition( Player player )
	{
		return false;
	}

	public virtual void OnAchievementUnlock( Player player )
	{

	}

	public static void Unlock( Player player, string ident )
	{
		if ( !player.GiveAchievement( ident ) )
		{
			return;
		}

		var achievement = GameMenu.AllAchievements.FirstOrDefault( a => a.Ident == ident, null );
		if ( achievement == null )
		{
			return;
		}

		Notifications.Popup( "Achievement Unlocked!", achievement.Name, "achievement", achievement.Icon );
		GameMenu.Instance?.NetworkAchievementUnlock( player, ident );
		achievement.OnAchievementUnlock( player );
	}
}
