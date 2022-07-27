using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace TestRepos.Projectiles
{
	public class BasicProjectile : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Basic Projectile"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			Projectile.DamageType = DamageClass.Melee;
			Projectile.damage = 15;
			Projectile.scale = 0.75f;
			Projectile.width = 8;
			Projectile.height = 8;
			Projectile.aiStyle = 0;
			Projectile.friendly = true;
			Projectile.hostile = false;
			Projectile.penetrate = 2;
			Projectile.timeLeft = 50;
			Projectile.light = 0.25f;
			Projectile.ignoreWater = true;
			Projectile.tileCollide = true;
		}

        public override void AI() //Копипаст от Riptide
        {
			int dust = Dust.NewDust(Projectile.Center, 1, 1, 15, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].velocity *= 0.3f;
			Main.dust[dust].scale = (float)Main.rand.Next(100, 135) * 0.013f;
			Main.dust[dust].noGravity = true;

			int dust2 = Dust.NewDust(Projectile.Center, 1, 1, 137, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust2].velocity *= 0.3f;
			Main.dust[dust2].scale = (float)Main.rand.Next(80, 115) * 0.013f;
			Main.dust[dust2].noGravity = true;
		} 
    }
}