using System.Collections.Generic;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Medic : Role
    {
        public readonly List<GameObject> Buttons = new List<GameObject>();
        public Dictionary<int, string> LightDarkColors = new Dictionary<int, string>();
        public Medic(PlayerControl player) : base(player)
        {
            Name = "Medic";
            ImpostorText = () => "Create A Shield To Protect A Crewmate";
            TaskText = () => "Protect a crewmate with a shield";
            Color = Patches.Colors.Medic;
            RoleType = RoleEnum.Medic;
            AddToRoleHistory(RoleType);
            ShieldedPlayer = null;

            LightDarkColors.Add(0, "darker"); //Red
            LightDarkColors.Add(1, "darker"); //Blue
            LightDarkColors.Add(2, "darker"); //Green
            LightDarkColors.Add(3, "lighter"); //Pink
            LightDarkColors.Add(4, "lighter"); //Orange
            LightDarkColors.Add(5, "lighter"); //Yellow
            LightDarkColors.Add(6, "darker"); //Black
            LightDarkColors.Add(7, "lighter"); //White
            LightDarkColors.Add(8, "darker"); //Purple
            LightDarkColors.Add(9, "darker"); //Brown
            LightDarkColors.Add(10, "lighter"); //Cyan
            LightDarkColors.Add(11, "lighter"); //Lime
            LightDarkColors.Add(12, "darker"); //Maroon
            LightDarkColors.Add(13, "lighter"); //Rose
            LightDarkColors.Add(14, "lighter"); //Banana
            LightDarkColors.Add(15, "darker"); //Grey
            LightDarkColors.Add(16, "darker"); //Tan
            LightDarkColors.Add(17, "lighter"); //Coral
            LightDarkColors.Add(18, "darker"); //Watermelon
            LightDarkColors.Add(19, "darker"); //Chocolate
            LightDarkColors.Add(20, "lighter"); //Sky Blue
            LightDarkColors.Add(21, "darker"); //Biege
            LightDarkColors.Add(22, "lighter"); //Hot Pink
            LightDarkColors.Add(23, "lighter"); //Turquoise
            LightDarkColors.Add(24, "lighter"); //Lilac
            LightDarkColors.Add(25, "darker"); //Olive
            LightDarkColors.Add(26, "lighter"); //Azure
            LightDarkColors.Add(27, "lighter"); //Rainbow
        }

        public PlayerControl ClosestPlayer;
        public bool UsedAbility { get; set; } = false;
        public PlayerControl ShieldedPlayer { get; set; }
        public PlayerControl exShielded { get; set; }
    }
}