using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using Accord.Audio.Formats;
using Accord.Audio;

namespace Assignement4Audio
{
    class AudioFeatures
    {
        private string[] audioFileName;

        public void SetDirectoryPaths(string folderPath)
        {
            audioFileName = Directory.GetFiles(folderPath, "*.wav").Select(Path.GetFileName).OrderBy(r => r.Length).ToArray();

            for (int i = 0; i < audioFileName.Length; i++)
            {
                string fileName = audioFileName[i];
                WaveDecoder sourceWD = new WaveDecoder(fileName);
                Signal sourceS = sourceWD.Decode();

                //RaisedCosineWindow window = RaisedCosineWindow.Hamming(1024);
                //Signal[] windows = sourceS.Split(window, 512);

                //ComplexSignal[] complex = windows.Apply(ComplexSignal.FromSignal);

                //complex.ForwardFourierTransform();
            }
        }
    }
}
