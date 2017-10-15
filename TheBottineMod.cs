using Terraria.ModLoader;

namespace TheBottineMod
{
	class TheBottineMod : Mod
	{
		public TheBottineMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
