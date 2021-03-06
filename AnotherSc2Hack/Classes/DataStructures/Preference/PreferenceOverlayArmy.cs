﻿using System.Windows.Forms;

namespace AnotherSc2Hack.Classes.DataStructures.Preference
{
    public class PreferenceOverlayArmy : PreferenceBaseOverlay
    {
        public PreferenceOverlayArmy()
        {
            Hotkey3 = Keys.NumPad8;
            TogglePanel = "/arm";
            ChangePosition = "/arcp";
            ChangeSize = "/arcs";
            Width = 600;
            Height = 50;
            ElementName = "OverlayArmy";
        }
    }
}
