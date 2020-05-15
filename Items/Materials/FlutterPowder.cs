using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.Materials
{
	public class FlutterPowder : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Flutter Powder"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'It glows with aerial presence.'");
		}

		public override void SetDefaults() 
		{
			item.width = 200;
			item.height = 200;
			item.maxStack = 999;
			item.value = 2500;
			item.rare = 5;
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}