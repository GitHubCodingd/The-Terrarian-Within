using Verynormalmod.Items;
using Verynormalmod.Tiles;
using Verynormalmod.Worlds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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

namespace Verynormalmod.NPCs
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(25) == 0)
            {
                if (npc.type == NPCID.FlyingFish)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RainInABottle"));
                }
                if (npc.type == NPCID.UmbrellaSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RainInABottle"));
                }
            }
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

            //When an NPC (from the invasion list) dies, add progress by decreasing size
            if(World.ninjaInvasionUp)
            {
                //Gets IDs of invaders from CustomInvasion file
                foreach(int invader in NinjaInvasion.invaders)
                {
                    //If npc type equal to invader's ID decrement size to progress invasion
                    if(npc.type == invader)
                    {
                        Main.invasionSize -= 1;
                    }
                }
            }
        }

		public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
			if (type == NPCID.Mechanic)
            {
				shop.item[nextSlot].SetDefaults(mod.ItemType("MechanicTable"));
				nextSlot++;
            }               
        }

        public override void EditSpawnPool(IDictionary< int, float > pool, NPCSpawnInfo spawnInfo)
        {
            //If the custom invasion is up and the invasion has reached the spawn pos
            if(World.ninjaInvasionUp && (Main.invasionX == (double)Main.spawnTileX))
            {
                //Clear pool so that only the stuff you want spawns
                pool.Clear();
   
                //key = NPC ID | value = spawn weight
                //pool.add(key, value)
       
                //For every ID inside the invader array in our CustomInvasion file
                foreach(int i in NinjaInvasion.invaders)
                {
                    pool.Add(i, 1f); //Add it to the pool with the same weight of 1
                }
            }
        }

        //Changing the spawn rate
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            //Change spawn stuff if invasion up and invasion at spawn
            if(World.ninjaInvasionUp && (Main.invasionX == (double)Main.spawnTileX))
            {
                spawnRate = 100; //Higher the number, the more spawns
                maxSpawns = 10000; //Max spawns of NPCs depending on NPC value
            }
        }

        //Adding to the AI of an NPC
        public override void PostAI(NPC npc)
        {
            //Changes NPCs so they do not despawn when invasion up and invasion at spawn
            if(World.ninjaInvasionUp && (Main.invasionX == (double)Main.spawnTileX))
            {
                npc.timeLeft = 1000;
            }
        }
    }
}