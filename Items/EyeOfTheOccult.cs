using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using TestRepos.Projectiles;


namespace TestRepos.Items
{
	public class EyeOfTheOccult : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eye of The Occult"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("You feel... Disgusted"); // Spits Homing blood shots
		}

		public override void SetDefaults()
		{
			Item.damage = 34;
			Item.DamageType = DamageClass.Melee;
			Item.width = 100;
			Item.scale = 2.5f;
			Item.height = 100;
			Item.useTime = 34;
			Item.useAnimation = 34;
			Item.useStyle = 1;
			Item.value = 10000;
			Item.rare = 2;
			Item.knockBack = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<EyeOfTheOccultProj>();
			Item.shootSpeed = 2.5f;
		}

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
			Vector2 offset = new Vector2(velocity.X * 2, velocity.Y * 2);
			position += offset;
			Projectile.NewProjectile(Projectile.GetSource_NaturalSpawn(), position, velocity, type, 35, 4, player.whoAmI);
			return false;
        }

		
	}
}