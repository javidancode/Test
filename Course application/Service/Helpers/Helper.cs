using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Helpers
{
    public static class Helper
    {
        public static void WriteConsole(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }

    public enum Menues
    {
        CreateGroup = 1,
        GetGroupId = 2,
        UpdateGroup = 3,
        DeleteGroup = 4,
        GetAllGroup = 5,
        SearchGroup = 6,
        

    }
}
