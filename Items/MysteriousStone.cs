using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Verynormalmod.Items
{
	public class MysteriousStone : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Mysterious Stone"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The symbols both mean ''[c/00FF00:delta]'' in Greek"
			+"\n'It's power is unknown, but it seems to grow in power and grants the wearer.'");
		}

		public override void SetDefaults() 
		{
			item.value = 100000;
			item.rare = 8;
			item.accessory = true;
			item.width = 64;
			item.height = 256;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.allDamage -= 0.10f;
			player.statLifeMax2 += 200;
			player.moveSpeed -= 0.08f;
			player.endurance -= 0.15f;
		}
	}
}