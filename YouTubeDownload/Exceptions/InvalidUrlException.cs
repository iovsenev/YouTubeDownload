
namespace YouTubeDownload.Exceptions
{
    internal class InvalidUrlException : Exception
    {
        public override string Message => $"Не верный адрес.";
    }
}
