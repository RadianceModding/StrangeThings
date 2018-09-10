using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace StrangeThings.Items
{
	public class CompressedSCoin : ModItem
	{
		public override void SetStaticDefaults()
		{
			   DisplayName.SetDefault("Compressed Silver Coins");
			   Tooltip.SetDefault("A small stack of Silver coins that has been compressed");
		}
		public override void SetDefaults()
		{
			   item.rare = 0;
               item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverCoin, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}