using System;
using System.Threading.Tasks;

namespace Metro_App
{
    public static class SoundHelper
    {
        public static void PlayTap()
        {
            Task.Run(() =>
            {
                try
                {
                    // A clean, pleasing, high-pitched tap sound: 1200 Hz frequency for 35 milliseconds
                    Console.Beep(1200, 35);
                }
                catch
                {
                    // Fail-safe to avoid any crash on systems without sound devices
                }
            });
        }
    }
}
