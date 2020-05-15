using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.TileItems
{
	public class MechanicTable : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Mechanic's Table"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Used to craft mechanical objects");
		}

		public override void SetDefaults() 
		{
			item.consumable = true;
			item.width = 39;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 25000;
			item.rare = 3;
			item.maxStack = 99;
			item.createTile = mod.TileType("MechanicTable");
			item.autoReuse = true;
		}
	}
}