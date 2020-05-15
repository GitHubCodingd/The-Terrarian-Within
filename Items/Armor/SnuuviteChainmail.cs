using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class SnuuviteChainmail : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Snuuvite Chainmail"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'You smell the forest scent when wearing this.'"
			+"\nImmunity to Poisoned and Venom");
		}

		public override void SetDefaults() 
		{
			item.width = 18;
			item.height = 18;
			item.value = 5000;
			item.rare = 5;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player) {
			player.buffImmune[BuffID.Poisoned] = true;
			player.buffImmune[BuffID.Venom] = true;
		}

        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "SnuuviteBar", 7);
        recipe.AddIngredient(ItemID.DirtBlock, 15);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this);
        recipe.AddRecipe();
        }
	}
}