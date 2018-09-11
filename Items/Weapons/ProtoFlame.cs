using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Weapons
{
	public class ProtoFlame : ModItem
	{
		public override void SetStaticDefaults()
		{
			   DisplayName.SetDefault("Prototype Flamethrower");
			   Tooltip.SetDefault("You can probably improve it later, but for now this works.");
		}
		public override void SetDefaults()
		{
			   item.ranged = true;
			   item.damage = 10;
			   item.knockBack = 1;
			   item.useTime = 15;
               item.useAnimation = 19;
               item.scale = 0.9f;
               item.height = 15;
			   item.width = 15;
		   	   item.useStyle = 5;
			   item.UseSound = SoundID.Item1;
		       item.value = 0;
			   item.rare = 1;
			   item.useAmmo = 23;
			   item.maxStack = 1;
               item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			     ModRecipe recipe = new ModRecipe(mod);
	             recipe.AddIngredient(mod.GetItem("SlimeSoul"), 4);
				 recipe.AddIngredient(mod.GetItem("SoulBar"), 1);
		         recipe.AddIngredient(ItemID.FlintlockPistol);
			     recipe.AddTile(TileID.Anvils);
		         recipe.SetResult(this);
		     	 recipe.AddRecipe();
		}
	}
}