using System.Net;


namespace OtusHomeWork9
{
    internal class ImageDownloader
    {
        public delegate void ImageDownloadHandler(string message);
        public event ImageDownloadHandler? Notify;
        public async void Download(string urlImage)
        {

            string fileName = "bigimage.jpg";
            var myWebClient = new WebClient();
            //Notify?.Invoke($"Скачивание файла началось: {urlImage}");
            //Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, urlImage);
            var downloadTask =  myWebClient.DownloadFileTaskAsync(urlImage, fileName);
            //Notify?.Invoke($"Скачивание файла закончилось: {urlImage}");
            //Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, urlImage);
            Console.WriteLine("Нажмите клавишу A для выхода или любую другую клавишу для проверки статуса скачивания ");
            var pressedButton = Console.ReadLine();
            if (pressedButton != "A")
            {
                if (downloadTask.IsCompleted) 
                {
                    await Console.Out.WriteLineAsync("True");
                }
                else
                { await Console.Out.WriteLineAsync("False");
                }
            } 
        }
    }
}
