using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Verynormalmod.Tiles
{
	public class MechanicTable : ModTile
	{
		public override void SetDefaults()
		{
			//Main.tileSolid[Type] = false;
			//Main.tileSolidTop[Type] = true;
			//Main.tileMergeDirt[Type] = false;
			//Main.tileBlockLight[Type] = true;
			//Main.tileLighted[Type] = false;
			//Main.tileLavaDeath[Type] = true;
			//Main.tileWaterDeath[Type] = false;
			//Main.tileFrameImportant[Type] = true;
			dustType = mod.DustType("Sparkle");
			drop = mod.ItemType("MechanicTable");
			Main.tileSolidTop[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileLavaDeath[Type] = true;
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Mechanic's Table");
			AddMapEntry(new Color(40, 40, 40), name);
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.WorkBenches };
			Main.tileFrameImportant[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.CoordinateHeights = new[] { 18 };
			TileObjectData.addTile(Type);
		}
	}
}