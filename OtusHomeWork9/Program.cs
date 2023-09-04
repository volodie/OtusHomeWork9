using System.Net;
using OtusHomeWork9;

internal class Program
{
    private const string remotUrl = "https://img1.akspic.ru/attachments/crops/9/9/5/2/7/172599/172599-nacionalnyj_park_banf-morennoe_ozero-priroda-nacionalnyj_park-banff-7680x4320.jpg";
    
    private static void Main(string[] args)
    {
        void DisplayMessage(string message) => Console.WriteLine(message);
        ImageDownloader imageDownloader = new ImageDownloader();
        imageDownloader.Notify += DisplayMessage;
        imageDownloader.Download(remotUrl);
        imageDownloader.Notify -= DisplayMessage;
    }
}