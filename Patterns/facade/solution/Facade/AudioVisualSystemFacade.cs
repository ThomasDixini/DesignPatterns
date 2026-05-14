using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.ThirdParty.Classes;

namespace solution.Facade
{
    public class AudioVisualSystemFacade
    {
        private readonly VideoFile videoFile;
        private readonly MP3Converter mp3Converter;

        public AudioVisualSystemFacade(VideoFile videoFile, MP3Converter mp3Converter)
        {
            this.videoFile = videoFile;
            this.mp3Converter = mp3Converter;
        }

        public string Convert(string fileName)
        {
            var formatInfo = videoFile.GetVideoFormat(fileName);
            var conversionResult = mp3Converter.Convert();

            return $"Converting '{fileName}' to MP3...\n{formatInfo}\n{conversionResult}";
        }
    }
}