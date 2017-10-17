using Terraria.ID;
using Terraria.ModLoader;

namespace TheBottineMod.Items.Bars
{
	public class LolitiumBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Such a small bar shouldn't contain so much power...'");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 16000;
			item.rare = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 1);
			recipe.AddIngredient(ItemID.FragmentVortex, 3);
			recipe.AddIngredient(ItemID.FragmentNebula, 3);
			recipe.AddIngredient(ItemID.FragmentSolar, 3);
			recipe.AddIngredient(ItemID.FragmentStardust, 3);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}