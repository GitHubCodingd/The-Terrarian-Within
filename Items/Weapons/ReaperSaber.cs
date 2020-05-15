using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace Verynormalmod.Items.Weapons
{
    public class ReaperSaber : ModItem
    {
       public override void SetStaticDefaults()
       {
       DisplayName.SetDefault("Reaper Saber"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
       Tooltip.SetDefault("Shoots Life Stealing Orbs");
       }

       public override void SetDefaults()
       {
       item.damage = 100;
       item.melee = true;
       item.width = 30;
       item.height = 30;
       item.useTime = 30;
       item.useAnimation = 30;
       item.useStyle = 1;
       item.knockBack = 60;
       item.value = 750000;
       item.rare = 9;
       item.UseSound = SoundID.Item27;
       item.autoReuse = true;
       item.shoot = mod.ProjectileType("LifeAbsorbingOrb");
       item.shootSpeed = 10f;
       item.crit = 25;
       }

       public override void AddRecipes()
       {
       ModRecipe recipe = new ModRecipe(mod);
       recipe.AddIngredient(ItemID.Ectoplasm, 20);
       recipe.AddIngredient(ItemID.PurplePhasesaber, 1);
       recipe.AddIngredient(ItemID.SoulofNight, 20);
       recipe.AddTile(TileID.MythrilAnvil);
       recipe.SetResult(this);
       recipe.AddRecipe();
       }
    }
}