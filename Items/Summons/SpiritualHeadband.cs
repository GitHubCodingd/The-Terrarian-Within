using Verynormalmod.Items;
using Verynormalmod.Tiles;
using Verynormalmod.Worlds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

namespace Verynormalmod.Items.Summons
{
	public class SpiritualHeadband : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Spiritual Headband"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Remnants of many skilled ninja souls'");
		}

		public override void SetDefaults() 
		{
			item.width = 25;
			item.height = 25;
            item.scale = 1;
            item.maxStack = 99;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 4;
            item.consumable = true;
			item.value = 8000;
			item.rare = 8;
		}

        public override bool UseItem(Player player)
        {
            if(!World.ninjaInvasionUp)
            {
                Main.NewText("The ninja-like spirits are invading..", 175, 75, 255, false);
                NinjaInvasion.StartNinjaInvasion();
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Ectoplasm, 20);
            recipe.AddIngredient(ItemID.Silk, 7);
            recipe.AddIngredient(ItemID.BlackDye, 10);
            recipe.AddIngredient(ItemID.RedDye, 3);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}