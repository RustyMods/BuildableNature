using HarmonyLib;

namespace BuildableNature;

// [HarmonyPatch(typeof(ObjectFlicker), nameof(ObjectFlicker.Awake))]
// public static class ObjectFlicker_Awake_Patch
// {
//     private static void Postfix(ObjectFlicker __instance)
//     {
//         var piece = __instance.GetComponentInParent<Piece>();
//         if (piece == null) return;
//
//         if (piece.gameObject == Player.m_localPlayer?.m_placementGhost)
//         {
//             __instance.enabled = false;
//         }
//     }
// }