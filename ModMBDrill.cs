﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MetroidModPorted.ID;

namespace MetroidModPorted
{
	public abstract class ModMBDrill : ModMBAddon
	{
		public int DrillPower { get; set; } = 0;
		internal sealed override void InternalStaticDefaults()
		{
			AddonSlot = MorphBallAddonSlotID.Drill;
		}
	}
}
