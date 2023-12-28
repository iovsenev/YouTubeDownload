
using YouTubeDownload.Interfaces;
using YoutubeExplode;

namespace YouTubeDownload.Commands
{
    abstract class Command
    {
        protected UserInterface _user;
        protected YoutubeClient _client;

        public abstract Task Start();
    }
}
