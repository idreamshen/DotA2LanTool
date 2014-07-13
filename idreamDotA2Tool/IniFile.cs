using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;


namespace idreamDotA2Tool
{
    
    class IniFile
    {
        //声明写INI文件的API函数 
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        //声明读INI文件的API函数 
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        //INI文件名
        private string path; 
        //类的构造函数，传递INI文件的路径和文件名
        public IniFile(string INIPath)
        {
            path = INIPath;
        }

        //写INI文件
        private void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, path);
        }

        //读取INI文件 
        private string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, path);
            return temp.ToString();
        }

        // [Loader]
        // Path
        public string lPath
        {
            set
            {
                IniWriteValue("Loader", "Path", value);
            }
            get
            {
                return IniReadValue("Loader", "Path");
            }
        }

        // [Server]
        // ServerPort
        public string sServerPort
        {
            set
            {
                IniWriteValue("Server", "ServerPort", value);
            }
            get
            {
                return IniReadValue("Server", "ServerPort");
            }
        }

        // [Client]
        // ServerIP
        public string cServerIP
        {
            set
            {
                IniWriteValue("Client", "ServerIP", value);
            }
            get
            {
                return IniReadValue("Client", "ServerIP");
            }
        }

        // ServerPort
        public string cServerPort
        {
            set
            {
                IniWriteValue("Client", "ServerPort", value);
            }
            get
            {
                return IniReadValue("Client", "ServerPort");
            }
        }

        // PlayerName
        public string cPlayerName
        {
            set
            {
                IniWriteValue("Client", "PlayerName", value);
            }
            get
            {
                return IniReadValue("Client", "PlayerName");
            }
        }

        // rev.ini
        // PlayerName
        public string rPlayerName
        {
            set
            {
                WritePrivateProfileString("steamclient", "PlayerName", value, Path.GetDirectoryName(path) + "\\REVClientPatch\\rev.ini");
            }
            get
            {
                return IniReadValue("steamclient", "PlayerName");
            }
        }

        // ServerIPNSNet
        public string rServerIPNSNet
        {
            set
            {
                WritePrivateProfileString("GameServerNSNet", "ServerIPNSNet", value, Path.GetDirectoryName(path) + "\\REVPatch\\rev.ini");
            }
            get
            {
                return IniReadValue("GameServerNSNet", "ServerIPNSNet");
            }
        }
    }
}
