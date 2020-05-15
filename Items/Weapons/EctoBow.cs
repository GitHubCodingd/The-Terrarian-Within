using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Verynormalmod.Items.Weapons
{
	public class EctoBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Ecto Bow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shoots fast arrows at a fast rate at the cost of damage, allows auto reusing, converts wooden arrows to spectre arrows and 33% chance to not consume ammo");
		}

		public override void SetDefaults() 
		{
			item.damage = 40;
			item.noMelee = true;
			item.ranged = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 3;
			item.useAnimation = 3;
			item.useAmmo = AmmoID.Arrow;
			item.useStyle = 5;
			item.knockBack = 10;
			item.value = 250000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.shoot = 3;
			item.shootSpeed = 25f;
			item.autoReuse = true;
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpectreBar, 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .33f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.WoodenArrowFriendly)
			{
				type = mod.ProjectileType("EctoArrow"); // or ProjectileID.FireArrow;
			}
			return true;
		}
	}
}