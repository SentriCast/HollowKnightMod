using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace HollowKnightMod.Items
{
	public class OldNail : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Old Nail");
			Tooltip.SetDefault("The remains of an old nail, wilted with age.");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType("OldNail");
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = false;
            item.noMelee = true;
            item.shootSpeed = 0f;
        }

        /*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);               we should probably change this -s
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(item);
			recipe.AddRecipe();
		}*/
    }
}
