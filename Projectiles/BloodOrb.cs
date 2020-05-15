using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Verynormalmod.Projectiles
{  
    public class BloodOrb : ModProjectile
    {
        public override void SetDefaults()
        {    
            projectile.width = 35;
            projectile.height = 35;
            projectile.aiStyle = 18;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.ownerHitCheck = true; //so you can't hit enemies through walls
            projectile.magic = true;
        }

        public virtual void Kill(int timeLeft) {
        }

        public virtual string GlowTexture => Texture + "_Glow";

        public void DamageNPC (Player myPlayer, NPC npc, ref int damage, ref float knockback){    
          // Add the buff    
          myPlayer.AddBuff (10, 30); 
        }      
    }
}