using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeDownload.Interfaces
{
    internal class YoutubeUrl
    {
        string _YutubeUrl;
        public string YutubeUrl { get { return _YutubeUrl; } }

        public YoutubeUrl(string yutubeUrl)
        {
            _YutubeUrl = yutubeUrl;
        }   
    }
}
