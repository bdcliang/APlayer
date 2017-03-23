using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace APlayer.Controller
{
    interface IController
    {
        /// <summary>
        /// Run the Form
        /// </summary>
        /// <param name="mainForm"></param>
        void Run();
        /// <summary>
        /// Restart the App
        /// </summary>
        void Restart();
        /// <summary>
        /// Register Expection handler
        /// </summary>
        void RegisterExpectionHandler();
        /// <summary>
        /// handler the Udp message
        /// </summary>
        /// <param name="msg"></param>
        void MessageProcess(string msg);
        /// <summary>
        /// media play
        /// </summary>
        /// <param name="index"></param>
        void Play(int index);
        /// <summary>
        /// media pause
        /// </summary>
        void Pause();
        /// <summary>
        /// media stop
        /// </summary>
        void Stop();
        /// <summary>
        /// media continue
        /// </summary>
        void Continue();
        /// <summary>
        /// media mute
        /// </summary>
        void Mute();
        /// <summary>
        /// media unmute
        /// </summary>
        void UnMute();
        /// <summary>
        /// set media home image
        /// </summary>
        /// <param name="path"></param>
        void SetCustomLogo(string path);
        void LoadView(Form form);
    }
}
