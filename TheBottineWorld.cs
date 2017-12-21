using System.IO;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;

namespace TheBottineMod
{
	public class TheBottineWorld : ModWorld
	{
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1)
			{
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Lolitium Ore", delegate (GenerationProgress progress)
				{
					progress.Message = "Lolitium Ore";
					int x = Main.maxTilesX;
					int y = Main.maxTilesY;
					int genLimit = x / 2;
					int generateBack = genLimit - 80; //Small = 2020
					int generateForward = genLimit + 80; //Small = 2180
					for (int k = 0; k < (int)((double)(x * y) * 15E-05); k++)
					{
						int tilesX = WorldGen.genRand.Next(0, generateBack);
						int tilesX2 = WorldGen.genRand.Next(generateForward, x);
						int tilesY = WorldGen.genRand.Next((int)(Main.maxTilesY * .4f), (int)(Main.maxTilesY * .8f));
						if (Main.tile[tilesX, tilesY].type == 0 || Main.tile[tilesX, tilesY].type == 1) 
						{
							WorldGen.OreRunner(tilesX, tilesY, (double)WorldGen.genRand.Next(3, 8), WorldGen.genRand.Next(3, 8), (ushort)mod.TileType("LolitiumOre"));
						}
						if (Main.tile[tilesX2, tilesY].type == 0 || Main.tile[tilesX2, tilesY].type == 1) 
						{
							WorldGen.OreRunner(tilesX2, tilesY, (double)WorldGen.genRand.Next(3, 8), WorldGen.genRand.Next(3, 8), (ushort)mod.TileType("LolitiumOre"));
						}
					}	
				}));
			}
		}
	}
}