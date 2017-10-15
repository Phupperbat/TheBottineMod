using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheBottineMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class RoyalWyvernBreastplate : ModItem
	{
		
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Royal Wyvern Breastplate");
			Tooltip.SetDefault("'The breastplate of a legendary dragon hunter.'"
				+ "\nImmunity to all fire based debuffs"
				+ "\n+3 Max Minions"
				+ "\n+100 Max Life"
				+ "\n+50 Max Mana"
				+ "\n+3 Life Regen");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 9;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.CursedInferno] = true;
			player.buffImmune[BuffID.Frostburn] = true;
			player.buffImmune[BuffID.Burning] = true;
			player.buffImmune[BuffID.ShadowFlame] = true;
			player.maxMinions += 3;
			player.statLifeMax2 += 100;
			player.statManaMax2 += 50;
			player.lifeRegen += 3;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 15);
			recipe.AddIngredient(ItemID.FragmentVortex, 30);
			recipe.AddIngredient(ItemID.FragmentNebula, 30);
			recipe.AddIngredient(ItemID.FragmentSolar, 30);
			recipe.AddIngredient(ItemID.FragmentStardust, 30);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}