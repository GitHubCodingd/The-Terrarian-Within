using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items
{
	public class VenomAntidote : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Venom Antidote"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Gives you immunity to Venom and Feral Bite");
		}

		public override void SetDefaults() 
		{
			item.width = 10;
			item.height = 10;
			item.value = 6000;
			item.rare = 7;
			item.accessory = true;
			item.expert = true;
		}

		public void UpdateAccessory(Player player, bool hideVisual) {
			player.buffImmune[BuffID.Venom] = true;
			player.buffImmune[148] = true;
		}

        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.PurificationPowder, 10);
        recipe.AddIngredient(null, "VenomTooth", 5);
		recipe.AddIngredient(ItemID.BottledWater, 1);
        recipe.AddTile(TileID.AlchemyTable);
        recipe.SetResult(this);
        recipe.AddRecipe();
        }
	}
}