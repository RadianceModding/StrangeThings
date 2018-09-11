using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Weapons
{
	public class SoulDagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			   DisplayName.SetDefault("Soul Dagger");
			   Tooltip.SetDefault("Legends tell of a man who weilded this dagger, \nusing it to slay all who opposed him while he climbed a great Spire");
		}
		public override void SetDefaults()
		{
			   item.melee = true;
			   item.damage = 15;
			   item.knockBack = 3;
			   item.useTime = 15;
               item.useAnimation = 19;
               item.scale = 0.9f;
               item.height = 17;
			   item.width = 17;
		   	   item.useStyle = 3;
			   item.UseSound = SoundID.Item1;
		       item.value = 0;
			   item.rare = 1;
			   item.maxStack = 1;
		}

		public override void AddRecipes()
		{
			     ModRecipe recipe = new ModRecipe(mod);
	             recipe.AddIngredient(mod.GetItem("MobSoul"), 8);
				 recipe.AddIngredient(mod.GetItem("SoulBar"), 2);
		         recipe.AddIngredient(ItemID.GoldShortsword);
			     recipe.AddTile(TileID.Anvils);
		         recipe.SetResult(this);
		     	 recipe.AddRecipe();

			     recipe = new ModRecipe(mod);
			     recipe.AddIngredient(mod.GetItem("MobSoul"), 8);
			     recipe.AddIngredient(ItemID.PlatinumShortsword);
			     recipe.AddTile(TileID.Anvils);
			     recipe.SetResult(this);
			     recipe.AddRecipe();
		}
	}
}