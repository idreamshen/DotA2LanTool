using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MangoDotA2Tool
{
    class CopyFolder
    {
        public CopyFolder(string sourceFolder, string destFolder)
        {
            Copy(sourceFolder, destFolder);
        }

        private void Copy(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
            {
                Directory.CreateDirectory(destFolder);
            }
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(destFolder, fileName);
                try
                {
                    File.Copy(file, destFile, true);
                }
                catch
                {
                    // 不抛出任何异常,用来忽略文件正在被使用的问题
                }
                
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string folderName = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, folderName);
                Copy(folder, dest);
            }
        }

    }
}
