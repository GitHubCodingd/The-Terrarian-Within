using Verynormalmod.Items;
using Verynormalmod.Tiles;
using Verynormalmod.Worlds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

namespace Verynormalmod
{
	public class Verynormalmod : Mod
	{
		public Verynormalmod()
		{
		}

        public override void UpdateMusic(ref int music)
        {
            //Checks if the invasion is in the correct spot, if it is, then change the music
            (Main.invasionX == Main.spawnTileX)
            {
                music = 6;
            }
        }
	}
}