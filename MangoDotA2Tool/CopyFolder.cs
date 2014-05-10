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
                File.Copy(file, destFile, true);
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
