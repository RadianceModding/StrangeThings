using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace StrangeThings.Accessories
{
	public class LargeGCoin : ModItem
	{
		public override void SetStaticDefaults()
		{
			   DisplayName.SetDefault("Large Gold Coin");
			   Tooltip.SetDefault("Compressing coins furthur gave you this. Maybe it's useful.");
		}
		public override void SetDefaults()
		{
			   item.rare = 2;
               item.maxStack = 1;
			   item.accessory = true;
			   item.defense = 12;
			   item.value = Item.sellPrice(0, 100, 0, 0);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("CompressedGCoin"), 4);
			recipe.AddIngredient(mod.GetItem("LargeSCoin"), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}