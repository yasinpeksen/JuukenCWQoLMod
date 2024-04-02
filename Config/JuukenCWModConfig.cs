using System;
using BepInEx.Configuration;

namespace JuukenCWMod.Config
{
    internal class JuukenCWModConfig
    {
        internal ConfigEntry<float> VIDEO_CLIP_DURATION;

        internal JuukenCWModConfig(ConfigFile cfgFile)
        {
            VIDEO_CLIP_DURATION = cfgFile.Bind<float>("Duration", "VideoClipDuration", 180f, "How many seconds the camera can record?" + Environment.NewLine + "Game default is 90.");
        }
    }
}
