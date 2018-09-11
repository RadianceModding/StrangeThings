using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Items.Souls
{
	public class MobSoul : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Generic Soul");
			Tooltip.SetDefault("The soul of every monster. Not specialized, but still useful");
		}
		public override void SetDefaults()
		{
			item.value = 0;
			item.rare = -1;
			item.maxStack = 9999;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperCoin, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverCoin, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldCoin, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 16);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumCoin, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 64);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumCoin, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 640);
			recipe.AddRecipe();
		}
	}
}
