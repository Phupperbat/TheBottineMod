using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheBottineMod.Tiles
{
	public class LolitiumOre : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			mineResist = 5f;
			minPick = 225;
			drop = mod.ItemType("LolitiumOre");
			dustType = mod.DustType("AHSparkle");
			soundType = 21;
			ModTranslation name = CreateMapEntryName();
 			name.SetDefault("Lolitium Ore");
			AddMapEntry(new Color(255, 96, 138));
			Main.tileSpelunker[Type] = true;
		}

		public override bool CanExplode(int i, int j) 
		{
		return false;
		}
		
		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 1.1f;
			g = 0.5f;
			b = 0.7f;
		}
	}
}