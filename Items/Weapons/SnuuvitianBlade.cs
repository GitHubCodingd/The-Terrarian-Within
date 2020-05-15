using System;
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.Weapons
{
    public class SnuuvitianBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Snuuvitian Blade");
            Tooltip.SetDefault("'This sword can fling a wrecking ball a mile away'");
        }

        public override void SetDefaults()
        {           
            item.damage = 23;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 30;
			item.value = 432;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
        }

	    public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SnuuviteBar", 2);
			recipe.AddIngredient(ItemID.DirtBlock, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}    
    }
}