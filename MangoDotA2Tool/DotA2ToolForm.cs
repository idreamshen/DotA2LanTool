using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
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
        // 初始化配置文件实例
        IniFile ini = new IniFile(Application.StartupPath + "\\config.ini");

        public DotA2ToolForm()
        {
            InitializeComponent();

            // 显示版本号
            lblVersion.Text = "版本: " + "20140430";

            // 初始化默认页面
            initDotA2ToolForm();

            // 读取ini文件中的dota路径，如果不存在，则弹出选择路径对话框
            if (!File.Exists(ini.lPath + "\\dota.exe"))
            {
                setDotA2Path();
            }

            // 读取配置文件
            string sServerPort = ini.sServerPort;
            if(sServerPort != "")
            {
                tbCServerPort.Text = sServerPort;
            }

            string cServerIP = ini.cServerIP;
            if (cServerIP != "")
            {
                tbCServerIP.Text = cServerIP;
            }

            string cServerPort = ini.cServerPort;
            if (cServerPort != "")
            {
                tbCServerPort.Text = cServerPort;
            }

            string cPlayerName = ini.cPlayerName;
            if (cPlayerName != "")
            {
                tbCPlayerName.Text = cPlayerName;
            }

         
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

        // 设置dota路径
        private void setDotA2Path()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "DotA2主程序|dota.exe";
            fileDialog.RestoreDirectory = true;
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                // 将路径保存至配置文件
                ini.lPath = Path.GetDirectoryName(fileDialog.FileName);
            }
            else
            {
                MessageBox.Show("无法设置DotA2游戏路径");
            }
        }

        // 窗体关闭时保存设置到配置文件
        private void DotA2ToolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ini.sServerPort = tbSServerPort.Text;
            ini.cServerIP = tbCServerIP.Text;
            ini.cServerPort = tbCServerPort.Text;
            ini.cPlayerName = tbCPlayerName.Text;
        }

        private void bnCGameStart_Click(object sender, EventArgs e)
        {

            ini.rPlayerName = tbCPlayerName.Text;
            ini.rServerIPNSNet = tbCServerIP.Text;
            CopyFolder cpREVPath = new CopyFolder(Application.StartupPath + "\\REVPatch", ini.lPath);
            runDota(ini.lPath + "\\revLoader.exe");

        }

        // 启动dota目录中的revLoader.exe
        private void runDota(string path)
        {
            string workingDir = Path.GetDirectoryName(path);

            Process dotaProcess = new Process();
            dotaProcess.StartInfo.UseShellExecute = false;
            dotaProcess.StartInfo.FileName = path;
            dotaProcess.StartInfo.WorkingDirectory = workingDir;
            dotaProcess.Start();
        }
    }
}
