using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheBottineMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class RoyalWyvernLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Royal Wyvern Leggings");
			Tooltip.SetDefault("'The leggings of a legendary dragon hunter.'"
				+ "\n+20% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 18000;
			item.rare = 10;
			item.defense = 25;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "LolitiumBar", 8);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}