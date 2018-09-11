using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Items.Souls
{
	public class FlightSoul : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flight Soul");
			Tooltip.SetDefault("The soul of a flying creature \nCan be used for items that float above the ground");
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
			recipe.AddIngredient(ItemID.Feather);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 8);
			recipe.AddRecipe();
		}
	}
}
