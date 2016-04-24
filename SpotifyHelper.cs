using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Microsoft.Samples.Kinect.DiscreteGestureBasics
{
    public static class SpotifyHelper
    {
        public enum SpotifyAction
        {
            PlayPause,
            Next,
            Previous,
            VolumeUp,
            VolumeDown,
            Mute,
            Quit
        };

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static void controlSpotify(SpotifyAction sa)
        {
            BringToForeground("Spotify");

            switch (sa)
            {
                case SpotifyAction.Next:
                    SendKeys.SendWait("^({RIGHT})");
                    break;
                case SpotifyAction.Previous:
                    SendKeys.SendWait("^({LEFT})");
                    break;
                case SpotifyAction.VolumeUp:
                    SendKeys.SendWait("^({UP})");
                    break;
                case SpotifyAction.VolumeDown:
                    SendKeys.SendWait("^({DOWN})");
                    break;
                case SpotifyAction.PlayPause:
                    SendKeys.SendWait(" ");
                    break;
            }
        }
        private static bool BringToForeground(string processName)
        {
            try
            {
                var processes = Process.GetProcessesByName(processName);

                foreach (var process in processes)
                {
                    ShowWindow(process.MainWindowHandle, 3);
                    SetForegroundWindow(process.MainWindowHandle);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
