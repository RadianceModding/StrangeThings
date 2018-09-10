/*
// Version 3.0
using Terraria;
using Terraria.ModLoader;
 
class MyGlobalNPC : GlobalNPC
{
    public override void NPCLoot(NPC npc)
    {
        if(npc.type == NPCID.Count)
        {
            Item.NewItem(npc.getRect(), mod.ItemType("MobSoul");
        }
    }
}

// Version 2.0
class MyGlobalNPC : GlobalNPC
{
    public override void NPCLoot(NPC npc)
    {
        if(npc.type == NPCID.Count)
        {
            Item.NewItem(npc.getRect(), mod.ItemType("MobSoul");
        }
    }
}

// Version 1.0
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public override void NPCLoot()
{
	Item.NewItem(npc.getRect(), mod.ItemType("MobSoul"));
}
*/