using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Items.Blocks
{
    public class SoulInfuser : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("[WIP] Soul Infuser");
			Tooltip.SetDefault("Used for infusing unstable souls into usable items");
		}
        public override void SetDefaults()
		{
            item.width = 28;
            item.height = 15;
            item.maxStack = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 25;
            item.createTile = mod.TileType("SoulInfuser");
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 8);
			recipe.AddIngredient(ItemID.Furnace, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
