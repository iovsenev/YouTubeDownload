using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload.Interfaces
{
    internal class DirectoryOutput
    {
        string _pathDirectoryOutput;
        string _outputFileName;
        public string PathOutput { get { return _pathDirectoryOutput; } }
        public string OutputFileName { get { return _outputFileName; } }

        public DirectoryOutput(string pathOutput, string fileName)
        {
            _pathDirectoryOutput = pathOutput;
            _outputFileName = fileName;
        }
    }
}
