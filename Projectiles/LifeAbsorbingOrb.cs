using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Verynormalmod.Projectiles
{  
    public class LifeAbsorbingOrb : ModProjectile
    {
        public override void SetDefaults()
        {    
            projectile.width = 33;
            projectile.height = 33;
            projectile.aiStyle = 21;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.ownerHitCheck = false;
            projectile.ranged = true;
			Main.projFrames[projectile.type] = 2;
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height); //makes dust based on tile
            Main.PlaySound(SoundID.Item10, projectile.position); //plays impact sound
        }

        public virtual string GlowTexture => Texture + "_Glow";

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Player p = Main.player[projectile.owner];
            int healingAmount = 10; //decrease the value 30 to increase heal, increase value to decrease. Or you can just replace damage/x with a set value to heal, instead of making it based on damage.
            p.statLife +=healingAmount;
            p.HealEffect(healingAmount, true);
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