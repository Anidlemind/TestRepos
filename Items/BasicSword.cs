using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using TestRepos;


namespace TestRepos.Items
{
	public class BasicSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slime's Remorse");
			Tooltip.SetDefault("Ew... It fells sticky...");
		}

		public override void SetDefaults()
		{
			Item.damage = 25;
			Item.DamageType = DamageClass.Melee;
			Item.width = 100;
			Item.scale = 1f;
			Item.height = 100;
			Item.useTime = 26;
			Item.useAnimation = 26;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.knockBack = 10;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.BasicProjectile>();
			Item.shootSpeed = 10.5f;
		}

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
			Vector2 offset = new Vector2(velocity.X * 2, velocity.Y * 2);
			position += offset;
			for (int i = -1; i < 2; i++){
				Vector2 newspd = velocity.RotatedBy(MathHelper.ToRadians(10*i));
				Projectile.NewProjectile(Projectile.GetSource_NaturalSpawn(), position, newspd, type, 15, 2, player.whoAmI);
			}
			return false;
        }

		
	}
}