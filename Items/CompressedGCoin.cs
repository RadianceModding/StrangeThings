using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace StrangeThings.Items
{
	public class CompressedGCoin : ModItem
	{
		public override void SetStaticDefaults()
		{
			   DisplayName.SetDefault("Compressed Gold Coins");
			   Tooltip.SetDefault("A small stack of Gold coins that has been compressed");
		}
		public override void SetDefaults()
		{
			   item.rare = 1;
               item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldCoin, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}