using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Items
{
	public class SoulOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul Ore");
			Tooltip.SetDefault("An ore with some Soul Power.\nSadly, it's only around 15% pure");
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
			recipe.AddIngredient(ItemID.CopperOre, 3);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}