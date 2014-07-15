namespace idreamDotA2Tool
{
    partial class DotA2ToolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DotA2ToolForm));
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.btnSServerHost = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSSourceTVAutorecord = new System.Windows.Forms.ComboBox();
            this.cbSSourceTVDelay = new System.Windows.Forms.ComboBox();
            this.cbSSourceTVMaxClients = new System.Windows.Forms.ComboBox();
            this.cbSSourceTV = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSourceTVPort = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSServerTVPort = new System.Windows.Forms.Label();
            this.gbServerGame = new System.Windows.Forms.GroupBox();
            this.cbSServerIP = new System.Windows.Forms.ComboBox();
            this.cbSGameMap = new System.Windows.Forms.ComboBox();
            this.cbSGameMode = new System.Windows.Forms.ComboBox();
            this.cbSGameDifficulty = new System.Windows.Forms.ComboBox();
            this.cbSMaxPlayers = new System.Windows.Forms.ComboBox();
            this.cbSBotGame = new System.Windows.Forms.ComboBox();
            this.cbSWaitForPlayer = new System.Windows.Forms.ComboBox();
            this.cbSWaitForPlayerCount = new System.Windows.Forms.ComboBox();
            this.cbSWaitForPlayerTimeout = new System.Windows.Forms.ComboBox();
            this.tbSServerPort = new System.Windows.Forms.TextBox();
            this.labelSServerIP = new System.Windows.Forms.Label();
            this.labelSServerPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCJoinServer = new System.Windows.Forms.Button();
            this.tbCServerIP = new System.Windows.Forms.TextBox();
            this.tbCServerPort = new System.Windows.Forms.TextBox();
            this.tbCServerTVPort = new System.Windows.Forms.TextBox();
            this.tbCPlayerName = new System.Windows.Forms.TextBox();
            this.btnCGameStart = new System.Windows.Forms.Button();
            this.labelCServerIP = new System.Windows.Forms.Label();
            this.labelCPlayerName = new System.Windows.Forms.Label();
            this.labelCServerPort = new System.Windows.Forms.Label();
            this.labelCServerTVPort = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCJoinTeamBad = new System.Windows.Forms.Button();
            this.btnCJoinTeamTV = new System.Windows.Forms.Button();
            this.btnCJoinTeamGood = new System.Windows.Forms.Button();
            this.btnCAddBot = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.gbServer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbServerGame.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.btnSServerHost);
            this.gbServer.Controls.Add(this.groupBox1);
            this.gbServer.Controls.Add(this.gbServerGame);
            this.gbServer.Location = new System.Drawing.Point(12, 12);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(605, 260);
            this.gbServer.TabIndex = 0;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "局域网服务器设置";
            // 
            // btnSServerHost
            // 
            this.btnSServerHost.Location = new System.Drawing.Point(0, 226);
            this.btnSServerHost.Name = "btnSServerHost";
            this.btnSServerHost.Size = new System.Drawing.Size(606, 34);
            this.btnSServerHost.TabIndex = 3;
            this.btnSServerHost.Text = "建立服务器";
            this.btnSServerHost.UseVisualStyleBackColor = true;
            this.btnSServerHost.Click += new System.EventHandler(this.btnSServerHost_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSSourceTVAutorecord);
            this.groupBox1.Controls.Add(this.cbSSourceTVDelay);
            this.groupBox1.Controls.Add(this.cbSSourceTVMaxClients);
            this.groupBox1.Controls.Add(this.cbSSourceTV);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbSourceTVPort);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.labelSServerTVPort);
            this.groupBox1.Location = new System.Drawing.Point(399, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "观战设置";
            // 
            // cbSSourceTVAutorecord
            // 
            this.cbSSourceTVAutorecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSSourceTVAutorecord.FormattingEnabled = true;
            this.cbSSourceTVAutorecord.Location = new System.Drawing.Point(89, 157);
            this.cbSSourceTVAutorecord.Name = "cbSSourceTVAutorecord";
            this.cbSSourceTVAutorecord.Size = new System.Drawing.Size(100, 20);
            this.cbSSourceTVAutorecord.TabIndex = 18;
            // 
            // cbSSourceTVDelay
            // 
            this.cbSSourceTVDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSSourceTVDelay.FormattingEnabled = true;
            this.cbSSourceTVDelay.Location = new System.Drawing.Point(89, 126);
            this.cbSSourceTVDelay.Name = "cbSSourceTVDelay";
            this.cbSSourceTVDelay.Size = new System.Drawing.Size(100, 20);
            this.cbSSourceTVDelay.TabIndex = 17;
            // 
            // cbSSourceTVMaxClients
            // 
            this.cbSSourceTVMaxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSSourceTVMaxClients.FormattingEnabled = true;
            this.cbSSourceTVMaxClients.Location = new System.Drawing.Point(89, 95);
            this.cbSSourceTVMaxClients.Name = "cbSSourceTVMaxClients";
            this.cbSSourceTVMaxClients.Size = new System.Drawing.Size(100, 20);
            this.cbSSourceTVMaxClients.TabIndex = 16;
            // 
            // cbSSourceTV
            // 
            this.cbSSourceTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSSourceTV.FormattingEnabled = true;
            this.cbSSourceTV.Location = new System.Drawing.Point(89, 32);
            this.cbSSourceTV.Name = "cbSSourceTV";
            this.cbSSourceTV.Size = new System.Drawing.Size(100, 20);
            this.cbSSourceTV.TabIndex = 2;
            this.cbSSourceTV.TextChanged += new System.EventHandler(this.cbSSourceTV_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "自动保存";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "开启观战*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "观战上限";
            // 
            // tbSourceTVPort
            // 
            this.tbSourceTVPort.Location = new System.Drawing.Point(89, 63);
            this.tbSourceTVPort.Name = "tbSourceTVPort";
            this.tbSourceTVPort.Size = new System.Drawing.Size(100, 21);
            this.tbSourceTVPort.TabIndex = 7;
            this.tbSourceTVPort.Text = "27020";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "观战延迟";
            // 
            // labelSServerTVPort
            // 
            this.labelSServerTVPort.AutoSize = true;
            this.labelSServerTVPort.Location = new System.Drawing.Point(14, 66);
            this.labelSServerTVPort.Name = "labelSServerTVPort";
            this.labelSServerTVPort.Size = new System.Drawing.Size(53, 12);
            this.labelSServerTVPort.TabIndex = 4;
            this.labelSServerTVPort.Text = "观战端口";
            // 
            // gbServerGame
            // 
            this.gbServerGame.Controls.Add(this.cbSServerIP);
            this.gbServerGame.Controls.Add(this.cbSGameMap);
            this.gbServerGame.Controls.Add(this.cbSGameMode);
            this.gbServerGame.Controls.Add(this.cbSGameDifficulty);
            this.gbServerGame.Controls.Add(this.cbSMaxPlayers);
            this.gbServerGame.Controls.Add(this.cbSBotGame);
            this.gbServerGame.Controls.Add(this.cbSWaitForPlayer);
            this.gbServerGame.Controls.Add(this.cbSWaitForPlayerCount);
            this.gbServerGame.Controls.Add(this.cbSWaitForPlayerTimeout);
            this.gbServerGame.Controls.Add(this.tbSServerPort);
            this.gbServerGame.Controls.Add(this.labelSServerIP);
            this.gbServerGame.Controls.Add(this.labelSServerPort);
            this.gbServerGame.Controls.Add(this.label1);
            this.gbServerGame.Controls.Add(this.label2);
            this.gbServerGame.Controls.Add(this.label3);
            this.gbServerGame.Controls.Add(this.label8);
            this.gbServerGame.Controls.Add(this.label4);
            this.gbServerGame.Controls.Add(this.label5);
            this.gbServerGame.Controls.Add(this.label6);
            this.gbServerGame.Controls.Add(this.label7);
            this.gbServerGame.Location = new System.Drawing.Point(6, 26);
            this.gbServerGame.Name = "gbServerGame";
            this.gbServerGame.Size = new System.Drawing.Size(387, 189);
            this.gbServerGame.TabIndex = 1;
            this.gbServerGame.TabStop = false;
            this.gbServerGame.Text = "地图设置";
            // 
            // cbSServerIP
            // 
            this.cbSServerIP.FormattingEnabled = true;
            this.cbSServerIP.Location = new System.Drawing.Point(94, 32);
            this.cbSServerIP.Name = "cbSServerIP";
            this.cbSServerIP.Size = new System.Drawing.Size(100, 20);
            this.cbSServerIP.TabIndex = 21;
            // 
            // cbSGameMap
            // 
            this.cbSGameMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSGameMap.FormattingEnabled = true;
            this.cbSGameMap.Location = new System.Drawing.Point(94, 94);
            this.cbSGameMap.Name = "cbSGameMap";
            this.cbSGameMap.Size = new System.Drawing.Size(100, 20);
            this.cbSGameMap.TabIndex = 20;
            // 
            // cbSGameMode
            // 
            this.cbSGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSGameMode.FormattingEnabled = true;
            this.cbSGameMode.Location = new System.Drawing.Point(94, 124);
            this.cbSGameMode.Name = "cbSGameMode";
            this.cbSGameMode.Size = new System.Drawing.Size(100, 20);
            this.cbSGameMode.TabIndex = 19;
            // 
            // cbSGameDifficulty
            // 
            this.cbSGameDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSGameDifficulty.FormattingEnabled = true;
            this.cbSGameDifficulty.Location = new System.Drawing.Point(94, 154);
            this.cbSGameDifficulty.Name = "cbSGameDifficulty";
            this.cbSGameDifficulty.Size = new System.Drawing.Size(100, 20);
            this.cbSGameDifficulty.TabIndex = 18;
            // 
            // cbSMaxPlayers
            // 
            this.cbSMaxPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSMaxPlayers.FormattingEnabled = true;
            this.cbSMaxPlayers.Location = new System.Drawing.Point(268, 156);
            this.cbSMaxPlayers.Name = "cbSMaxPlayers";
            this.cbSMaxPlayers.Size = new System.Drawing.Size(100, 20);
            this.cbSMaxPlayers.TabIndex = 4;
            // 
            // cbSBotGame
            // 
            this.cbSBotGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSBotGame.Enabled = false;
            this.cbSBotGame.FormattingEnabled = true;
            this.cbSBotGame.Location = new System.Drawing.Point(268, 32);
            this.cbSBotGame.Name = "cbSBotGame";
            this.cbSBotGame.Size = new System.Drawing.Size(100, 20);
            this.cbSBotGame.TabIndex = 17;
            // 
            // cbSWaitForPlayer
            // 
            this.cbSWaitForPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSWaitForPlayer.FormattingEnabled = true;
            this.cbSWaitForPlayer.Location = new System.Drawing.Point(268, 63);
            this.cbSWaitForPlayer.Name = "cbSWaitForPlayer";
            this.cbSWaitForPlayer.Size = new System.Drawing.Size(100, 20);
            this.cbSWaitForPlayer.TabIndex = 16;
            this.cbSWaitForPlayer.TextChanged += new System.EventHandler(this.cbSWaitForPlayer_TextChanged);
            // 
            // cbSWaitForPlayerCount
            // 
            this.cbSWaitForPlayerCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSWaitForPlayerCount.FormattingEnabled = true;
            this.cbSWaitForPlayerCount.Location = new System.Drawing.Point(268, 94);
            this.cbSWaitForPlayerCount.Name = "cbSWaitForPlayerCount";
            this.cbSWaitForPlayerCount.Size = new System.Drawing.Size(100, 20);
            this.cbSWaitForPlayerCount.TabIndex = 15;
            // 
            // cbSWaitForPlayerTimeout
            // 
            this.cbSWaitForPlayerTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSWaitForPlayerTimeout.FormattingEnabled = true;
            this.cbSWaitForPlayerTimeout.Location = new System.Drawing.Point(268, 125);
            this.cbSWaitForPlayerTimeout.Name = "cbSWaitForPlayerTimeout";
            this.cbSWaitForPlayerTimeout.Size = new System.Drawing.Size(100, 20);
            this.cbSWaitForPlayerTimeout.TabIndex = 14;
            // 
            // tbSServerPort
            // 
            this.tbSServerPort.Location = new System.Drawing.Point(94, 63);
            this.tbSServerPort.Name = "tbSServerPort";
            this.tbSServerPort.Size = new System.Drawing.Size(100, 21);
            this.tbSServerPort.TabIndex = 6;
            this.tbSServerPort.Text = "27015";
            // 
            // labelSServerIP
            // 
            this.labelSServerIP.AutoSize = true;
            this.labelSServerIP.Location = new System.Drawing.Point(14, 35);
            this.labelSServerIP.Name = "labelSServerIP";
            this.labelSServerIP.Size = new System.Drawing.Size(65, 12);
            this.labelSServerIP.TabIndex = 2;
            this.labelSServerIP.Text = "服务器地址";
            // 
            // labelSServerPort
            // 
            this.labelSServerPort.AutoSize = true;
            this.labelSServerPort.Location = new System.Drawing.Point(14, 66);
            this.labelSServerPort.Name = "labelSServerPort";
            this.labelSServerPort.Size = new System.Drawing.Size(71, 12);
            this.labelSServerPort.TabIndex = 3;
            this.labelSServerPort.Text = "服务器端口*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "等待人数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "等待时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "AI练习赛";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "等待玩家";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "地图文件";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "地图模式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "地图难度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "玩家上限";
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.groupBox2);
            this.gbClient.Location = new System.Drawing.Point(12, 294);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(393, 181);
            this.gbClient.TabIndex = 1;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "局域网客户端设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCJoinServer);
            this.groupBox2.Controls.Add(this.tbCServerIP);
            this.groupBox2.Controls.Add(this.tbCServerPort);
            this.groupBox2.Controls.Add(this.tbCServerTVPort);
            this.groupBox2.Controls.Add(this.tbCPlayerName);
            this.groupBox2.Controls.Add(this.btnCGameStart);
            this.groupBox2.Controls.Add(this.labelCServerIP);
            this.groupBox2.Controls.Add(this.labelCPlayerName);
            this.groupBox2.Controls.Add(this.labelCServerPort);
            this.groupBox2.Controls.Add(this.labelCServerTVPort);
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 144);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基本设置";
            // 
            // btnCJoinServer
            // 
            this.btnCJoinServer.Location = new System.Drawing.Point(216, 24);
            this.btnCJoinServer.Name = "btnCJoinServer";
            this.btnCJoinServer.Size = new System.Drawing.Size(154, 45);
            this.btnCJoinServer.TabIndex = 9;
            this.btnCJoinServer.Text = "加入服务器";
            this.btnCJoinServer.UseVisualStyleBackColor = true;
            this.btnCJoinServer.Click += new System.EventHandler(this.btnCJoinServer_Click);
            // 
            // tbCServerIP
            // 
            this.tbCServerIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCServerIP.Location = new System.Drawing.Point(92, 24);
            this.tbCServerIP.Name = "tbCServerIP";
            this.tbCServerIP.Size = new System.Drawing.Size(100, 21);
            this.tbCServerIP.TabIndex = 0;
            this.tbCServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCServerIP.TextChanged += new System.EventHandler(this.tbCServerIP_TextChanged);
            // 
            // tbCServerPort
            // 
            this.tbCServerPort.Location = new System.Drawing.Point(92, 51);
            this.tbCServerPort.Name = "tbCServerPort";
            this.tbCServerPort.Size = new System.Drawing.Size(100, 21);
            this.tbCServerPort.TabIndex = 1;
            this.tbCServerPort.Text = "27015";
            this.tbCServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCServerPort.TextChanged += new System.EventHandler(this.tbCServerPort_TextChanged);
            // 
            // tbCServerTVPort
            // 
            this.tbCServerTVPort.Location = new System.Drawing.Point(92, 78);
            this.tbCServerTVPort.Name = "tbCServerTVPort";
            this.tbCServerTVPort.Size = new System.Drawing.Size(100, 21);
            this.tbCServerTVPort.TabIndex = 2;
            this.tbCServerTVPort.Text = "27020";
            this.tbCServerTVPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCPlayerName
            // 
            this.tbCPlayerName.Location = new System.Drawing.Point(92, 105);
            this.tbCPlayerName.Name = "tbCPlayerName";
            this.tbCPlayerName.Size = new System.Drawing.Size(100, 21);
            this.tbCPlayerName.TabIndex = 3;
            this.tbCPlayerName.Text = "idream";
            this.tbCPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCGameStart
            // 
            this.btnCGameStart.Location = new System.Drawing.Point(216, 81);
            this.btnCGameStart.Name = "btnCGameStart";
            this.btnCGameStart.Size = new System.Drawing.Size(154, 45);
            this.btnCGameStart.TabIndex = 8;
            this.btnCGameStart.Text = "启动游戏";
            this.btnCGameStart.UseVisualStyleBackColor = true;
            this.btnCGameStart.Click += new System.EventHandler(this.btnCGameStart_Click);
            // 
            // labelCServerIP
            // 
            this.labelCServerIP.AutoSize = true;
            this.labelCServerIP.Location = new System.Drawing.Point(16, 27);
            this.labelCServerIP.Name = "labelCServerIP";
            this.labelCServerIP.Size = new System.Drawing.Size(65, 12);
            this.labelCServerIP.TabIndex = 4;
            this.labelCServerIP.Text = "服务器地址";
            // 
            // labelCPlayerName
            // 
            this.labelCPlayerName.AutoSize = true;
            this.labelCPlayerName.Location = new System.Drawing.Point(16, 108);
            this.labelCPlayerName.Name = "labelCPlayerName";
            this.labelCPlayerName.Size = new System.Drawing.Size(53, 12);
            this.labelCPlayerName.TabIndex = 7;
            this.labelCPlayerName.Text = "玩家昵称";
            // 
            // labelCServerPort
            // 
            this.labelCServerPort.AutoSize = true;
            this.labelCServerPort.Location = new System.Drawing.Point(16, 54);
            this.labelCServerPort.Name = "labelCServerPort";
            this.labelCServerPort.Size = new System.Drawing.Size(71, 12);
            this.labelCServerPort.TabIndex = 5;
            this.labelCServerPort.Text = "服务器端口*";
            // 
            // labelCServerTVPort
            // 
            this.labelCServerTVPort.AutoSize = true;
            this.labelCServerTVPort.Location = new System.Drawing.Point(16, 81);
            this.labelCServerTVPort.Name = "labelCServerTVPort";
            this.labelCServerTVPort.Size = new System.Drawing.Size(59, 12);
            this.labelCServerTVPort.TabIndex = 6;
            this.labelCServerTVPort.Text = "观战端口*";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCJoinTeamBad);
            this.groupBox3.Controls.Add(this.btnCJoinTeamTV);
            this.groupBox3.Controls.Add(this.btnCJoinTeamGood);
            this.groupBox3.Controls.Add(this.btnCAddBot);
            this.groupBox3.Location = new System.Drawing.Point(411, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 181);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "快捷按钮";
            // 
            // btnCJoinTeamBad
            // 
            this.btnCJoinTeamBad.Location = new System.Drawing.Point(101, 56);
            this.btnCJoinTeamBad.Name = "btnCJoinTeamBad";
            this.btnCJoinTeamBad.Size = new System.Drawing.Size(89, 34);
            this.btnCJoinTeamBad.TabIndex = 11;
            this.btnCJoinTeamBad.Text = "加入夜魇";
            this.btnCJoinTeamBad.UseVisualStyleBackColor = true;
            this.btnCJoinTeamBad.Click += new System.EventHandler(this.btnCJoinTeamBad_Click);
            // 
            // btnCJoinTeamTV
            // 
            this.btnCJoinTeamTV.Location = new System.Drawing.Point(101, 111);
            this.btnCJoinTeamTV.Name = "btnCJoinTeamTV";
            this.btnCJoinTeamTV.Size = new System.Drawing.Size(89, 34);
            this.btnCJoinTeamTV.TabIndex = 13;
            this.btnCJoinTeamTV.Text = "加入观战";
            this.btnCJoinTeamTV.UseVisualStyleBackColor = true;
            this.btnCJoinTeamTV.Click += new System.EventHandler(this.btnCJoinTeamTV_Click);
            // 
            // btnCJoinTeamGood
            // 
            this.btnCJoinTeamGood.Location = new System.Drawing.Point(6, 56);
            this.btnCJoinTeamGood.Name = "btnCJoinTeamGood";
            this.btnCJoinTeamGood.Size = new System.Drawing.Size(89, 34);
            this.btnCJoinTeamGood.TabIndex = 10;
            this.btnCJoinTeamGood.Text = "加入天辉";
            this.btnCJoinTeamGood.UseVisualStyleBackColor = true;
            this.btnCJoinTeamGood.Click += new System.EventHandler(this.btnCJoinTeamGood_Click);
            // 
            // btnCAddBot
            // 
            this.btnCAddBot.Location = new System.Drawing.Point(6, 111);
            this.btnCAddBot.Name = "btnCAddBot";
            this.btnCAddBot.Size = new System.Drawing.Size(89, 34);
            this.btnCAddBot.TabIndex = 12;
            this.btnCAddBot.Text = "填充AI";
            this.btnCAddBot.UseVisualStyleBackColor = true;
            this.btnCAddBot.Click += new System.EventHandler(this.btnCAddBot_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(467, 479);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(124, 12);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "版本: ";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(596, 475);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(21, 21);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "!";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // DotA2ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.gbClient);
            this.Controls.Add(this.gbServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DotA2ToolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "idreamDotA2LanTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DotA2ToolForm_FormClosing);
            this.gbServer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbServerGame.ResumeLayout(false);
            this.gbServerGame.PerformLayout();
            this.gbClient.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.GroupBox gbServerGame;
        private System.Windows.Forms.Button btnCJoinTeamTV;
        private System.Windows.Forms.Button btnCAddBot;
        private System.Windows.Forms.Button btnCJoinTeamBad;
        private System.Windows.Forms.Button btnCJoinTeamGood;
        private System.Windows.Forms.Button btnCJoinServer;
        private System.Windows.Forms.Button btnCGameStart;
        private System.Windows.Forms.Label labelCPlayerName;
        private System.Windows.Forms.Label labelCServerTVPort;
        private System.Windows.Forms.Label labelCServerPort;
        private System.Windows.Forms.Label labelCServerIP;
        private System.Windows.Forms.TextBox tbCPlayerName;
        private System.Windows.Forms.TextBox tbCServerTVPort;
        private System.Windows.Forms.TextBox tbCServerPort;
        private System.Windows.Forms.TextBox tbCServerIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSourceTVPort;
        private System.Windows.Forms.Label labelSServerTVPort;
        private System.Windows.Forms.Button btnSServerHost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSServerPort;
        private System.Windows.Forms.Label labelSServerIP;
        private System.Windows.Forms.Label labelSServerPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSSourceTVAutorecord;
        private System.Windows.Forms.ComboBox cbSSourceTVDelay;
        private System.Windows.Forms.ComboBox cbSSourceTVMaxClients;
        private System.Windows.Forms.ComboBox cbSSourceTV;
        private System.Windows.Forms.ComboBox cbSBotGame;
        private System.Windows.Forms.ComboBox cbSWaitForPlayer;
        private System.Windows.Forms.ComboBox cbSWaitForPlayerCount;
        private System.Windows.Forms.ComboBox cbSWaitForPlayerTimeout;
        private System.Windows.Forms.ComboBox cbSGameMap;
        private System.Windows.Forms.ComboBox cbSGameMode;
        private System.Windows.Forms.ComboBox cbSGameDifficulty;
        private System.Windows.Forms.ComboBox cbSMaxPlayers;
        private System.Windows.Forms.ComboBox cbSServerIP;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnAbout;
    }
}

