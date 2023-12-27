
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
        public Download()
        {
        }

        public override async Task DownloadVideo(string url, string output)
        {
            var client = new YoutubeClient();
            var video = await client.Videos.GetAsync(url);

            var streamManifest = client.Videos.Streams.GetManifestAsync(url).Result;
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            var stream = client.Videos.Streams.GetAsync(streamInfo).Result;
            var direct = Path.Combine(output, $"{video.Id.Value}.{streamInfo.Container}");
            Console.WriteLine("Скачивание началось");
            await client.Videos.Streams.DownloadAsync(streamInfo, direct);
            await Console.Out.WriteLineAsync("скачивание закончено"); ;

        }
    }
}