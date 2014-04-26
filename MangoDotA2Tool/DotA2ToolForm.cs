using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace MangoDotA2Tool
{
    public partial class DotA2ToolForm : Form
    {
        //声明写INI文件的API函数 
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        //声明读INI文件的API函数 
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public DotA2ToolForm()
        {
            InitializeComponent();

            lblVersion.Text = lblVersion.Text + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            initDotA2ToolForm();
            setDotA2Path();
        }

        private void initDotA2ToolForm()
        {
            //服务器地址
            string hostName = Dns.GetHostName();
            IPHostEntry ipHostEntry = Dns.GetHostEntry(hostName);
            IPAddress[] ipAddress = ipHostEntry.AddressList;
            for (int i = 0; i != ipAddress.Length; i++)
            {
                if (ipAddress[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    cbSServerIP.Items.Add(ipAddress[i]);
                }
            }
            cbSServerIP.SelectedIndex = 0;


            //地图文件
            string[] cbItemGameMap = new string[] {"默认", "秋季", "冬季", "新年"};
            cbSGameMap.Items.AddRange(cbItemGameMap);
            cbSGameMap.SelectedIndex = 0;

            //地图模式
            string[] cbItemGameMode = new string[] {"全阵营模式", "中路模式", "随机技能模式"};
            cbSGameMode.Items.AddRange(cbItemGameMode);
            cbSGameMode.SelectedIndex = 0;

            //地图难度
            string[] cbItemGameDifficulty = new string[] {"消极", "简单", "中等", "困难", "疯狂"};
            cbSGameDifficulty.Items.AddRange(cbItemGameDifficulty);
            cbSGameDifficulty.SelectedIndex = 4;

            //AI练习赛
            string[] cbItemBotGame = new string[] { "是", "否" };
            cbSBotGame.Items.AddRange(cbItemBotGame);
            cbSBotGame.SelectedIndex = 0;

            System.Windows.Forms.ToolTip ToolTipBotGame = new System.Windows.Forms.ToolTip();
            ToolTipBotGame.SetToolTip(this.cbSBotGame, "选择\"是\",则服务器自动填充AI");

            //等待玩家
            string[] cbItemWaitForPlayer = new string[] { "是", "否" };
            cbSWaitForPlayer.Items.AddRange(cbItemWaitForPlayer);
            cbSWaitForPlayer.SelectedIndex = 0;

            //等待人数
            string[] cbItemWaitForPlayerCount = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
            cbSWaitForPlayerCount.Items.AddRange(cbItemWaitForPlayerCount);
            cbSWaitForPlayerCount.SelectedIndex = 4;

            //等待时间
            string[] cbItemWaitForPlayerTimeout = new string[] { "30", "60", "300", "600", "1800" };
            cbSWaitForPlayerTimeout.Items.AddRange(cbItemWaitForPlayerTimeout);
            cbSWaitForPlayerTimeout.SelectedIndex = 0;

            System.Windows.Forms.ToolTip ToolTipWaitForPlayerTimeout = new System.Windows.Forms.ToolTip();
            ToolTipWaitForPlayerTimeout.SetToolTip(this.cbSWaitForPlayerTimeout, "单位\"秒\"");

            //玩家上限
            string[] cbItemMaxPlayers = new string[] { "2", "10", "32" };
            cbSMaxPlayers.Items.AddRange(cbItemMaxPlayers);
            cbSMaxPlayers.SelectedIndex = 1;

            //开启观战
            string[] cbItemSourceTV = new string[] { "是", "否" };
            cbSSourceTV.Items.AddRange(cbItemSourceTV);
            cbSSourceTV.SelectedIndex = 1;

            //观战上限
            string[] cbItemSourceTVMaxClients = new string[] { "32", "64", "128", "256" };
            cbSSourceTVMaxClients.Items.AddRange(cbItemSourceTVMaxClients);
            cbSSourceTVMaxClients.SelectedIndex = 0;

            System.Windows.Forms.ToolTip ToolTipSourceTVMaxClients = new System.Windows.Forms.ToolTip();
            ToolTipSourceTVMaxClients.SetToolTip(this.cbSSourceTVMaxClients, "观战人数上限");

            //观战延迟
            string[] cbItemSourceTVDelay = new string[] { "30", "120", "300" };
            cbSSourceTVDelay.Items.AddRange(cbItemSourceTVDelay);
            cbSSourceTVDelay.SelectedIndex = 0;

            System.Windows.Forms.ToolTip ToolTipSourceTVDelay = new System.Windows.Forms.ToolTip();
            ToolTipSourceTVDelay.SetToolTip(this.cbSSourceTVDelay, "单位\"秒\"");

            //自动保存
            string[] cbItemSourceTVAutorecord = new string[] { "是", "否" };
            cbSSourceTVAutorecord.Items.AddRange(cbItemSourceTVAutorecord);
            cbSSourceTVAutorecord.SelectedIndex = 1;

            System.Windows.Forms.ToolTip ToolTipSourceTVAutorecord = new System.Windows.Forms.ToolTip();
            ToolTipSourceTVAutorecord.SetToolTip(this.cbSSourceTVAutorecord, "如果开启,会占用服务器额外的内存!");

            

        }

        private bool setDotA2Path()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "DotA2主程序|dota.exe";
            fileDialog.RestoreDirectory = true;
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Path.GetDirectoryName(fileDialog.FileName));
                return true;
            }
            return false;
        }

    }
}
