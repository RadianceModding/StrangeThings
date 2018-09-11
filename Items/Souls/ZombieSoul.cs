using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Items.Souls
{
	public class ZombieSoul : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zombie Soul");
			Tooltip.SetDefault("The soul of a Zombie \nCan be used for items that reek of death.");
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
			recipe.AddIngredient(mod.GetItem("ZombieGuts"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 8);
			recipe.AddRecipe();
		}
	}
}
