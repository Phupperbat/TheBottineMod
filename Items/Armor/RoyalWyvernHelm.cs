using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheBottineMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class RoyalWyvernHelm : ModItem
	{
		
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Royal Wyvern Helm");
			Tooltip.SetDefault("'The helm of a legendary dragon hunter.'"
				+ "\n+20% crit chance");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 9;
			item.defense = 30;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeCrit += 20;
			player.rangedCrit += 20;
			player.magicCrit += 20;
			player.thrownCrit += 20;
		}
		
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("RoyalWyvernBreastplate") && legs.type == mod.ItemType("RoyalWyvernLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "30% increased damage";
			player.meleeDamage *= 1.3f;
			player.thrownDamage *= 1.3f;
			player.rangedDamage *= 1.3f;
			player.magicDamage *= 1.3f;
			player.minionDamage *= 1.3f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddIngredient(ItemID.FragmentVortex, 10);
			recipe.AddIngredient(ItemID.FragmentNebula, 10);
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddIngredient(ItemID.FragmentStardust, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}