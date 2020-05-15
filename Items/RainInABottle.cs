using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items
{
	public class RainInABottle : ModItem
	{
		public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Rain In A Bottle"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Opened bottle in pocket = Wet pants'\nImmunity to On Fire!");
		}

		public override void SetDefaults() 
		{
			item.width = 10;
			item.height = 10;
			item.accessory = true;
			item.value = 2500;
			item.rare = 5;
		}

		public void UpdateAccessory(Player player, bool hideVisual) {
			player.buffImmune[24] = true;
        }
	}
}