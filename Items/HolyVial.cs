using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items
{
	public class HolyVial : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Holy Vial"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Immunity to Ichor and Cursed Inferno");
		}

		public override void SetDefaults() 
		{
			item.width = 10;
			item.height = 10;
			item.value = 10000;
			item.rare = 7;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.buffImmune[BuffID.Ichor] = true;
			player.buffImmune[BuffID.CursedInferno] = true;
		}

        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.HolyWater, 200);
        recipe.AddIngredient(ItemID.HallowedSeeds, 5);
		recipe.AddIngredient(ItemID.PixieDust, 25);
		recipe.AddIngredient(ItemID.UnicornHorn, 2);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.SetResult(this);
        recipe.AddRecipe();
        }
	}
}