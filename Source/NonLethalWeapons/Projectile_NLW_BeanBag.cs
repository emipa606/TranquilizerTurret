using System;
using RimWorld;
using Verse;

namespace NonLethalWeapons;

public class Projectile_NLW_BeanBag : Bullet
{
    private ThingDef_NLW_HediffBullet Def => def as ThingDef_NLW_HediffBullet;

    protected override void Impact(Thing hitThing, bool blockedByShield = false)
    {
        base.Impact(hitThing, blockedByShield);
        if (Def == null || hitThing is not Pawn pawn || !pawn.RaceProps.IsFlesh)
        {
            return;
        }

        foreach (var item in Def.HediffsToAdd)
        {
            if (!(Rand.Value <= Def.AddHediffChance))
            {
                continue;
            }

            var actualHediff = item;
            if (!NonLethalWeaponsMod.Instance.Settings.TranquilizerPuking)
            {
                actualHediff = DefDatabase<HediffDef>.GetNamedSilentFail($"{item.defName}_Nobarf") ?? item;
            }

            var hediff = pawn.health?.hediffSet?.GetFirstHediffOfDef(actualHediff);
            var num = Rand.Range(0.125f, 0.3f) / (float)Math.Pow(pawn.RaceProps.baseBodySize, 1.5);
            if (hediff != null)
            {
                hediff.Severity += num;
                continue;
            }

            var hediff2 = HediffMaker.MakeHediff(actualHediff, pawn);
            hediff2.Severity = num;
            pawn.health?.AddHediff(hediff2);
        }
    }
}