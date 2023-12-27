using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeDownload.Commands;

namespace YouTubeDownload
{
    internal class UserInterface
    {
        string _youtubeUrl;
        public string YoutubeUrl { get { return _youtubeUrl; } }

        string _pathOutput;
        public string PathOutput { get { return _pathOutput; } }
        string _outputFileName;
        public string OutputFileName { get { return _outputFileName; } }

        public UserInterface()
        {
            _youtubeUrl = @"https://www.youtube.com/watch?v=eW9XzvlpxWQ";
            _pathOutput = @"C:\Users\ovsen\OneDrive\Рабочий стол\Новая папка";
            //WriteUrlAndOutputDirectory();
        }

        public void WriteUrlAndOutputDirectory()
        {
            Console.Write("Ведите URL YouTube видео: ");
            _youtubeUrl = Console.ReadLine();

            Console.Write("Введите папку для скачивания файла: ");
            _pathOutput = Console.ReadLine();
            if (!Directory.Exists(_pathOutput))
                Directory.CreateDirectory(_pathOutput);
        }
    }
}
