using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Weapons
{
	public class ToxicSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			   DisplayName.SetDefault("Toxic Sword");
			   Tooltip.SetDefault("Somewhat deadly");
		}
		public override void SetDefaults()
		{
			   item.melee = true;
			   item.damage = 14;
			   item.knockBack = 2;
			   item.useTime = 15;
               item.useAnimation = 25;
               item.scale = 0.9f;
               item.height = 10;
			   item.width = 10;
		   	   item.useStyle = 1;
			   item.UseSound = SoundID.Item1;
		       item.value = 28000;
			   item.rare = 2;
			   item.maxStack = 1;
               item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			     ModRecipe recipe = new ModRecipe(mod);
		         recipe.AddIngredient(ItemID.JungleSpores, 6);
				 recipe.AddIngredient(ItemID.Stinger, 6);
			     recipe.AddTile(TileID.Anvils);
		         recipe.SetResult(this);
		     	 recipe.AddRecipe();
		}
	}
}