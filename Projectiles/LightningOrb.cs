using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Verynormalmod.Projectiles
{  
    public class LightningOrb : ModProjectile
    {
        public override void SetDefaults()
        {    
            projectile.width = 22;
            projectile.height = 22;
            projectile.aiStyle = 5;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.ownerHitCheck = false; //so you can't hit enemies through walls
            projectile.ranged = true;
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height); //makes dust based on tile
            Main.PlaySound(SoundID.Item10, projectile.position); //plays impact sound
        }

        public virtual string GlowTexture => Texture + "_Glow";

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(144, 5);
        }

        public override void AI()
        {
          for(int i = 0; i < 200; i++)
          {
            NPC target = Main.npc[i];
            //If the npc is hostile
            if(!target.friendly)
            {
             //Get the shoot trajectory from the projectile and target
             float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
             float shootToY = target.position.Y - projectile.Center.Y;
             float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));
            }
            //If the distance between the live targeted npc and the projectile is less than 480 pixels
          }
        }
    }
}