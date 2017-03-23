using System;
using System.Collections.Generic;
using System.Text;

namespace APlayer.View
{
    public static class APlayerExtension
    {
        public static void SafeExecute(this AxAPlayer3Lib.AxPlayer player,Action action)
        {
            if (null == player) return;

            if (player.InvokeRequired)
                {
                    player.Invoke(action);
                }
            else
                action();
        }

    }
}
