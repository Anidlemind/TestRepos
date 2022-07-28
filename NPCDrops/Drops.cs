using Terraria.GameContent.ItemDropRules;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using TestRepos;

namespace TestRepos
{
	public class Drops : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
		{
			if (npc.type == NPCID.KingSlime)
			{   
				npcLoot.Add(ItemDropRule.MasterModeCommonDrop(ModContent.ItemType<Items.BasicSword>()));
			}
			if (npc.type == NPCID.EyeofCthulhu)
			{
				npcLoot.Add(ItemDropRule.MasterModeCommonDrop(ModContent.ItemType<Items.EyeOfTheOccult>()));
			}
		}
	}
}