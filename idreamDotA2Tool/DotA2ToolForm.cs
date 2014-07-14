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




namespace idreamDotA2Tool
{
    public partial class DotA2ToolForm : Form
    {
        // 初始化配置文件实例
        IniFile ini = new IniFile(Application.StartupPath + "\\config.ini");

        public DotA2ToolForm()
        {
            InitializeComponent();

            // 显示版本号
            lblVersion.Text = "版本: " + "20140714";

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
            // 修复中文输入法
            /*
            tbCPlayerName.ImeMode = ImeMode.On;
            */

            // 服务器地址
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

            tbCServerIP.Text = cbSServerIP.Text;

            // 地图文件
            string[] cbItemGameMap = new string[] {"默认", "秋季", "冬季", "新年"};
            cbSGameMap.Items.AddRange(cbItemGameMap);
            cbSGameMap.SelectedIndex = 0;

            // 地图模式
            string[] cbItemGameMode = new string[] {"全阵营模式", "中路模式", "随机技能模式", "队长模式"};
            cbSGameMode.Items.AddRange(cbItemGameMode);
            cbSGameMode.SelectedIndex = 0;

            // 地图难度
            string[] cbItemGameDifficulty = new string[] {"消极", "简单", "中等", "困难", "疯狂"};
            cbSGameDifficulty.Items.AddRange(cbItemGameDifficulty);
            cbSGameDifficulty.SelectedIndex = 4;

            // AI练习赛
            string[] cbItemBotGame = new string[] { "是", "否" };
            cbSBotGame.Items.AddRange(cbItemBotGame);
            cbSBotGame.SelectedIndex = 1;

            System.Windows.Forms.ToolTip ToolTipBotGame = new System.Windows.Forms.ToolTip();
            ToolTipBotGame.SetToolTip(this.cbSBotGame, "选择\"是\",则服务器自动填充AI");

            // 等待玩家
            string[] cbItemWaitForPlayer = new string[] { "是", "否" };
            cbSWaitForPlayer.Items.AddRange(cbItemWaitForPlayer);
            cbSWaitForPlayer.SelectedIndex = 0;

            // 等待人数
            string[] cbItemWaitForPlayerCount = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
            cbSWaitForPlayerCount.Items.AddRange(cbItemWaitForPlayerCount);
            cbSWaitForPlayerCount.SelectedIndex = 4;

            // 等待时间
            string[] cbItemWaitForPlayerTimeout = new string[] { "30", "60", "300", "600", "1800" };
            cbSWaitForPlayerTimeout.Items.AddRange(cbItemWaitForPlayerTimeout);
            cbSWaitForPlayerTimeout.SelectedIndex = 0;

            System.Windows.Forms.ToolTip ToolTipWaitForPlayerTimeout = new System.Windows.Forms.ToolTip();
            ToolTipWaitForPlayerTimeout.SetToolTip(this.cbSWaitForPlayerTimeout, "单位\"秒\"");

            // 玩家上限
            string[] cbItemMaxPlayers = new string[] { "2", "10", "32" };
            cbSMaxPlayers.Items.AddRange(cbItemMaxPlayers);
            cbSMaxPlayers.SelectedIndex = 1;

            // 开启观战
            string[] cbItemSourceTV = new string[] { "是", "否" };
            cbSSourceTV.Items.AddRange(cbItemSourceTV);
            cbSSourceTV.SelectedIndex = 1;

            // 观战上限
            string[] cbItemSourceTVMaxClients = new string[] { "32", "64", "128", "256" };
            cbSSourceTVMaxClients.Items.AddRange(cbItemSourceTVMaxClients);
            cbSSourceTVMaxClients.SelectedIndex = 0;

            System.Windows.Forms.ToolTip ToolTipSourceTVMaxClients = new System.Windows.Forms.ToolTip();
            ToolTipSourceTVMaxClients.SetToolTip(this.cbSSourceTVMaxClients, "观战人数上限");

            // 观战延迟
            string[] cbItemSourceTVDelay = new string[] { "30", "120", "300" };
            cbSSourceTVDelay.Items.AddRange(cbItemSourceTVDelay);
            cbSSourceTVDelay.SelectedIndex = 0;

            System.Windows.Forms.ToolTip ToolTipSourceTVDelay = new System.Windows.Forms.ToolTip();
            ToolTipSourceTVDelay.SetToolTip(this.cbSSourceTVDelay, "单位\"秒\"");

            // 自动保存
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

            if (File.Exists(ini.lPath + "\\dota.exe"))
            {
                // 恢复 gameinfo.txt 文件
                try
                {
                    File.Copy(ini.lPath + "\\dota\\gameinfo-Client.txt", ini.lPath + "\\dota\\gameinfo.txt", true);
                }
                catch
                {
                    // 不抛出任何异常,用来忽略文件正在被使用的问题
                }
                
                File.Delete(ini.lPath + "\\dota\\gameinfo-Client.txt");
                File.Delete(ini.lPath + "\\dota\\gameinfo-Server.txt");
            }
        }

        // 启动游戏按钮
        private void btnCGameStart_Click(object sender, EventArgs e)
        {
            
            ini.rPlayerName = tbCPlayerName.Text;
            ini.rServerIPNSNet = tbCServerIP.Text;

            // 判定 DotA 路径设置
            if (!File.Exists(ini.lPath + "\\dota.exe"))
            {
                setDotA2Path();
            }
            else
            {
                CopyFolder cpREVClientPath = new CopyFolder(Application.StartupPath + "\\REVEmu", ini.lPath);
                File.Delete(ini.lPath + "\\dota\\gameinfo.txt");
                try
                {
                    File.Copy(ini.lPath + "\\dota\\gameinfo-Client.txt", ini.lPath + "\\dota\\gameinfo.txt", true);
                }
                catch
                {
                    // 不抛出任何异常,用来忽略文件正在被使用的问题
                }

                File.Copy(ini.lPath + "\\dota\\cfg\\autoexec_Client.cfg", ini.lPath + "\\dota\\cfg\\autoexec.cfg", true);

                FileStream fsConnectCfg = new FileStream(ini.lPath + "\\dota\\cfg\\connect.cfg", FileMode.OpenOrCreate);
                StreamWriter swConnectCfg = new StreamWriter(fsConnectCfg);
                swConnectCfg.WriteLine("connect " + tbCServerIP.Text + ":" + tbCServerPort.Text);
                swConnectCfg.Close();

                runDota(ini.lPath + "\\revLoader.exe");
            }
        }

        // 启动dota目录中的 revLoader.exe
        private void runDota(string path)
        {
            string workingDir = Path.GetDirectoryName(path);

            Process dotaProcess = new Process();
            dotaProcess.StartInfo.UseShellExecute = false;
            dotaProcess.StartInfo.FileName = path;
            dotaProcess.StartInfo.WorkingDirectory = workingDir;
            dotaProcess.Start();           
        }

        // 建立服务器
        private void btnSServerHost_Click(object sender, EventArgs e)
        {
            initServerCfg();
            // 判定 DotA 路径设置
            if (!File.Exists(ini.lPath + "\\dota.exe"))
            {
                setDotA2Path();
            }
            else
            {
                CopyFolder cpREVServerPath = new CopyFolder(Application.StartupPath + "\\REVEmu", ini.lPath);
                File.Delete(ini.lPath + "\\dota\\gameinfo.txt");
                try
                {
                    File.Copy(ini.lPath + "\\dota\\gameinfo-Server.txt", ini.lPath + "\\dota\\gameinfo.txt", true);
                }
                catch
                {
                    // 不抛出任何异常,用来忽略文件正在被使用的问题
                }
                File.Delete(ini.lPath + "\\dota\\cfg\\autoexec.cfg");
                runSrcds(ini.lPath + "\\revLoader.exe");
            }
        }

        // 修改srcds的server.cfg配置文件
        private void initServerCfg()
        {
            FileStream fsServerCfg = new FileStream(Application.StartupPath + "\\REVEmu\\dota\\cfg\\server.cfg", FileMode.OpenOrCreate);
            StreamWriter swServerCfg = new StreamWriter(fsServerCfg);

            swServerCfg.WriteLine("hostname DotA2");
            swServerCfg.WriteLine("sv_cheats 1");
            swServerCfg.WriteLine("sv_lan 1");
            swServerCfg.WriteLine("tv_secret_code 0");
            swServerCfg.WriteLine("sv_hibernate_when_empty 0");

            

            // 判断是否开启等待玩家功能
            if (cbSWaitForPlayer.Text == "是")
            {
                swServerCfg.WriteLine("dota_wait_for_players_to_load 1");
            }
            else
            {
                swServerCfg.WriteLine("dota_wait_for_players_to_load 0");
            }
            
            // 设置等待人数
            swServerCfg.WriteLine("dota_wait_for_players_to_load_count " + cbSWaitForPlayerCount.Text);

            // 设置等待时间
            swServerCfg.WriteLine("dota_wait_for_players_to_load_timeout " + cbSWaitForPlayerTimeout.Text);

            // 设置地图难度
            switch (cbSGameDifficulty.Text)
            {
                case "消极":
                    swServerCfg.WriteLine("dota_bot_set_difficulty 0");
                    break;
                case "简单":
                    swServerCfg.WriteLine("dota_bot_set_difficulty 1");
                    break;
                case "中等":
                    swServerCfg.WriteLine("dota_bot_set_difficulty 2");
                    break;
                case "困难":
                    swServerCfg.WriteLine("dota_bot_set_difficulty 3");
                    break;
                case "疯狂":
                    swServerCfg.WriteLine("dota_bot_set_difficulty 4");
                    break;
                default:
                    swServerCfg.WriteLine("dota_bot_set_difficulty 4");
                    break;
            }

            
            
            swServerCfg.WriteLine("sv_cheats 0");
            swServerCfg.Close();
        }

        // 用 revLoader 启动 srcds 服务器
        private void runSrcds(string path)
        {
            string workingDir = Path.GetDirectoryName(path);

            Process dotaProcess = new Process();
            dotaProcess.StartInfo.UseShellExecute = false;
            dotaProcess.StartInfo.FileName = path;

            string dotaGameMode;
            // 设置地图模式
            switch (cbSGameMode.SelectedIndex)
            {
                // 全阵营模式
                case 0:
                    dotaGameMode = "1";
                    break;
                // 中路模式
                case 1:
                    dotaGameMode = "11";
                    break;
                // OMG模式
                case 2:
                    dotaGameMode = "18";
                    break;
                // 队长模式
                case 3:
                    dotaGameMode = "2";
                    break;
                // 默认全阵营模式
                default:
                    dotaGameMode = "1";
                    break;
            }

            // 设置是否机器人练习赛
            string aiGame;
            if (cbSBotGame.Text == "是")
            {
                aiGame = "1";
            }
            else
            {
                aiGame = "0";
            }

            dotaProcess.StartInfo.Arguments = "-launch srcds.exe -console -game dota +sv_cheats 1 -ip " + cbSServerIP.Text + " -port " + tbSServerPort.Text + " +dota_start_ai_game " + aiGame + " +dota_force_gamemode " + dotaGameMode + " +map dota +maxplayers " + cbSMaxPlayers.Text;
            dotaProcess.StartInfo.WorkingDirectory = workingDir;
            dotaProcess.Start();
        }

        private void cbSWaitForPlayer_TextChanged(object sender, EventArgs e)
        {
            if (cbSWaitForPlayer.Text == "是")
            {
                cbSWaitForPlayerCount.Enabled = true;
                cbSWaitForPlayerTimeout.Enabled = true;
            }
            else
            {
                cbSWaitForPlayerCount.Enabled = false;
                cbSWaitForPlayerTimeout.Enabled = false;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("如有任何BUG请反馈。本工具严禁用于互联网，仅供局域网练习，转载请注明出处。\n\n" +
                            "本工具在Github上开源，请自行搜索。\n\n" +
                            //"github.com/idreamshen/idreamDotA2LanTool\n\n" +
                            "Mail: idream.shen@gmail.com\n" +
                            //"Wechat: idreamshen\n" +
                            "Website: idreamshen.com"
                           );
        }

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        //ShowWindow参数
        private const int SW_RESTORE = 9;
        //SendMessage参数
        private const int WM_KEYDOWN = 0X100;
        private const int WM_KEYUP = 0X101;
        private const int WM_SYSCHAR = 0X106;
        private const int WM_SYSKEYUP = 0X105;
        private const int WM_SYSKEYDOWN = 0X104;
        private const int WM_CHAR = 0X102;

        private void btnCJoinServer_Click(object sender, EventArgs e)
        {
            IntPtr myIntPtr = FindWindow("Valve001", "DotA 2");
            ShowWindow(myIntPtr, SW_RESTORE);
            SetForegroundWindow(myIntPtr);
            keybd_event(220, 0x2b, 0X0, 0);
            keybd_event(220, 0xab, 0X2, 0);
            System.Threading.Thread.Sleep(300);
            SendKeys.Send("{F7}");

            /*
            byte[] ch = (ASCIIEncoding.ASCII.GetBytes("connect " + tbCServerIP.Text + ":" + tbCServerPort.Text));
            for (int i = 0; i < ch.Length; i++)
            {
                SendMessage(myIntPtr, WM_CHAR, ch[i], 0);
            }
            SendKeys.Send("{ENTER}");
            */

            System.Threading.Thread.Sleep(300);
            byte[] ch = (ASCIIEncoding.ASCII.GetBytes("hideconsole"));
            for (int i = 0; i < ch.Length; i++)
            {
                SendMessage(myIntPtr, WM_CHAR, ch[i], 0);
            }
            SendKeys.Send("{ENTER}");
        }

        private void btnCJoinTeamGood_Click(object sender, EventArgs e)
        {
            IntPtr myIntPtr = FindWindow("Valve001", "DotA 2");
            ShowWindow(myIntPtr, SW_RESTORE);
            SetForegroundWindow(myIntPtr);

            keybd_event(121, 0x44, 0X0, 0);
            keybd_event(121, 0xc4, 0X2, 0);
            /*
            System.Threading.Thread.Sleep(300);
            byte[] ch = (ASCIIEncoding.ASCII.GetBytes("jointeam good"));
            for (int i = 0; i < ch.Length; i++)
            {
                SendMessage(myIntPtr, WM_CHAR, ch[i], 0);
            }
            SendKeys.Send("{ENTER}");
            System.Threading.Thread.Sleep(300);
            ch = (ASCIIEncoding.ASCII.GetBytes("hideconsole"));
            for (int i = 0; i < ch.Length; i++)
            {
                SendMessage(myIntPtr, WM_CHAR, ch[i], 0);
            }
            SendKeys.Send("{ENTER}");
            */

        }

        private void btnCJoinTeamBad_Click(object sender, EventArgs e)
        {
            IntPtr myIntPtr = FindWindow("Valve001", "DotA 2");
            ShowWindow(myIntPtr, SW_RESTORE);
            SetForegroundWindow(myIntPtr);
            System.Threading.Thread.Sleep(300);
            //SendKeys.Send("{F11}");

            
            keybd_event(122, 0x57, 0X0, 0);
            keybd_event(122, 0xd7, 0X2, 0);
            /*
            System.Threading.Thread.Sleep(300);

            byte[] ch = (ASCIIEncoding.ASCII.GetBytes("jointeam bad"));
            for (int i = 0; i < ch.Length; i++)
            {
                SendMessage(myIntPtr, WM_CHAR, ch[i], 0);
            }
            SendKeys.Send("{ENTER}");
            System.Threading.Thread.Sleep(300);
            ch = (ASCIIEncoding.ASCII.GetBytes("hideconsole"));
            for (int i = 0; i < ch.Length; i++)
            {
                SendMessage(myIntPtr, WM_CHAR, ch[i], 0);
            }
            SendKeys.Send("{ENTER}");
             * */
        }

        private void btnCAddBot_Click(object sender, EventArgs e)
        {
            IntPtr myIntPtr = FindWindow("ConsoleWindowClass", "DotA2");
            ShowWindow(myIntPtr, SW_RESTORE);
            SetForegroundWindow(myIntPtr);

            byte[] ch = (ASCIIEncoding.ASCII.GetBytes("dota_bot_populate"));
            for (int i = 0; i < ch.Length; i++)
            {
                SendMessage(myIntPtr, WM_CHAR, ch[i], 0);
            }
            SendKeys.Send("{ENTER}");

            myIntPtr = FindWindow("Valve001", "DotA 2");
            ShowWindow(myIntPtr, SW_RESTORE);
            SetForegroundWindow(myIntPtr);
        }

        private void tbCServerIP_TextChanged(object sender, EventArgs e)
        {
            FileStream fsConnectCfg = new FileStream(ini.lPath + "\\dota\\cfg\\connect.cfg", FileMode.OpenOrCreate);
            StreamWriter swConnectCfg = new StreamWriter(fsConnectCfg);
            swConnectCfg.WriteLine("connect " + tbCServerIP.Text + ":" + tbCServerPort.Text);
            swConnectCfg.Close();
        }

        private void tbCServerPort_TextChanged(object sender, EventArgs e)
        {
            FileStream fsConnectCfg = new FileStream(ini.lPath + "\\dota\\cfg\\connect.cfg", FileMode.OpenOrCreate);
            StreamWriter swConnectCfg = new StreamWriter(fsConnectCfg);
            swConnectCfg.WriteLine("connect " + tbCServerIP.Text + ":" + tbCServerPort.Text);
            swConnectCfg.Close();
        }
    }
}
