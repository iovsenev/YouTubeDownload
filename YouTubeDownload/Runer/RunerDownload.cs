using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YouTubeDownload.Commands;
using YouTubeDownload.Interfaces;
using YouTubeDownload.Utilites;

namespace YouTubeDownload.Runer
{
    internal class RunerDownload: IRuner
    {
        UserInterface _user;

        public RunerDownload(UserInterface user)
        {
            _user = user;
        }

        public async Task RunAsync()
        {
            await RunDownload();
            await ShowInfoDownloadFile();
        }

        private async Task ShowInfoDownloadFile()
        {
            Command command = new InfoFile(_user);
            await command.Start();
        }

        private async Task RunDownload()
        {
            Command command = new Download(_user);
            var task = command.Start();
            var run = true;
            while (run)
            {
                run = !task.IsCompleted;
                LoadBar.Bar(task);
            }
            await task;
        }
    }
}
