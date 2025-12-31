using System;
using System.Threading;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ストップウォッチを開始します。");
            Console.WriteLine("スペースキーで一時停止/再開、Deleteキーで0クリア、Enterキーで終了");

            double counter = 0.0;  // 秒単位
            bool paused = false;
            bool exit = false;

            // キー入力監視スレッド
            Thread keyThread = new Thread(() =>
            {
                while (!exit)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true).Key;

                        if (key == ConsoleKey.Spacebar)
                        {
                            paused = !paused;
                            Console.WriteLine(paused ? "\n一時停止" : "\n再開");
                        }
                        else if (key == ConsoleKey.Delete)
                        {
                            counter = 0.0;
                            Console.WriteLine("\nクリア: 00:00.0");
                        }
                        else if (key == ConsoleKey.Enter)
                        {
                            exit = true;
                        }
                    }
                    Thread.Sleep(20);
                }
            });
            keyThread.IsBackground = true;
            keyThread.Start();

            // メインループ（0.1秒刻み）
            var stopwatchInterval = 100; // 0.1秒 = 100ms
            while (!exit)
            {
                if (!paused)
                {
                    counter += stopwatchInterval / 1000.0;

                    int minutes = (int)(counter / 60);
                    int seconds = (int)(counter % 60);
                    int tenths = (int)((counter * 10) % 10);

                    Console.Write($"\r{minutes:00}:{seconds:00}.{tenths}");
                    Thread.Sleep(stopwatchInterval);
                }
                else
                {
                    Thread.Sleep(50);
                }
            }

            Console.WriteLine($"\n終了しました。最終時間: {counter:0.0}秒");
        }
    }
}
