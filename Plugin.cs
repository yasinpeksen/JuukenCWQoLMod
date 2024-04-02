using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using JuukenCWMod.Config;
using System.Reflection;

namespace JuukenCWMod
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class JuukenCWMod : BaseUnityPlugin
    {
        private static JuukenCWMod Instance;

        internal static JuukenCWModConfig config { get; private set; }
        internal static new ManualLogSource Logger { get; private set; }

        private readonly Harmony harmony = new(PluginInfo.PLUGIN_GUID);

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = new JuukenCWMod();
            }

            Logger = base.Logger;

            config = new JuukenCWModConfig(Config);

            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
