using APlayer.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace APlayer.Controller
{
    using APlayer.View;
    using Model;
    using System.IO;

    public class ControllerBase : IController
    {
        private INetUdp udp;
        private APlayer MediaPlayer;//播放器
        private VideoItems VideoSources;//视频源
        protected Form MainView;//加载的主View
        private bool IsCirPlay=false;
        protected Action MediaStop;//视频播放结束后执行动作
        public ControllerBase(APlayer player)
        {
            this.MediaPlayer = player;
            this.MediaPlayer.MediaStoped += MediaPlayer_MediaStoped;
            string path = Application.StartupPath + @"\Videos";
            VideoSources = VideoItemDAL.GetVideoSources(path);
            udp = new NetUdp();          
            udp.UdpProcess(MessageProcess);

        }

        private int currentIndex=1;
        private  void MediaPlayer_MediaStoped(object sender, EventArgs e)
        {
            if (IsCirPlay)//循环播放
            { Play(currentIndex++); Console.WriteLine("=========cirplay============================"); }
            else
                MediaStop?.Invoke();
        }

       
        public virtual void Listen(int port)
        {
            udp.Listen(port);
        }
        public virtual void LoadView(Form form)
        {
            this.MainView = form;            
        }
        public virtual void MessageProcess(string msg)
        {
            switch (msg)
            {
                case "pause":this.Pause(); break;
                case "stop": this.Stop(); break;
                case "continue": this.Continue(); break;
                case "mute":this.Mute(); break;
                case "unmute":this.UnMute(); break;
                default:
                    if(msg.StartsWith("play"))
                    {
                        int index = 0;
                        bool isok=int.TryParse(msg.Substring(4),out index);
                        if (isok)
                            Play(index);
                    }
                    break;
            }
        }

        public void RegisterExpectionHandler()
        {
            ExceptionConfig.Register();
        }

        public void Restart()
        {
            Application.Restart();
        }

        public void Run()
        {
            Application.Run(this.MainView);
        }

        public virtual void Play(int index)
        {
            if (index > VideoSources.Count || index < 1)
                index = 1;
            MediaPlayer?.Play(VideoSources[index-1].Path);
        }

        #region player operation
        public virtual void CirPlay(bool iscirplay)
        {
            IsCirPlay = iscirplay;
        }
        public virtual void Pause()
        {
            MediaPlayer?.Pause();
        }

        public virtual void Stop()
        {
            MediaPlayer.Stop();
        }

        public virtual void Continue()
        {
            MediaPlayer.Continue();
        }

        public virtual void Mute()
        {
            MediaPlayer.SetVolume(0);
        }

        public virtual void UnMute()
        {
            MediaPlayer.SetVolume(100);
        }

        public virtual void SetApsectRatio(string ratio)
        {
            MediaPlayer?.SetAspectRatio(ratio);
        }

        public virtual void SetCustomLogo(string path)
        {
            if (!File.Exists(path)) return;
            MediaPlayer.SetCustomLogo(new System.Drawing.Bitmap(path));
        }
        #endregion
    }
}
