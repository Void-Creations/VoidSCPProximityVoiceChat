using System.ComponentModel;
using VoidSCPProximityVoiceChat.Enums;

namespace VoidSCPProximityVoiceChat
{
    public class Message
    {
        [Description("The text of the message. (If you use color in your text and also turn on fade out, you have to put %ALPHA% at the alpha hex part. example: #FFFFFF%ALPHA% ) (plugin will try to wrap the entire text inside a color tag if you don't include one like this.)")]
        public string Text { get; set; }

        [Description("The duration of the message (in seconds).")]
        public float Duration { get; set; }

        [Description("A bool indicating whether to show this message or not.")]
        public bool Show { get; set; }

        [Description("Should the hint go out with a fade out animation?")]
        public bool FadeOut { get; set; }

        [Description("The X position where the message will try to be shown (shifts up or down if overlaps with another hint).")]
        public float TargetPosX { get; set; }

        [Description("The Y position where the message will try to be shown (shifts up or down if overlaps with another hint).")]
        public float TargetPosY { get; set; }
    }
}