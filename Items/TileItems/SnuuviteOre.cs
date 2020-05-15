using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.TileItems
{
	public class SnuuviteOre : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Snuuvite Ore"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'It radiates grassy energy..'");
		}

		public override void SetDefaults() 
		{
			item.consumable = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 500;
			item.rare = 1;
			item.maxStack = 999;
			item.createTile = mod.TileType("SnuuviteOre");
			item.autoReuse = true;
		}
	}
}