using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items
{
	public class SnuuviteBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Snuuvite Bar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'You have summoned the energy of the woods.'");
		}

		public override void SetDefaults() 
		{
			item.width = 10;
			item.height = 10;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 2710;
			item.rare = 5;
			item.maxStack = 99;
			item.autoReuse = true;
		}

        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "SnuuviteOre", 25);
        recipe.AddIngredient(ItemID.DirtBlock, 5);
        recipe.AddTile(TileID.Furnaces);
        recipe.SetResult(this, 5);
        recipe.AddRecipe();
        }
	}
}