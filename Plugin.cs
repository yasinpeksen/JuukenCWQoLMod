using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using JuukenQoLMod.Config;
using System.Reflection;

namespace JuukenQoLMod
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class JuukenQoLMod : BaseUnityPlugin
    {
        private static JuukenQoLMod Instance;

        internal static JuukenQoLModConfig config { get; private set; }
        internal static new ManualLogSource Logger { get; private set; }

        private readonly Harmony harmony = new(PluginInfo.PLUGIN_GUID);

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = new JuukenQoLMod();
            }

            Logger = base.Logger;

            config = new JuukenQoLModConfig(Config);

            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
