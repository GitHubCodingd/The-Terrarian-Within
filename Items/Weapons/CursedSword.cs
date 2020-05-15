using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.Weapons
{
	public class CursedSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("CursedSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("cVR5s3d yess wie0eewiew");
		}

		public override void SetDefaults() 
		{
			item.damage = 50;
			item.melee = true;
			item.width = 1000;
			item.height = 1000;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = 5;
			item.knockBack = 60;
			item.value = 100000000;
			item.rare = 10;
			item.UseSound = SoundID.Item27;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = 103;
			item.shootSpeed = 12f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CursedArrow, 9990);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}