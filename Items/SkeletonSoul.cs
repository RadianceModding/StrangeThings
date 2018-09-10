using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Items
{
	public class SkeletonSoul : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Skeleton Soul");
			Tooltip.SetDefault("The soul of a Skeleton \nCan be used for items that crunch when touched");
		}
		public override void SetDefaults()
		{
			item.value = 0;
			item.rare = 0;
			item.maxStack = 9999;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 8);
		    recipe.AddIngredient(ItemID.Bone, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 8);
			recipe.AddRecipe();
		}
	}
}
