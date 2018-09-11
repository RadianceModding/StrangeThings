using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Items
{
	public class SoulBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul Bar");
			Tooltip.SetDefault("A concentrated ingot of Soul Power.\nSadly, it's only around 50% pure");
		}
		  public override void SetDefaults()
		{
		    item.rare = 1;
			item.value = 0;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulOre"), 3);
			recipe.AddIngredient(ItemID.IronOre);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}