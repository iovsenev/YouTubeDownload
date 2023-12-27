using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload.Exceptions
{
    internal class InvalidUrlException : Exception
    {
        public override string Message => $"Не верный адрес.";
    }
}
