using System;
using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.CrewmateRoles.TransporterMod
{
    [HarmonyPatch(typeof(IntroCutscene._CoBegin_d__29), nameof(IntroCutscene._CoBegin_d__29.MoveNext))]
    public static class Start
    {
        public static void Postfix(IntroCutscene._CoBegin_d__29 __instance)
        {
            foreach (var role in Role.GetRoles(RoleEnum.Transporter))
            {
                var transporter = (Transporter) role;
                transporter.LastTransported = DateTime.UtcNow;
                transporter.LastTransported = transporter.LastTransported.AddSeconds(CustomGameOptions.InitialCooldowns - CustomGameOptions.TransportCooldown);
            }
        }
    }
}