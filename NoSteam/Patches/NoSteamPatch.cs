using HarmonyLib;

namespace NoSteam.Patches;

[HarmonyPatch(typeof(SteamValveHazard))]
public class NoSteamPatch
{

    [HarmonyPatch("Start")]
    [HarmonyPostfix]
    static void patchStart(ref bool ___valveHasBeenRepaired)
    {
        ___valveHasBeenRepaired = true;
    }
}