using HarmonyLib;
using UnityEngine;

namespace LCInstantBridge.Patches
{
    [HarmonyPatch(typeof(BridgeTrigger))]
    [HarmonyPatch("Update")]
    internal class BridgeTriggerUpdatePatch
    {
        private static void Postfix(BridgeTrigger __instance)
        {
            // Modify bridgeDurability as needed
            __instance.bridgeDurability = Mathf.Clamp(__instance.bridgeDurability - Time.deltaTime * 0.1f, 0f, 1f)*0.001f;
        }
    }
}
