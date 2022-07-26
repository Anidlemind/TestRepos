using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestRepos.Projectiles
{
	public class BasicProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.damage = 50;
			Projectile.DamageType = DamageClass.Melee;
			Projectile.width = 40;
			Projectile.height = 40;
			Projectile.knockBack = 6;
			Projectile.aiStyle = 1;
			Projectile.timeLeft = 400;
			Projectile.ignoreWater = true;
			Projectile.tileCollide = false;
			
		}
	}
}