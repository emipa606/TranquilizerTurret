using Mlie;
using UnityEngine;
using Verse;

namespace NonLethalWeapons;

[StaticConstructorOnStartup]
internal class NonLethalWeaponsMod : Mod
{
    /// <summary>
    ///     The instance of the settings to be read by the mod
    /// </summary>
    public static NonLethalWeaponsMod instance;

    private static string currentVersion;

    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="content"></param>
    public NonLethalWeaponsMod(ModContentPack content) : base(content)
    {
        instance = this;
        Settings = GetSettings<NonLethalWeaponsSettings>();
        currentVersion = VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
    }

    /// <summary>
    ///     The instance-settings for the mod
    /// </summary>
    internal NonLethalWeaponsSettings Settings { get; }

    /// <summary>
    ///     The title for the mod-settings
    /// </summary>
    /// <returns></returns>
    public override string SettingsCategory()
    {
        return "Non Lethal Weapons";
    }

    /// <summary>
    ///     The settings-window
    ///     For more info: https://rimworldwiki.com/wiki/Modding_Tutorials/ModSettings
    /// </summary>
    /// <param name="rect"></param>
    public override void DoSettingsWindowContents(Rect rect)
    {
        var listing_Standard = new Listing_Standard();
        listing_Standard.Begin(rect);
        listing_Standard.Gap();
        listing_Standard.CheckboxLabeled("NLW.TranquilizerPuking".Translate(), ref Settings.TranquilizerPuking);
        if (currentVersion != null)
        {
            listing_Standard.Gap();
            GUI.contentColor = Color.gray;
            listing_Standard.Label("NLW.ModVersion".Translate(currentVersion));
            GUI.contentColor = Color.white;
        }

        listing_Standard.End();
    }
}