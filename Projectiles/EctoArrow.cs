using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Verynormalmod.Projectiles
{  
    public class EctoArrow : ModProjectile
    {
        public override void SetDefaults()
        {    
            projectile.width = 18;
            projectile.height = 18;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = true;
            projectile.ownerHitCheck = false;
            projectile.ranged = true;
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height); //makes dust based on tile
            Main.PlaySound(SoundID.Item10, projectile.position); //plays impact sound
        }

        public virtual string GlowTexture => Texture + "_Glow";

        public override void OnHitPlayer(Player target, int damage, bool crit) {
				target.AddBuff(BuffID.Dazed, 60);
		}
    }
}