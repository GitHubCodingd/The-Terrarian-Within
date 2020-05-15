using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.Weapons
{
	public class AdvancedCopperShortsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Advanced Copper Shortsword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Infused with even more COPPER!"
			+"\nIncreased damage, critical strike chance and size");
		}

		public override void SetDefaults() 
		{
			item.damage = 17;
			item.crit = 10;
			item.melee = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 3;
			item.knockBack = 4;
			item.value = 10000000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.useTurn = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TierMedallion1");
			recipe.AddIngredient(ItemID.CopperShortsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}