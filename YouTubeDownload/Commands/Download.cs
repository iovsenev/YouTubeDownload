
using YouTubeDownload.Exceptions;
using YouTubeDownload.Interfaces;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YouTubeDownload.Commands
{
    internal class Download : Command
    {
        public Download(UserInterface user)
        {
            _user = user;
            _client = new YoutubeClient();
        }

        public override async Task Start()
        {
            string path;
            _user.ReadUrlYoutubeVideo();
            _user.ReadNameFile();
            

            var streamManifest = _client.Videos.Streams.GetManifestAsync(_user.YoutubeUrl).Result;
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            var id = _client.Videos.GetAsync(_user.YoutubeUrl).Result.Id.Value;

            if (string.IsNullOrEmpty(_user.OutputFileName))
                path = Path.Combine(_user.PathOutput, $"{id}.{streamInfo.Container}");
            else
                path = Path.Combine(_user.PathOutput, $"{_user.OutputFileName}.{streamInfo.Container}");

            Console.WriteLine("\nЗагрузка началась");
            await _client.Videos.Streams.DownloadAsync(streamInfo, path);
            await Console.Out.WriteLineAsync("Загрузка завершена"); ;

        }
    }
}