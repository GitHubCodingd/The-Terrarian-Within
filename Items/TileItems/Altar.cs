using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.TileItems
{
	public class Altar : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Altar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Only places the demon altar because reasons'");
		}

		public override void SetDefaults() 
		{
			item.consumable = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 0;
			item.rare = 3;
			item.maxStack = 99;
			item.createTile = TileID.DemonAltar;
			item.autoReuse = true;
		}

        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.EbonstoneBlock, 25);
        recipe.AddIngredient(ItemID.RottenChunk, 50);
        recipe.AddIngredient(ItemID.WormTooth, 10);
        recipe.AddTile(TileID.DemonAltar);
        recipe.SetResult(this);
        recipe.AddRecipe();
        }
	}
}