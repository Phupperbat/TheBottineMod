using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheBottineMod.Items
{
	public class LotteryUtilityPotion : ModItem
	{
		public override void SetStaticDefaults()
 		{
 			DisplayName.SetDefault("Lottery Ticket (Utility Potion)");
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
				
				int choice = Main.rand.Next(16);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.BattlePotion, 25);
					break;
				
					case 1:
					player.QuickSpawnItem(ItemID.BuilderPotion, 25);
					break;
				
					case 2:
					player.QuickSpawnItem(ItemID.CalmingPotion, 25);
					break;
				
					case 3:
					player.QuickSpawnItem(ItemID.CratePotion, 25);
					break;
				
					case 4:
					player.QuickSpawnItem(ItemID.TrapsightPotion, 25);
					break;
					
					case 5:
					player.QuickSpawnItem(ItemID.FeatherfallPotion, 25);
					break;
					
					case 6:
					player.QuickSpawnItem(ItemID.FishingPotion, 25);
					break;
					
					case 7:
					player.QuickSpawnItem(ItemID.FlipperPotion, 25);
					break;
					
					case 8:
					player.QuickSpawnItem(ItemID.GillsPotion, 25);
					break;
					
					case 9:
					player.QuickSpawnItem(ItemID.GravitationPotion, 25);
					break;
					
					case 10:
					player.QuickSpawnItem(ItemID.MiningPotion, 25);
					break;
					
					case 11:
					player.QuickSpawnItem(ItemID.ObsidianSkinPotion, 25);
					break;
					
					case 12:
					player.QuickSpawnItem(ItemID.ShinePotion, 25);
					break;
					
					case 13:
					player.QuickSpawnItem(ItemID.SonarPotion, 25);
					break;
					
					case 14:
					player.QuickSpawnItem(ItemID.SpelunkerPotion, 25);
					break;
					
					case 15:
					player.QuickSpawnItem(ItemID.WaterWalkingPotion, 25);
					break;
					
				}
			}else if (Main.rand.Next(299) == 0){
			
				int choice = Main.rand.Next(16);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.BattlePotion, 12);
					break;
					
					case 1:
					player.QuickSpawnItem(ItemID.BuilderPotion, 12);
					break;
					
					case 2:
					player.QuickSpawnItem(ItemID.CalmingPotion, 12);
					break;
					
					case 3:
					player.QuickSpawnItem(ItemID.CratePotion, 12);
					break;
					
					case 4:
					player.QuickSpawnItem(ItemID.TrapsightPotion, 12);
					break;
					
					case 5:
					player.QuickSpawnItem(ItemID.FeatherfallPotion, 12);
					break;
					
					case 6:
					player.QuickSpawnItem(ItemID.FishingPotion, 12);
					break;
					
					case 7:
					player.QuickSpawnItem(ItemID.FlipperPotion, 12);
					break;
					
					case 8:
					player.QuickSpawnItem(ItemID.GillsPotion, 12);
					break;
					
					case 9:
					player.QuickSpawnItem(ItemID.GravitationPotion, 12);
					break;
					
					case 10:
					player.QuickSpawnItem(ItemID.MiningPotion, 12);
					break;
					
					case 11:
					player.QuickSpawnItem(ItemID.ObsidianSkinPotion, 12);
					break;
					
					case 12:
					player.QuickSpawnItem(ItemID.ShinePotion, 12);
					break;
					
					case 13:
					player.QuickSpawnItem(ItemID.SonarPotion, 12);
					break;
					
					case 14:
					player.QuickSpawnItem(ItemID.SpelunkerPotion, 12);
					break;
					
					case 15:
					player.QuickSpawnItem(ItemID.WaterWalkingPotion, 12);
					break;
					
				}
			}else if (Main.rand.Next(149) == 0){
			
				int choice = Main.rand.Next(16);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.BattlePotion, 8);
					break;
					
					case 1:
					player.QuickSpawnItem(ItemID.BuilderPotion, 8);
					break;
					
					case 2:
					player.QuickSpawnItem(ItemID.CalmingPotion, 8);
					break;
					
					case 3:
					player.QuickSpawnItem(ItemID.CratePotion, 8);
					break;
					
					case 4:
					player.QuickSpawnItem(ItemID.TrapsightPotion, 8);
					break;
					
					case 5:
					player.QuickSpawnItem(ItemID.FeatherfallPotion, 8);
					break;
					
					case 6:
					player.QuickSpawnItem(ItemID.FishingPotion, 8);
					break;
					
					case 7:
					player.QuickSpawnItem(ItemID.FlipperPotion, 8);
					break;
					
					case 8:
					player.QuickSpawnItem(ItemID.GillsPotion, 8);
					break;
					
					case 9:
					player.QuickSpawnItem(ItemID.GravitationPotion, 8);
					break;
					
					case 10:
					player.QuickSpawnItem(ItemID.MiningPotion, 8);
					break;
					
					case 11:
					player.QuickSpawnItem(ItemID.ObsidianSkinPotion, 8);
					break;
					
					case 12:
					player.QuickSpawnItem(ItemID.ShinePotion, 8);
					break;
					
					case 13:
					player.QuickSpawnItem(ItemID.SonarPotion, 8);
					break;
					
					case 14:
					player.QuickSpawnItem(ItemID.SpelunkerPotion, 8);
					break;
					
					case 15:
					player.QuickSpawnItem(ItemID.WaterWalkingPotion, 8);
					break;
					
				}
			}else if (Main.rand.Next(74) == 0){
			
				int choice = Main.rand.Next(16);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.BattlePotion, 5);
					break;
					
					case 1:
					player.QuickSpawnItem(ItemID.BuilderPotion, 5);
					break;
					
					case 2:
					player.QuickSpawnItem(ItemID.CalmingPotion, 5);
					break;
					
					case 3:
					player.QuickSpawnItem(ItemID.CratePotion, 5);
					break;
					
					case 4:
					player.QuickSpawnItem(ItemID.TrapsightPotion, 5);
					break;
					
					case 5:
					player.QuickSpawnItem(ItemID.FeatherfallPotion, 5);
					break;
					
					case 6:
					player.QuickSpawnItem(ItemID.FishingPotion, 5);
					break;
					
					case 7:
					player.QuickSpawnItem(ItemID.FlipperPotion, 5);
					break;
					
					case 8:
					player.QuickSpawnItem(ItemID.GillsPotion, 5);
					break;
					
					case 9:
					player.QuickSpawnItem(ItemID.GravitationPotion, 5);
					break;
					
					case 10:
					player.QuickSpawnItem(ItemID.MiningPotion, 5);
					break;
					
					case 11:
					player.QuickSpawnItem(ItemID.ObsidianSkinPotion, 5);
					break;
					
					case 12:
					player.QuickSpawnItem(ItemID.ShinePotion, 5);
					break;
					
					case 13:
					player.QuickSpawnItem(ItemID.SonarPotion, 5);
					break;
					
					case 14:
					player.QuickSpawnItem(ItemID.SpelunkerPotion, 5);
					break;
					
					case 15:
					player.QuickSpawnItem(ItemID.WaterWalkingPotion, 5);
					break;
					
				}
			}else if (Main.rand.Next(19) == 0){
			
				int choice = Main.rand.Next(16);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.BattlePotion, 3);
					break;
					
					case 1:
					player.QuickSpawnItem(ItemID.BuilderPotion, 3);
					break;
					
					case 2:
					player.QuickSpawnItem(ItemID.CalmingPotion, 3);
					break;
					
					case 3:
					player.QuickSpawnItem(ItemID.CratePotion, 3);
					break;
					
					case 4:
					player.QuickSpawnItem(ItemID.TrapsightPotion, 3);
					break;
					
					case 5:
					player.QuickSpawnItem(ItemID.FeatherfallPotion, 3);
					break;
					
					case 6:
					player.QuickSpawnItem(ItemID.FishingPotion, 3);
					break;
					
					case 7:
					player.QuickSpawnItem(ItemID.FlipperPotion, 3);
					break;
					
					case 8:
					player.QuickSpawnItem(ItemID.GillsPotion, 3);
					break;
					
					case 9:
					player.QuickSpawnItem(ItemID.GravitationPotion, 3);
					break;
					
					case 10:
					player.QuickSpawnItem(ItemID.MiningPotion, 3);
					break;
					
					case 11:
					player.QuickSpawnItem(ItemID.ObsidianSkinPotion, 3);
					break;
					
					case 12:
					player.QuickSpawnItem(ItemID.ShinePotion, 3);
					break;
					
					case 13:
					player.QuickSpawnItem(ItemID.SonarPotion, 3);
					break;
					
					case 14:
					player.QuickSpawnItem(ItemID.SpelunkerPotion, 3);
					break;
					
					case 15:
					player.QuickSpawnItem(ItemID.WaterWalkingPotion, 3);
					break;
					
				}
			}else if (Main.rand.Next(4) == 0){
			
				int choice = Main.rand.Next(16);
				switch (choice)
				{
					case 0:
					player.QuickSpawnItem(ItemID.BattlePotion, 1);
					break;
					
					case 1:
					player.QuickSpawnItem(ItemID.BuilderPotion, 1);
					break;
					
					case 2:
					player.QuickSpawnItem(ItemID.CalmingPotion, 1);
					break;
					
					case 3:
					player.QuickSpawnItem(ItemID.CratePotion, 1);
					break;
					
					case 4:
					player.QuickSpawnItem(ItemID.TrapsightPotion, 1);
					break;
					
					case 5:
					player.QuickSpawnItem(ItemID.FeatherfallPotion, 1);
					break;
					
					case 6:
					player.QuickSpawnItem(ItemID.FishingPotion, 1);
					break;
					
					case 7:
					player.QuickSpawnItem(ItemID.FlipperPotion, 1);
					break;
					
					case 8:
					player.QuickSpawnItem(ItemID.GillsPotion, 1);
					break;
					
					case 9:
					player.QuickSpawnItem(ItemID.GravitationPotion, 1);
					break;
					
					case 10:
					player.QuickSpawnItem(ItemID.MiningPotion, 1);
					break;
					
					case 11:
					player.QuickSpawnItem(ItemID.ObsidianSkinPotion, 1);
					break;
					
					case 12:
					player.QuickSpawnItem(ItemID.ShinePotion, 1);
					break;
					
					case 13:
					player.QuickSpawnItem(ItemID.SonarPotion, 1);
					break;
					
					case 14:
					player.QuickSpawnItem(ItemID.SpelunkerPotion, 1);
					break;
					
					case 15:
					player.QuickSpawnItem(ItemID.WaterWalkingPotion, 1);
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