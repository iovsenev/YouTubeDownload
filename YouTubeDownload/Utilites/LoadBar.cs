using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload.Utilites
{
    internal static class LoadBar
    {
        public static void Bar(Task task)
        {
            StringBuilder str = new StringBuilder();
            str.Append("[       ]\r");
            Console.Write(str + "\r");
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (task.IsCompleted)
                    break;
                str[i] = '*';
                Thread.Sleep(1000);
                Console.Write(str);
            }

        }
    }
}
