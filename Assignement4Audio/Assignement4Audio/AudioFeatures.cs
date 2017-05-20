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
        private string[] pathToAudio;

        public void SetDirectoryPaths(string folderPath)
        {
            pathToAudio = Directory.GetFiles(folderPath.TrimEnd(Path.DirectorySeparatorChar), "*.wav").OrderBy(r => r.Length).ToArray();
            WaveDecoder WavDec;
        }
    }
}
