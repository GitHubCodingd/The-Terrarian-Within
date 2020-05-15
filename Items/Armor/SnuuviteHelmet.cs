using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.Localization;

namespace Verynormalmod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
	public class SnuuviteHelmet : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Snuuvite Helmet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'The helmet is weirdly flexible..?'"
			+"\nIncreased damage by 3%");
		}

		public override void SetDefaults() 
		{
			item.width = 17;
			item.height = 17;
			item.value = 4300;
			item.rare = 5;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.allDamage -= 0.3f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("SnuuviteChainmail") && legs.type == mod.ItemType("SnuuviteBoots");
		}

		public override void UpdateArmorSet(Player player) {
			string SnuuviteSetBonus = Language.GetTextValue("Mods.Verynormalmod.SnuuviteSetBonus");
			player.setBonus = SnuuviteSetBonus;
            player.AddBuff(165, 5);
			player.statLifeMax2 += 15;
		}

        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "SnuuviteBar", 6);
        recipe.AddIngredient(ItemID.DirtBlock, 10);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this);
        recipe.AddRecipe();
        }
	}
}