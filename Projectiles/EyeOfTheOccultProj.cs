using Terraria.Audio;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TestRepos.Projectiles
{
	public class EyeOfTheOccultProj : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("A piece of meat"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			Projectile.DamageType = DamageClass.Melee;
			Projectile.scale = 1.25f;
			Projectile.width = 18;
			Projectile.height = 18;
			Projectile.aiStyle = 9;
			Projectile.friendly = true;
			Projectile.hostile = false;
			Projectile.penetrate = 4;
			Projectile.timeLeft = 100;
			Projectile.light = 1.25f;
			Projectile.ignoreWater = true;
			Projectile.tileCollide = true;
		}

        public override void AI()
        {
			for (var i = 0; i < 20; i += 1) {
				int dust = Dust.NewDust(Projectile.Center, 1, 1, 5, 0f, 0f, 0, default(Color), 1f);
				Main.dust[dust].velocity *= 0.3f;
				Main.dust[dust].scale = (float)Main.rand.Next(100, 135) * 0.013f;
				Main.dust[dust].noGravity = true;

				int dust2 = Dust.NewDust(Projectile.Center, 1, 1, 5, 0f, 0f, 0, default(Color), 1f);
				Main.dust[dust2].velocity *= 0.3f;
				Main.dust[dust2].scale = (float)Main.rand.Next(80, 115) * 0.013f;
			    Main.dust[dust2].noGravity = true;
			}
        }
    }
}