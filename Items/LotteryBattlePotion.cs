using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheBottineMod.Items
{
	public class LotteryBattlePotion : ModItem
	{
		public override void SetStaticDefaults()
 		{
 			DisplayName.SetDefault("Lottery Ticket (Battle Potion)");
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
			if (Main.rand.Next(749) == 0){
				
				int choice = Main.rand.Next(11);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.ArcheryPotion, 25);
					break;
				
					case 1:
					player.QuickSpawnItem(ItemID.EndurancePotion, 25);
					break;
				
					case 2:
					player.QuickSpawnItem(ItemID.HeartreachPotion, 25);
					break;
					
					case 3:
					player.QuickSpawnItem(ItemID.IronskinPotion, 25);
					break;
				
					case 4:
					player.QuickSpawnItem(ItemID.LifeforcePotion, 25);
					break;
				
					case 5:
					player.QuickSpawnItem(ItemID.MagicPowerPotion, 25);
					break;
				
					case 6:
					player.QuickSpawnItem(ItemID.RagePotion, 25);
					break;
				
					case 7:
					player.QuickSpawnItem(ItemID.RegenerationPotion, 25);
					break;
					
					case 8:
					player.QuickSpawnItem(ItemID.SummoningPotion, 25);
					break;
				
					case 9:
					player.QuickSpawnItem(ItemID.SwiftnessPotion, 25);
					break;
				
					case 10:
					player.QuickSpawnItem(ItemID.WrathPotion, 25);
					break;
				
				}
			}else if (Main.rand.Next(299) == 0){
			
				int choice = Main.rand.Next(11);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.ArcheryPotion, 12);
					break;
				
					case 1:
					player.QuickSpawnItem(ItemID.EndurancePotion, 12);
					break;
				
					case 2:
					player.QuickSpawnItem(ItemID.HeartreachPotion, 12);
					break;
				
					case 3:
					player.QuickSpawnItem(ItemID.IronskinPotion, 12);
					break;
				
					case 4:
					player.QuickSpawnItem(ItemID.LifeforcePotion, 12);
					break;
				
					case 5:
					player.QuickSpawnItem(ItemID.MagicPowerPotion, 12);
					break;
				
					case 6:
					player.QuickSpawnItem(ItemID.RagePotion, 12);
					break;
				
					case 7:
					player.QuickSpawnItem(ItemID.RegenerationPotion, 12);
					break;
				
					case 8:
					player.QuickSpawnItem(ItemID.SummoningPotion, 12);
					break;
				
					case 9:
					player.QuickSpawnItem(ItemID.SwiftnessPotion, 12);
					break;
				
					case 10:
					player.QuickSpawnItem(ItemID.WrathPotion, 12);
					break;
				
				}
			}else if (Main.rand.Next(149) == 0){
			
				int choice = Main.rand.Next(11);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.ArcheryPotion, 8);
					break;
				
					case 1:
					player.QuickSpawnItem(ItemID.EndurancePotion, 8);
					break;
				
					case 2:
					player.QuickSpawnItem(ItemID.HeartreachPotion, 8);
					break;
				
					case 3:
					player.QuickSpawnItem(ItemID.IronskinPotion, 8);
					break;
				
					case 4:
					player.QuickSpawnItem(ItemID.LifeforcePotion, 8);
					break;
				
					case 5:
					player.QuickSpawnItem(ItemID.MagicPowerPotion, 8);
					break;
				
					case 6:
					player.QuickSpawnItem(ItemID.RagePotion, 8);
					break;
				
					case 7:
					player.QuickSpawnItem(ItemID.RegenerationPotion, 8);
					break;
				
					case 8:
					player.QuickSpawnItem(ItemID.SummoningPotion, 8);
					break;
				
					case 9:
					player.QuickSpawnItem(ItemID.SwiftnessPotion, 8);
					break;
				
					case 10:
					player.QuickSpawnItem(ItemID.WrathPotion, 8);
					break;
				
				}
			}else if (Main.rand.Next(74) == 0){
			
				int choice = Main.rand.Next(11);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.ArcheryPotion, 5);
					break;
				
					case 1:
					player.QuickSpawnItem(ItemID.EndurancePotion, 5);
					break;
				
					case 2:
					player.QuickSpawnItem(ItemID.HeartreachPotion, 5);
					break;
				
					case 3:
					player.QuickSpawnItem(ItemID.IronskinPotion, 5);
					break;
				
					case 4:
					player.QuickSpawnItem(ItemID.LifeforcePotion, 5);
					break;
				
					case 5:
					player.QuickSpawnItem(ItemID.MagicPowerPotion, 5);
					break;
				
					case 6:
					player.QuickSpawnItem(ItemID.RagePotion, 5);
					break;
				
					case 7:
					player.QuickSpawnItem(ItemID.RegenerationPotion, 5);
					break;
				
					case 8:
					player.QuickSpawnItem(ItemID.SummoningPotion, 5);
					break;
				
					case 9:
					player.QuickSpawnItem(ItemID.SwiftnessPotion, 5);
					break;
				
					case 10:
					player.QuickSpawnItem(ItemID.WrathPotion, 5);
					break;
				
				}
			}else if (Main.rand.Next(19) == 0){
			
				int choice = Main.rand.Next(11);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.ArcheryPotion, 3);
					break;
				
					case 1:
					player.QuickSpawnItem(ItemID.EndurancePotion, 3);
					break;
				
					case 2:
					player.QuickSpawnItem(ItemID.HeartreachPotion, 3);
					break;
				
					case 3:
					player.QuickSpawnItem(ItemID.IronskinPotion, 3);
					break;
				
					case 4:
					player.QuickSpawnItem(ItemID.LifeforcePotion, 3);
					break;
				
					case 5:
					player.QuickSpawnItem(ItemID.MagicPowerPotion, 3);
					break;
				
					case 6:
					player.QuickSpawnItem(ItemID.RagePotion, 3);
					break;
				
					case 7:
					player.QuickSpawnItem(ItemID.RegenerationPotion, 3);
					break;
				
					case 8:
					player.QuickSpawnItem(ItemID.SummoningPotion, 3);
					break;
				
					case 9:
					player.QuickSpawnItem(ItemID.SwiftnessPotion, 3);
					break;
				
					case 10:
					player.QuickSpawnItem(ItemID.WrathPotion, 3);
					break;
				
				}
			}else if (Main.rand.Next(4) == 0){
			
				int choice = Main.rand.Next(11);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.ArcheryPotion, 1);
					break;
				
					case 1:
					player.QuickSpawnItem(ItemID.EndurancePotion, 1);
					break;
				
					case 2:
					player.QuickSpawnItem(ItemID.HeartreachPotion, 1);
					break;
				
					case 3:
					player.QuickSpawnItem(ItemID.IronskinPotion, 1);
					break;
				
					case 4:
					player.QuickSpawnItem(ItemID.LifeforcePotion, 1);
					break;
				
					case 5:
					player.QuickSpawnItem(ItemID.MagicPowerPotion, 1);
					break;
				
					case 6:
					player.QuickSpawnItem(ItemID.RagePotion, 1);
					break;
					
					case 7:
					player.QuickSpawnItem(ItemID.RegenerationPotion, 1);
					break;
				
					case 8:
					player.QuickSpawnItem(ItemID.SummoningPotion, 1);
					break;
				
					case 9:
					player.QuickSpawnItem(ItemID.SwiftnessPotion, 1);
					break;
				
					case 10:
					player.QuickSpawnItem(ItemID.WrathPotion, 1);
					break;
				
				}
			}
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}