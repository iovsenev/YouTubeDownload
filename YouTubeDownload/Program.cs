using YouTubeDownload.Interfaces;
using YouTubeDownload.Runer;

namespace YouTubeDownload
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            ShowStartMessage();
            var userInterface = new UserInterface();
            IRuner runer = new RunerDownload(userInterface);
            while (true)
            {
                try
                {
                    await runer.RunAsync();
                }
                catch
                {
                    ConsoleColor def = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nНе верный URL для видео.\n");
                    Console.ForegroundColor = def;
                }
                Console.WriteLine();
                Console.Write("\nЕсли хотите продолжить нажмите Enter, если выйти введите Exit: ");

                var req = Console.ReadLine();

                if (req.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.Clear();
                ShowStartMessage();
            }
        }

        private static void ShowStartMessage()
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n******** Вы в приложении для скачивани видео! ********\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Для того чтобы скачать видео необходимо ввести по запросу\n" +
                "URL адрес видео в формате \"https://www.youtube.com/watch?v=eW9XzvlpxWQ\"\n" +
                "дальше вас попросят ввести путь к папке куда сохранить файл\n" +
                "например \"C:\\Users\\download\"");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n************* Приступаем: ****************");
            Console.ForegroundColor = def;
        }
    }
}
