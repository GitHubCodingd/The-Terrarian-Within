using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.Materials
{
	public class VenomTooth : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Venom Tooth"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'The tooth of poisonous creatures'");
		}

		public override void SetDefaults() 
		{
			item.width = 15;
			item.height = 15;
			item.maxStack = 99;
			item.value = 1000;
			item.rare = 4;
        }
	}
}