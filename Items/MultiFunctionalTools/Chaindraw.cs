using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.MultiFunctionalTools
{
	public class Chaindraw : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Chaindraw"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'A chainsaw and a drill, what a wonder.'");
		}

		public override void SetDefaults() 
		{
			item.damage = 53;
			item.melee = true;
			item.pick = 170;
			item.axe = 150;
			item.width = 20;
			item.height = 12;
			item.useTime = 7;
			item.useAnimation = 25;
			item.useStyle = 5 ;
			item.knockBack = 3;
			item.value = 50000;
			item.rare = 6;
			item.UseSound = SoundID.Item22;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("ChaindrawDrill");
			item.shootSpeed = 10f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1006, 10);
			recipe.AddIngredient(1552, 5);
			recipe.AddIngredient(84, 3);
			recipe.AddIngredient(547, 10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}