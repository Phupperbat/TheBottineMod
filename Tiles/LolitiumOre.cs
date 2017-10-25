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
			dustType = mod.DustType("Sparkle");
			drop = mod.ItemType("LolitiumOre");
			AddMapEntry(new Color(255, 96, 138));
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