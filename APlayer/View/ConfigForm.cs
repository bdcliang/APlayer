using APlayer.DAL;
using APlayer.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace APlayer.View
{
    public partial class ConfigForm :CCWin.Skin_DevExpress
    {
        public ConfigForm()
        {
            InitializeComponent();
        }
        private Setting setting;
        private LightControl lightcontrol;
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            setting = SettingDAL.GetSetting();
            lightcontrol = LightConrolDAL.GetLights();
            LayoutIni(setting,lightcontrol);
            LLSDK.WinAPI.Window.SetWindowAlwaysTop(this.Handle);
        }

        private void LayoutIni(Setting set,LightControl light)
        {
            skinTextBoxXpos.SkinTxt.Text = set.ClientRec.X.ToString();
            skinTextBoxYpos.SkinTxt.Text = set.ClientRec.Y.ToString();
            skinTextBoxWidth.SkinTxt.Text = set.ClientRec.Width.ToString();
            skinTextBoxHeight.SkinTxt.Text = set.ClientRec.Height.ToString();

            lightEnable.Checked = light.Enable;
            skinComboBoxState.Text = light.NormState;
            skinTextBoxChipID.Text =light.Address;
            skinTextBoxIP.Text = light.RemoteIP;
            skinTextBoxPorts.Text = light.StrPorts;

            skinTextBoxListenPort.Text = setting.Port.ToString();
            skinComboBoxCirPlay.Text = set.CirPlay?"是":"否";
            skinComboBoxHideCur.Text = set.HideCur?"是":"否";
        }

        private void skinButtonConfirm_Click(object sender, EventArgs e)
        {
            string tmpRec = string.Format("{0},{1},{2},{3}",skinTextBoxXpos.Text,skinTextBoxYpos.Text,skinTextBoxWidth.Text,skinTextBoxHeight.Text);
            setting.ClientRec =(Rectangle) new RectangleConverter().ConvertFromString(tmpRec);
            lightcontrol.Enable = lightEnable.Checked;
            lightcontrol.NormState = skinComboBoxState.Text;
            lightcontrol.Address = skinTextBoxChipID.Text;
            lightcontrol.RemoteIP = skinTextBoxIP.Text;
            lightcontrol.StrPorts = skinTextBoxPorts.Text;

            setting.Port =int.Parse(skinTextBoxListenPort.Text);
            setting.CirPlay =skinComboBoxCirPlay.Text=="是"?true:false;
            setting.HideCur = skinComboBoxHideCur.Text == "是"?true:false;
            SettingDAL.UpdateSetting(setting);
            LightConrolDAL.UpdateLights(lightcontrol);

            Application.Restart();
        }

        private void skinButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
