using Terraria.ModLoader;

namespace HollowKnightMod
{
	public class HollowKnightMod : Mod
	{
		public HollowKnightMod()
		{
		}
        public override void Load()
        {
        OriginalLifeCrystalTexture = Main.itemTexture[29];
        Main.itemTexture[29] = this.GetTexture("Textures/Mask_Shard");
        }
        public static Texture2D OriginalLifeCrystalTexture;
        public override void Unload()
        {
        Main.itemTexture[29] = OriginalLifeCrystalTexture;
        }
    }
}