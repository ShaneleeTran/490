using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using Accord.Audio.Formats;

namespace Assignement4Audio
{
    class AudioFeatures
    {
        private string[] audioFileName;

        public void SetDirectoryPaths(string folderPath)
        {
            audioFileName = Directory.GetFiles(folderPath, "*.wav").Select(Path.GetFileName).ToArray();
        }
    }
}
