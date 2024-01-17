using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using NoSteam.Patches;

namespace NoSteam;

[BepInPlugin(modGUID, modName, modVersion)]
public class NoSteamBase : BaseUnityPlugin
{
    private const string modGUID = "tamion.NoSteam";
    private const string modName = "NoSteam";
    private const string modVersion = "1.0.0";
    
    private readonly Harmony harmony = new Harmony(modGUID);
    internal ManualLogSource logger;
    
    private void Awake()
    {
        logger = BepInEx.Logging.Logger.CreateLogSource(modGUID);
        logger.LogInfo("NoSteam loaded");
        
        harmony.PatchAll(typeof(NoSteamPatch));
    }
}