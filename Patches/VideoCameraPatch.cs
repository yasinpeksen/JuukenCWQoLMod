using HarmonyLib;

namespace JuukenCWMod.Patches
{
    [HarmonyPatch(typeof(VideoCamera))]
    internal class VideoCameraPatch
    {

        [HarmonyPostfix]
        [HarmonyPatch("ConfigItem")]
        private static void CameraTimePatch(ref VideoInfoEntry ___m_recorderInfoEntry)
        {
            if (___m_recorderInfoEntry.maxTime == 90f)
            {
                float maxRecordTime = JuukenCWMod.config.VIDEO_CLIP_DURATION.Value;
                ___m_recorderInfoEntry.maxTime = maxRecordTime;
                ___m_recorderInfoEntry.timeLeft = maxRecordTime;
                ___m_recorderInfoEntry.SetDirty();
                JuukenCWMod.Logger.LogInfo($"Changed camera max record time to {maxRecordTime}");
            }
        }
    }
}
