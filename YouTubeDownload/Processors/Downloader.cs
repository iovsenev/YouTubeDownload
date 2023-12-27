using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeDownload.Commands;
using YouTubeDownload.Interfaces;

namespace YouTubeDownload.Processors
{
    internal class Downloader
    {
        Command _comand;
        UserInterface _userInterface;

        public Downloader()
        {
            _comand = new Download();
            _userInterface = new UserInterface();
        }

        public async Task Run()
        {
            _comand.DownloadVideo(_userInterface.YoutubeUrl, _userInterface.PathOutput).Wait();
        }

    }
}
