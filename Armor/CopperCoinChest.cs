using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class CopperCoinChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Copper Coin Chainmail");
			Tooltip.SetDefault("A piece of chainmail crafted out of money. \nYou feel richer while wearing it.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 100;
			item.defense = 5;
			item.rare = 1;
			item.value = Item.sellPrice(0, 0, 2, 0);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("CopperCoinHelmet") && legs.type == mod.ItemType("CopperCoinLegs");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.meleeDamage *= 1.0f;
			player.thrownDamage *= 1.0f;
			player.rangedDamage *= 1.0f;
			player.magicDamage *= 1.0f;
			player.minionDamage *= 1.0f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
	        recipe.AddIngredient(mod.GetItem("LargeCCoin"), 2);
		    recipe.AddIngredient(ItemID.CopperChainmail);
		    recipe.AddTile(TileID.Anvils);
		    recipe.SetResult(this);
		    recipe.AddRecipe();
		}
	}
}