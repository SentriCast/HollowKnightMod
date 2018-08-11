using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace HollowKnightMod.Projectiles
{
    class OldNail : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Old");
            Main.projFrames[projectile.type] = 8;
        }

        public override void SetDefaults()
        {
            projectile.width = 64;
            projectile.height = 60;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.melee = true;
            projectile.ownerHitCheck = true;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 0;
            projectile.timeLeft = 8;
        }
        
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            float num = 0f;
            Vector2 vector = player.RotatedRelativePoint(player.MountedCenter, true);
            if (projectile.spriteDirection == -1)
            {
                num = 3.14159274f;
            }
            if (++projectile.frame >= Main.projFrames[projectile.type])
            {
                projectile.frame = 0;
            }

            Vector2 vector14 = projectile.Center + projectile.velocity * 3f;
            projectile.position = player.RotatedRelativePoint(player.MountedCenter, true) - projectile.Size / 2f;
            projectile.rotation = projectile.velocity.ToRotation() + num;
            projectile.direction = player.direction;
            projectile.spriteDirection = projectile.direction;
            player.ChangeDir(projectile.direction);
            player.heldProj = projectile.whoAmI;
            player.itemTime = 2;
            player.itemAnimation = 2;
        }
    }
}
