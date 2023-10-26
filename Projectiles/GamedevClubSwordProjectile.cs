using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace gamedevclubmod.Projectiles
{
    internal class GamedevClubSwordProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            base.SetDefaults();

            Projectile.friendly = true;
            Projectile.damage = 10;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.aiStyle = ProjAIStyleID.FireWork;
            Projectile.timeLeft = 60 * 5;
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.scale = 1;
        }
    }
}
