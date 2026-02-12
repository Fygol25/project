using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Robot bot = new Robot();
            bot.SetValues("Bot", 3, new byte[] { 0, 0, 0 });

            Robot killer = new Robot();
            killer.SetValues("Killer", 2, new byte[] { 0, 1, 0 });

            bot.PrintValues();
            killer.PrintValues();
        }
    }
}
