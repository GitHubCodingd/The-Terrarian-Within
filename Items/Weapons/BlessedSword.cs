using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.Weapons
{
	public class BlessedSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BlessedSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It's blessed? I guess.");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = 5;
			item.knockBack = 5;
			item.value = 10000000;
			item.rare = 5;
			item.UseSound = SoundID.Item27;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = 278;
			item.shootSpeed = 12f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IchorArrow, 9990);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}