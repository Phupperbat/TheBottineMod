using System;
using TheBottineMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheBottineMod.Items.Weapons
{
	public class RoyalWyvernSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Royal Wyvern Spear");
			Tooltip.SetDefault("'A powerful spear, once owned by a legendary (and small) dragon hunter.'");
		}
		
		public override void SetDefaults()
		{
			item.damage = 300;
			item.useStyle = 5;
			item.useAnimation = 17;
			item.useTime = 17;
			item.shootSpeed = 3f;
			item.knockBack = 6f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 9;
			item.value = Item.sellPrice(platinum: 1);

			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.autoReuse = true;

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<RoyalWyvernSpearProjectile>();
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1; 
		}
	}
}
