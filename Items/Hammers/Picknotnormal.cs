using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.Hammers
{
	public class Picknotnormal : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Pickaxe?"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Yeah it's DEFINITELY a normal pickaxe, nothing new.");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
			item.melee = true;
			item.hammer = 1000;
			item.width = 10000;
			item.height = 10000;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = 5;
			item.knockBack = 9999999999;
			item.value = 0;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.NightsEdge, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 50);
			recipe.AddIngredient(ItemID.Feather, 100);
			recipe.AddIngredient(ItemID.CopperBar, 1000);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}