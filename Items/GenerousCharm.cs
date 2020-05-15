using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items
{
	public class GenerousCharm : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Generous Charm"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Immunity to Midas");
		}

		public override void SetDefaults() 
		{
			item.width = 23;
			item.height = 30;
			item.value = 30000;
			item.rare = 6;
			item.accessory = true;
		}

		public void UpdateAccessory(Player player, bool hideVisual) {
			player.buffImmune[BuffID.Midas] = true;
		}

        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.HallowedBar, 10);
        recipe.AddIngredient(ItemID.Diamond, 5);
		recipe.AddIngredient(ItemID.GoldWatch, 1);
		recipe.AddIngredient(ItemID.PlatinumCoin, 1);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.SetResult(this);
        recipe.AddRecipe();
        }
	}
}