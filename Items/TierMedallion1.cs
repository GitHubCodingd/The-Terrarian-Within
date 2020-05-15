using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Verynormalmod;

namespace Verynormalmod.Items
{
	public class TierMedallion1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Medallion Tier 1"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Used to power certain pre-boss items");
		}

		public override void SetDefaults() 
		{
			item.width = 32;
			item.height = 32;
			item.value = 2500;
			item.rare = 3;
			item.maxStack = 30;
		}

        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.CopperBar,10);
        recipe.AddIngredient(ItemID.CopperOre,30);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this);
        recipe.AddRecipe();
		
        recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.TinBar,10);
        recipe.AddIngredient(ItemID.TinOre, 30);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this);
        recipe.AddRecipe();
        }
	}
}