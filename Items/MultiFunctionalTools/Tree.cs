using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.MultiFunctionalTools
{
	public class Tree : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Tree"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'A dead tree a day keeps the visitors away.' -Developer");
		}

		public override void SetDefaults() 
		{
			item.damage = 75;
			item.melee = true;
			item.pick = 200;
			item.axe = 40;
			item.hammer = 200;
			item.width = 20;
			item.height = 50;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1 ;
			item.knockBack = 10;
			item.value = 999999;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 9999);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}