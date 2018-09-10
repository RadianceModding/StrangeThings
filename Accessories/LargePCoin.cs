using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace StrangeThings.Accessories
{
	public class LargePCoin : ModItem
	{
		public override void SetStaticDefaults()
		{
			   DisplayName.SetDefault("Large Platinum Coin");
			   Tooltip.SetDefault("Compressing coins furthur gave you this. Maybe it's useful.");
		}
		public override void SetDefaults()
		{
			   item.rare = 3;
               item.maxStack = 1;
			   item.accessory = true;
			   item.defense = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("CompressedPCoin"), 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}