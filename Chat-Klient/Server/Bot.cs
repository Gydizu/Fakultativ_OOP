using System;
using System.IO;

namespace Server
{
    class Bot
    {
        public static string WT()
        {
            string now = DateTime.UtcNow.ToString();
            MSG.History(now);
            return now;
        }
        public static string Name() => "Боба Фет";
        public static string HYD()
        {
            string affairs = "\n";
            var infAffairs = new StreamReader("ServerAffairs.txt");
            var rand = new Random();
            int n = rand.Next(1, 204);
            for (int i = 0; i < n; i++)
                affairs = infAffairs.ReadLine();
            infAffairs.Close();
            MSG.History(affairs);
            return affairs;
        }
        public static string TOS(DateTime startTime)
        {
            string tos = (DateTime.Now - startTime).ToString();
            MSG.History(tos);
            return tos;
        }
        public static void History()
        {
            Console.WriteLine("- Наша переписка");
            MSG.History("Наша переписка");
            var infHistory = new StreamReader("ServerHistory.txt");
            while (infHistory.ReadLine() != null)
                Console.WriteLine(infHistory.ReadLine());
            infHistory.Close();
        }
        public static void CLS() => Console.Clear();
        public static void Help()
        {
            Console.WriteLine("- сколько сейчас времени?\n   как тебя зовут?\n   как дела?\n   сколько времени ты работаешь?\n   покажи нашу переписку\n   очисти экран\n   выйти из чата");
            MSG.History("сколько сейчас времени?\n   как тебя зовут?\n   как дела?\n   сколько времени ты работаешь?\n   покажи нашу переписку\n   очисти экран\n   выйти из чата");
        }
    }
}
