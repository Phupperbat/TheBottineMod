using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheBottineMod.Items
{
	public class LotteryCoin : ModItem
	{
		public override void SetStaticDefaults()
 		{
 			DisplayName.SetDefault("Lottery Ticket (Coin)");
 			Tooltip.SetDefault("Right click to open and get your prize!");
 		}
		
		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 18;
			item.height = 24;
			item.rare = 10;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			if (Main.rand.Next(9999) == 0){
			
				player.QuickSpawnItem(ItemID.PlatinumCoin, 9999);
			
			}else if (Main.rand.Next(4999) == 0){
			
				player.QuickSpawnItem(ItemID.PlatinumCoin, 1000);
			
			}else if (Main.rand.Next(999) == 0){
			
				player.QuickSpawnItem(ItemID.PlatinumCoin, 100);
			
			}else if (Main.rand.Next(499) == 0){
			
				player.QuickSpawnItem(ItemID.PlatinumCoin, 25);
				
			}else if (Main.rand.Next(249) == 0){
			
				player.QuickSpawnItem(ItemID.PlatinumCoin, 5);
			
			}else if (Main.rand.Next(74) == 0){
				
				player.QuickSpawnItem(ItemID.PlatinumCoin);
				
			}else if (Main.rand.Next(24) == 0){
				
				player.QuickSpawnItem(ItemID.GoldCoin, 5);
				
			}else if(Main.rand.Next(9) == 0){
				
				player.QuickSpawnItem(ItemID.SilverCoin, 99);
				
			}else if(Main.rand.Next(2) == 0){
				
				player.QuickSpawnItem(ItemID.SilverCoin, 50);
				
			}else
				player.QuickSpawnItem(ItemID.SilverCoin);
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldCoin, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}