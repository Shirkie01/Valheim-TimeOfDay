using BepInEx;
using System;

namespace TimeOfDay
{
    [BepInPlugin("12818a53-2dd5-4602-afe7-747f32c89ca6", "Time Of Day", "1.0.0.0")]
    public class TimeOfDayBepInExPlugin : BaseUnityPlugin
    {
        private void Awake() => InvokeRepeating("UpdateTimeOfDay", 0, 1);

        private string ToTimeString(double seconds)
        {
            var fractionOfDayPassed = seconds / EnvMan.instance.m_dayLengthSec;
            var decimalTime = fractionOfDayPassed * 24;

            return TimeSpan.FromHours(decimalTime).ToString("hh\\:mm");
        }

        private void UpdateTimeOfDay()
        {            
            if (Player.m_localPlayer == null)
            {
                return;
            }

            var secondsPassed = ZNet.instance.GetTimeSeconds();
            var secondsPassedInDay = secondsPassed % EnvMan.instance.m_dayLengthSec;

            string message = ToTimeString(secondsPassedInDay);
            Player.m_localPlayer.Message(MessageHud.MessageType.TopLeft, message);
            MessageHud.instance.GetLog().Remove(message);
        }
    }
}
