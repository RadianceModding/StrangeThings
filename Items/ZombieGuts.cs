using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Items
{
	public class ZombieGuts : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zombie Guts");
			Tooltip.SetDefault("Ewwww....maybe it's useful though.");
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
			recipe.AddIngredient(ItemID.GoldCoin, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
