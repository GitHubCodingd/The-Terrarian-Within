using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.Weapons
{
	public class Flea : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Flea"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Those itchy little pests in your pet's body");
		}

		public override void SetDefaults() 
		{
			item.damage = 70;
			item.melee = true;
			item.width = 1;
			item.height = 1;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = 1;
			item.knockBack = 999999;
			item.value = 0;
			item.rare = 10;
			item.UseSound = SoundID.Item10;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = 189;
			item.shootSpeed = 12f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 50);
			recipe.AddIngredient(ItemID.SoulofFlight, 50);
			recipe.AddIngredient(ItemID.SoulofSight, 50);
			recipe.AddIngredient(ItemID.LifeCrystal, 10);
			recipe.AddTile(0);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}