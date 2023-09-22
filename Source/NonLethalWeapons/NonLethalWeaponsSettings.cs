using Verse;

namespace NonLethalWeapons;

/// <summary>
///     Definition of the settings for the mod
/// </summary>
internal class NonLethalWeaponsSettings : ModSettings
{
    public bool TranquilizerPuking = true;

    /// <summary>
    ///     Saving and loading the values
    /// </summary>
    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref TranquilizerPuking, "TranquilizerPuking", true);
    }
}