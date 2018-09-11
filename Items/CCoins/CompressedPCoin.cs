using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace StrangeThings.Items.CCoins
{
	public class CompressedPCoin : ModItem
	{
		public override void SetStaticDefaults()
		{
			   DisplayName.SetDefault("Compressed Platinum Coins");
			   Tooltip.SetDefault("A small stack of Platinum coins that has been compressed");
		}
		public override void SetDefaults()
		{
			   item.rare = 2;
               item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumCoin, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}