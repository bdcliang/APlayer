using System;
using System.Collections.Generic;
using System.Text;
using AxAPlayer3Lib;
using System.Drawing;
namespace APlayer.View
{
    public class APlayer
    {
        public enum PlayState
        {
            PS_READY = 0,  // 准备就绪
            PS_OPENING = 1,  // 正在打开
            PS_PAUSING = 2,  // 正在暂停
            PS_PAUSED = 3,  // 暂停中
            PS_PLAYING = 4,  // 正在开始播放
            PS_PLAY = 5,  // 播放中
            PS_CLOSING = 6,  // 正在开始关闭
        };
        /// <summary>
        /// 视频正在打开
        /// </summary>
        public event EventHandler MediaOpening;
        /// <summary>
        /// 视频正在暂停
        /// </summary>
        public event EventHandler MediaPasuing;
        /// <summary>
        /// 视频正在停止
        /// </summary>
        public event EventHandler MediaStoped;
        /// <summary>
        /// 设置视频播放比例
        /// </summary>
        public string AspectRatio { get; set; }

        private AxPlayer player;
        public APlayer(AxAPlayer3Lib.AxPlayer control)
        {
            this.player = control;
            player.SetConfig(2, System.Windows.Forms.Application.StartupPath + "//codecs");
            player.OnStateChanged += Player_OnStateChanged;
            player.OnMessage += Player_OnMessage;
        }

        private void Player_OnMessage(object sender, _IPlayerEvents_OnMessageEvent e)
        {
            if (e.nMessage == 517)  //右键按下
            {
                ConfigForm cong = new ConfigForm();
                cong.ShowDialog();
            }
        }

        private void Player_OnStateChanged(object sender, _IPlayerEvents_OnStateChangedEvent e)
        {
            var state =(PlayState) e.nNewState;
            switch(state)
            {
                case PlayState.PS_OPENING: MediaOpening?.Invoke(this,new EventArgs()); break;
                case PlayState.PS_PLAY:
                case PlayState.PS_PLAYING:
                    player.SetConfig(204, AspectRatio??"4:3");
                    break;

                case PlayState.PS_PAUSING: 
                case PlayState.PS_PAUSED:
                    MediaPasuing?.Invoke(this,new EventArgs());
                    break;
                case PlayState.PS_CLOSING:
                    //MediaStoped?.Invoke(this,new EventArgs());
                    
                    break;
                case PlayState.PS_READY:
                    
                    MediaStoped?.Invoke(this, new EventArgs());
                    break;
            }
        }

        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="path"></param>
        public void Play(string path)
        {            
            player.SafeExecute(()=> {
                player.Open(path);
            });
        }
        /// <summary>
        /// 暂停
        /// </summary>
        public void Pause()
        {
            player.SafeExecute(() =>
            {
                player.Pause();
            });
        }
        /// <summary>
        /// 恢复播放
        /// </summary>
        public void Continue()
        {
            player.SafeExecute(() => {
                player.Play();
            });
        }
        /// <summary>
        /// 停止
        /// </summary>
        public void Stop()
        {
            player.SafeExecute(()=> {
                player.Close();
            });
        }
        /// <summary>
        /// 设置视频比例
        /// </summary>
        /// <param name="ratio">example 4:3</param>
        public void SetAspectRatio(string ratio)
        {
            AspectRatio = ratio;
        }
        /// <summary>
        /// 设置视频的Logo图像
        /// </summary>
        /// <param name="img"></param>
        public void SetCustomLogo(Bitmap bt)
        {
            player.SafeExecute(() =>
            {
                Bitmap logo = new Bitmap(bt.Width, bt.Height);
                Graphics g = Graphics.FromImage(logo);
                g.Clear(Color.Black);
                g.DrawImage(bt, 0, 0, bt.Width, bt.Height);
                player.SetCustomLogo(logo.GetHbitmap().ToInt32());
            });
        }
        /// <summary>
        /// 获取视频播放状态
        /// </summary>
        /// <returns></returns>
        public PlayState GetState()
        {
            return (PlayState)player.GetState();
        }

        /// <summary>
        /// 获取视频总长度
        /// </summary>
        /// <returns></returns>
        public int GetDuration()
        {
           return  player.GetDuration();
        }
        /// <summary>
        /// 获取视频位置
        /// </summary>
        /// <returns></returns>
        public int GetPosition()
        {
            return player.GetPosition();
        }
        /// <summary>
        /// 设置视频位置
        /// </summary>
        /// <param name="nPosition"></param>
        public void SetPosition(int nPosition)
        {
            player.SafeExecute(()=> {
                player.SetPosition(nPosition);
            });
            
        }
        /// <summary>
        /// 获取视频宽度
        /// </summary>
        /// <returns></returns>
        public int GetVideoWidth()
        {
            return player.GetVideoHeight();
        }
        /// <summary>
        /// 获取视频高度
        /// </summary>
        /// <returns></returns>
        public int GetVideoHeight()
        {
            return player.GetVideoHeight();
        }
        /// <summary>
        /// 获取当前的音量大小
        /// </summary>
        /// <returns></returns>
        public int GetVolume()
        {
            return player.GetVolume();
        }
        /// <summary>
        /// 设置音量大小
        /// </summary>
        /// <param name="volume">要设置的播放音量，取值范围为 0 - 1000
        ///实际上，当取值为 100 时就是正常的满音量，由于 APlayer 具有声音扩大功能，取值 1000 时候即十倍音量。</param>

        public void SetVolume(int volume)
        {
            player.SafeExecute(()=> {
                player.SetVolume(volume);
            });
        }
    }
}
