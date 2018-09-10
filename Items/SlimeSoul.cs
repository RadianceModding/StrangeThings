using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Items
{
	public class SlimeSoul : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slime Soul");
			Tooltip.SetDefault("The soul of a common Slime. \nCan be used for bouncy and slimy items.");
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
			recipe.AddIngredient(mod.GetItem("MobSoul"), 1);
			recipe.AddIngredient(ItemID.Gel, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 4);
			recipe.AddIngredient(ItemID.Gel, 16);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 16);
			recipe.AddIngredient(ItemID.Gel, 64);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 16);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 64);
			recipe.AddIngredient(ItemID.Gel, 256);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 64);
			recipe.AddRecipe();
		}
	}
}
