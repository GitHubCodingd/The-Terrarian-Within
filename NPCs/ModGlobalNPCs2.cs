using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.NPCs
{
    public class ModGlobalNPC2 : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(85) == 0)
            {
                if (npc.type == NPCID.CaveBat)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("VenomTooth"));
                }
                if (npc.type == NPCID.GiantBat)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("VenomTooth"));
                }
                if (npc.type == NPCID.WallCreeper)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("VenomTooth"));
                }
                if (npc.type == NPCID.BlackRecluse)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("VenomTooth"));
                }
            }
        }
    }
}