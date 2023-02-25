using System.Collections.Generic;
using Verse;

namespace NonLethalWeapons;

public class ThingDef_NLW_HediffBullet : ThingDef
{
    public float AddHediffChance;

    public List<HediffDef> HediffsToAdd;
}