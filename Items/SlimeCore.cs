using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Items
{
	public class SlimeCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slime Core");
			Tooltip.SetDefault("The core of a Slime.\nThese hold slimes together, and without them they cannot survive");
		}
		  public override void SetDefaults()
		{
		    item.rare = 0;
			item.value = 0;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SlimeCore"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.SlimeStaff);
			recipe.AddRecipe();
		}
	}
}