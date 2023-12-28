

namespace YouTubeDownload.Interfaces
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
            ReadPathDownload();
        }

        public void ReadUrlYoutubeVideo()
        {
            Console.Write("\nВедите полный URL YouTube видео или id видео .../asldkjf: ");
            _youtubeUrl = Console.ReadLine();
        }

        private void ReadPathDownload()
        {
            Console.Write("\nВведите полный путь до папки куда планируете сохранить файл\n" +
                "(Вводится одит раз при старте программы): ");
            var path = Console.ReadLine();
            if (!string.IsNullOrEmpty(path))
            {
                _pathOutput = path;
                return;
            }
            var directory = new DirectoryInfo("Download");
            if (!directory.Exists)
                directory.Create();
            _pathOutput = directory.FullName;
            Console.WriteLine("\nФайл будет сохранен в: \n{0}", _pathOutput);
        }

        public void ReadNameFile()
        {
            Console.Write("\nВведите название файла " +
                "или нажмите Enter для получения названия по умолчанию: ");
            _outputFileName = Console.ReadLine();
        }
    }
}
