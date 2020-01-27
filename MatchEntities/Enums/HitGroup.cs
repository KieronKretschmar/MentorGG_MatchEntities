using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities.Enums
{
	/// <summary>
	/// Copied from DemoInfo. Keep in sync when applying changes to either of them.
	/// </summary>
	public enum HitGroup : byte
	{
		Generic = 0,
		Head = 1,
		Chest = 2,
		Stomach = 3,
		LeftArm = 4,
		RightArm = 5,
		LeftLeg = 6,
		RightLeg = 7,
		Gear = 10,
	};
}
