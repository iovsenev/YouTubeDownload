
using YouTubeDownload.Interfaces;
using YoutubeExplode;

namespace YouTubeDownload.Commands
{
    internal class InfoFile : Command
    {
        public InfoFile(UserInterface user)
        {
            _user = user;
            _client = new YoutubeClient();
        }

        public override async Task Start()
        {
            var video = await _client.Videos.GetAsync(_user.YoutubeUrl);
            var videoId = video.Id.Value;
            var videoTitele = video.Title;
            var videoAuthor = video.Author.ToString();
            await Console.Out.WriteLineAsync($"\nВидео загруженно в: {_user.PathOutput}");
            await Console.Out.WriteLineAsync($"Имя видео: {videoId}");
            await Console.Out.WriteLineAsync($"Название видео: {videoTitele}");
            await Console.Out.WriteLineAsync($"Автор видео: {videoAuthor}");
        }
    }
}
