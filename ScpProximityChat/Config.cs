using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;
using PlayerRoles;
using VoidSCPProximityVoiceChat.Enums;

namespace VoidSCPProximityVoiceChat
{
    public class Config : IConfig
    {
        [Description("Whether the plugin is enabled or disabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether the debug mode is enabled or disabled.")]
        public bool Debug { get; set; } = false;

        [Description("The activation type: ServerSpecificSettings (custom settings) or NoClip (no clip key).")]
        public ActivationType ActivationType { get; set; } = ActivationType.ServerSpecificSettings;

        [Description("Scp role that can use the proximity chat.")]
        public HashSet<RoleTypeId> ScpRoles { get; set; } = new()
        {
            RoleTypeId.Scp049,
            RoleTypeId.Scp0492,
            RoleTypeId.Scp096,
            RoleTypeId.Scp106,
            RoleTypeId.Scp173,
            RoleTypeId.Scp939,
        };

        [Description("If false, SCPs won't hear those with proximity chat enabled until they are near them.")]
        public bool UseDefaultScpChat { get; set; } = true;

        [Description("The volume of the voice.")]
        public float Volume { get; set; } = 10f;

        [Description("Represents the distance at which the audio is full volume.")]
        public float MinDistance { get; set; } = 2f;

        [Description("Max voice distance through the proximity chat.")]
        public float MaxDistance { get; set; } = 10f;

        [Description("Hint displayed when a scp activates its proximity chat.")]
        public Message ProximityChatEnabled { get; set; } = new()
        {
            Text = "<b><align=center><color=#FFFFFF%ALPHA%>Proximity chat is now <color=#00FF00%ALPHA%>enabled</color>.</color></align></b>",
            Duration = 5,
            Show = true,
            FadeOut = true,
            TargetPosX = 0,
            TargetPosY = 300,
        };

        [Description("Hint displayed when a scp deactivates its proximity chat.")]
        public Message ProximityChatDisabled { get; set; } = new()
        {
            Text = "<b><align=center><color=#FFFFFF%ALPHA%>Proximity chat is now <color=#FF0000%ALPHA%>disabled</color>.</color></align></b>",
            Duration = 5,
            Show = true,
            FadeOut = true,
            TargetPosX = 0,
            TargetPosY = 300,
        };

        public Message ProximityChatRole { get; set; } = new()
        {
            Text = "<b><align=center><color=#FFFFFF%ALPHA%>You can toggle proximity chat by using the keybind configured in your settings.</color></align></b>",
            Duration = 10,
            Show = true,
            FadeOut = true,
            TargetPosX = 0,
            TargetPosY = 300,
        };

        [Description("The centered text (header) of the category.")]
        public string SettingHeaderLabel { get; set; } = "ScpProximityChat";

        [Description("The unique id of the setting.")]
        public int KeybindId { get; set; } = 200;

        [Description("The keybind label.")]
        public string KeybindLabel { get; set; } = "Toggle scp proximity chat";

        [Description("The keybind hint used to provides additional information.")]
        public string KeybindHint { get; set; } = "Toggles the scp proximity chat.";
    }
}