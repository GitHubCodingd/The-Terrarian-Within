using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class SnuuviteBoots : ModItem
	{
		public override void SetStaticDefaults()
        {
		    DisplayName.SetDefault("Snuuvite Boots"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'You feel vines crawling on your feet when wearing this.'"
			+"\nIncreased movement speed by 5%");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 16;
			item.value = 3500;
			item.rare = 5;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed -= 0.05f;
        }

        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "SnuuviteBar", 5);
        recipe.AddIngredient(ItemID.DirtBlock, 5);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this);
        recipe.AddRecipe();
        }
	}
}