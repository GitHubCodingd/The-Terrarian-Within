using System;
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items
{
    public class PlainTreasureBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Boring Old Bag");
            Tooltip.SetDefault("Right click to open.");
        }

        public override void SetDefaults()
        {           
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 0;
        }
        public override bool CanRightClick()
        {
            return true;
        }
    }
}