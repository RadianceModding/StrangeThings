using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace StrangeThings.Weapons
{
	public class SoulReaper : ModItem
	{
		public override void SetStaticDefaults()
		{
			   DisplayName.SetDefault("Soul Reaper");
			   Tooltip.SetDefault("Used to harvest Souls from the living");
		}
		public override void SetDefaults()
		{
			   item.melee = true;
			   item.damage = 24;
			   item.knockBack = 4;
               item.useTime = 25;
               item.useAnimation = 25;
               item.scale = 1;
			   item.height = 18;
			   item.width = 16;
		       item.useStyle = 1;
               item.UseSound = SoundID.Item1;
			   item.value = 0;
			   item.rare = 1;
               item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("MobSoul"), 12);
			recipe.AddIngredient(mod.GetItem("SoulBar"), 4);
            recipe.AddIngredient(ItemID.GoldBroadsword);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("MobSoul"), 12);
			recipe.AddIngredient(mod.GetItem("SoulBar"), 4);
            recipe.AddIngredient(ItemID.PlatinumBroadsword);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(10) == 0)
            {
                //Emit dusts when swing the sword
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 57);
            }
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, -6);
        }
    }
}
