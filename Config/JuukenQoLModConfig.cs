using System;
using BepInEx.Configuration;

namespace JuukenQoLMod.Config
{
    internal class JuukenQoLModConfig
    {
        internal ConfigEntry<float> VIDEO_CLIP_DURATION;

        internal JuukenQoLModConfig(ConfigFile cfgFile)
        {
            VIDEO_CLIP_DURATION = cfgFile.Bind<float>("Duration", "VideoClipDuration", 180f, "How many seconds the camera can record?" + Environment.NewLine + "Game default is 90.");
        }
    }
}
