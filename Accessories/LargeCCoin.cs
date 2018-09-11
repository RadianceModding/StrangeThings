using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace StrangeThings.Accessories
{
	public class LargeCCoin : ModItem
	{
		public override void SetStaticDefaults()
		{
			   DisplayName.SetDefault("Large Copper Coin");
			   Tooltip.SetDefault("Compressing coins furthur gave you this. Maybe it's useful.");
		}
		public override void SetDefaults()
		{
			   item.rare = 0;
               item.maxStack = 1;
			   item.accessory = true;
			   item.defense = 1;
			   item.value = Item.sellPrice(0, 0, 0, 100);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("CompressedCCoin"), 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}