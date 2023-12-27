using YouTubeDownload.Processors;

namespace YouTubeDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Downloader downloader = new Downloader();
            downloader.Run();
        }
    }
}
