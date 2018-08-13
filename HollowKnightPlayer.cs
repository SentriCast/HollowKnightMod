using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace HollowKnightMod
{
    class HollowKnightPlayer : ModPlayer
    {
        public override void SetupStartInventory(IList<Item> items)
        {
            player.inventory[0].SetDefaults(mod.ItemType("OldNail"));
        }
    }
}
