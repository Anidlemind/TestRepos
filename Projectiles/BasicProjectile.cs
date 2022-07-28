using Terraria.Audio;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TestRepos.Projectiles
{
	public class BasicProjectile : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Slime's Tears"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			Projectile.DamageType = DamageClass.Melee;
			Projectile.damage = 15;
			Projectile.scale = 1.25f;
			Projectile.width = 8;
			Projectile.height = 8;
			Projectile.aiStyle = 0;
			Projectile.friendly = true;
			Projectile.hostile = false;
			Projectile.penetrate = 1;
			Projectile.timeLeft = 50;
			Projectile.light = 0.25f;
			Projectile.ignoreWater = true;
			Projectile.tileCollide = true;
		}

        public override void AI()
        {
			Player player = Main.player[Projectile.owner];
			Projectile.direction = player.direction;
			Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);
			if (Projectile.spriteDirection == -1) {
				Projectile.rotation += MathHelper.ToRadians(270f);
			}
			Projectile.aiStyle = 0 ;
			Lighting.AddLight(Projectile.position, 0.2f, 0.2f, 0.6f);
			Lighting.Brightness(1,1);
		}

        public override void Kill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.SplashWeak.WithVolumeScale(0.5f).WithPitchOffset(0.8f), Projectile.position);
			for (var i = 0 ; i < 6; i ++) {
				Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, 7, 0f, 0f, 0, Color.Aquamarine, 1f);
			}
        }
    }
}