using System;
using System.IO;

namespace Server
{
    class MSG
    {
        public static void Chat(DateTime startTime)
        {
            var msg = new MSG();
            Console.WriteLine("- Здравствуйте, я консольный чат бот. Я могу выполнить следующие команды\n   сколько сейчас времени?\n   как тебя зовут?\n   как дела?\n   сколько времени ты работаешь?\n   покажи нашу переписку\n   очисти экран\n   список команд\n   выйти из чата");
            History("Здравствуйте, я консольный чат бот. Я могу выполнить следующие команды\n   сколько сейчас времени?\n   как тебя зовут?\n   как дела?\n   сколько времени ты работаешь?\n   покажи нашу переписку\n   очисти экран\n   список команд\n   выйти из чата");
        cin_command:
            Console.Write("- ");
            string command = Console.ReadLine();
            History(command);
            switch (command)
            {
                case ("сколько сейчас времени?"):
                    {
                        Console.WriteLine($"- {Bot.WT()}");
                        goto cin_command;
                    }
                case ("как тебя зовут?"):
                    {
                        Console.WriteLine($"- {Bot.Name()}");
                        History(Bot.Name());
                        goto cin_command;
                    }
                case ("как дела?"):
                    {
                        Console.WriteLine($"- {Bot.HYD()}");
                        goto cin_command;
                    }
                case ("сколько времени ты работаешь?"):
                    {
                        Console.WriteLine($"- {Bot.TOS(startTime)}");
                        goto cin_command;
                    }
                case ("покажи нашу переписку"):
                    {
                        Bot.History();
                        goto cin_command;
                    }
                case ("очисти экран"):
                    {
                        Bot.CLS();
                        goto cin_command;
                    }
                case ("список команд"):
                    {
                        Bot.Help();
                        goto cin_command;
                    }
                case ("выйти из чата"):
                    {
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Я не знаю такой команды, повторите ввод снова, или вызовите окно команд при помощт команды ''список команд''");
                        History("Я не знаю такой команды, повторите ввод снова, или вызовите окно команд при помощт команды ''список команд''");
                        goto cin_command;
                    }
            }
            var del = new StreamWriter("ServerHistory.txt");
            del.Close();
        }
        public static void History(string line)
        {
            var outfHistory = new StreamWriter("ServerHistory.txt", true);
            outfHistory.WriteLine($"- {line}");
            outfHistory.Close();
        }
    }
}
