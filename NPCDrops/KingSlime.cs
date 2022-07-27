using Terraria.GameContent.ItemDropRules;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using TestRepos;

namespace TestRepos
{
	public class KingSlime : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
		{
			if (npc.type == NPCID.KingSlime)
			{
				npcLoot.Add(ItemDropRule.BossBag(ModContent.ItemType<Items.BasicSword>()));
				npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.BasicSword>(), 2, 1, 1));
			}
		}
	}
}