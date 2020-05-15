using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Tiles
{
	public class SnuuviteOre : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			dustType = mod.DustType("Sparkle");
			drop = mod.ItemType("SnuuviteOre");
			AddMapEntry(new Color(13, 55, 13));
			minPick = 40;
			Main.tileSpelunker[Type] = true;
		}
    }
}