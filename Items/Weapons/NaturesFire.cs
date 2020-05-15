using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader.IO;
using Terraria.Localization;
using Terraria.World.Generation;
using Verynormalmod;

namespace Verynormalmod.Items.Weapons
{
    public class NaturesFire : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nature's Fire");
            Tooltip.SetDefault("'As it's eyes glow like chlorophyte, it seems that you're it's master now.'"
			+"\nLeft click fires a spread of flames"
			+"\nRight click fires a chlorophyte orb"
			+"\nHolding it gives you Dryad's Blessing");
        }

        public override void SetDefaults()
        {           
                    item.damage = 64;
					item.crit = 40;
			        item.noMelee = true;
					item.magic = true;
					item.mana = 20;
			        item.width = 40;
			        item.height = 40;
			        item.useTime = 15;
			        item.useAnimation = 15;
			        item.useStyle = 5;
			        item.knockBack = 0;
			        item.value = 254000;
			        item.rare = 9;
			        item.UseSound = SoundID.Item43;
			        item.autoReuse = true;
			        item.useTurn = true;
			        item.shoot = 229;
			        item.shootSpeed = 10f;
        }

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useTime = 40;
				item.useAnimation = 40;
				item.shoot = 229;
				item.shootSpeed = 20f;
				item.mana = 30;
				item.damage = 128;
				item.crit = 60;
			}
			else
			{
				item.useTime = 15;
				item.useAnimation = 15;
				item.shoot = 85;
				item.shootSpeed = 10f;
				item.mana = 15;
				item.damage = 72;
				item.crit = 40;
			}
			return base.CanUseItem(player);
		}

		public override void HoldItem(Player player)
		{
			player.AddBuff(BuffID.DryadsWard, 2);
		}


		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "StaffOfSparking");
			recipe.AddIngredient(ItemID.LeafBlower);
			recipe.AddIngredient(ItemID.Fireblossom, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}