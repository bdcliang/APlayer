namespace APlayer.Controller
{
    using System.Windows.Forms;
    using APlayer.View;
    using DAL;
    using Model;
    using WinSock;

    class MediaController :ControllerBase
    {
        private Setting setting;
        private LightControl lightcontrol;
        public MediaController(APlayer player):base(player){
            setting = SettingDAL.GetSetting();
            lightcontrol = LightConrolDAL.GetLights();           
        }
        public override void LoadView(Form form)
        {
            base.LoadView(form);
            
            base.MainView.Bounds = setting.ClientRec;
            base.MainView.TopMost = setting.TopMost;
            this.SetApsectRatio(string.Format("{0};{1}", MainView.Width, MainView.Height));
            base.Listen(setting.Port);
            LLSDK.WinAPI.Window.SetCursorStatus(setting.HideCur);
            //LLSDK.WinAPI.Window.SetWindowAlwaysTop(MainView.Handle);
            base.CirPlay(setting.CirPlay);

            if (setting.CirPlay) Play(1);
            if (!setting.CirPlay && lightcontrol.Enable)
            {
                base.MediaStop = () =>
                {
                    OpenLights();
                };
            }
            else
                base.MediaStop = null;
        }

        public override void Play(int index)
        {
            base.Play(index);
            CloseLights();
        }

        public override void Stop()
        {
            base.Stop();
            OpenLights();
        }

        private void OpenLights()
        {
            if (lightcontrol.Enable && !setting.CirPlay)
            {
                string init = "on";
                if (lightcontrol.NormState == "NC") init = "off";
                else init = "on";
                foreach (var po in lightcontrol.Ports)
                {
                    string cmd = string.Format("r_{0}_{1}_{2}", init, lightcontrol.Address, po);
                    UdpClient.Send(lightcontrol.RemoteIP, 9003, cmd);
                    System.Threading.Thread.Sleep(50);
                }
            }
        }

        private void CloseLights()
        {
            if(lightcontrol.Enable && !setting.CirPlay)
            {
                string init = "on";
                if (lightcontrol.NormState == "NC") init = "on";
                else init = "off";
                foreach (var po in lightcontrol.Ports)
                {
                    string cmd = string.Format("r_{0}_{1}_{2}",init,lightcontrol.Address,po);
                    UdpClient.Send(lightcontrol.RemoteIP,9003,cmd);
                    System.Threading.Thread.Sleep(50);
                }
            }
        }


    }
}
