using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload.Commands
{
    abstract class Command
    {
        public abstract Task DownloadVideo(string url, string output);
    }
}
