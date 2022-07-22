using Course_application.Controllers;
using Domain.Models;
using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;

namespace Course_application
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupService groupService = new GroupService();
            GroupController groupController = new GroupController();
            Helper.WriteConsole(ConsoleColor.Blue, "Select one option : ");
            GetMenues();

            while (true)
            {
                SelectOption: string selectOption = Console.ReadLine();

                int seletcTrueOption;

                bool isSelectOption = int.TryParse(selectOption, out seletcTrueOption);

                if (isSelectOption)
                {
                    switch (seletcTrueOption)
                    {
                        case (int)Menues.CreateGroup:

                            groupController.Create();

                            break;
                        case (int)Menues.GetGroupId:

                            groupController.GetById();

                            break;
                        case (int)Menues.UpdateGroup:

                            groupController.Update();
                            break;

                        case (int)Menues.DeleteGroup:

                            groupController.Delete();

                            break;
                        case (int)Menues.GetAllGroup:

                            groupController.GetAll();

                            break;
                        case (int)Menues.SearchGroup:

                            groupController.Search();

                            break;
                        default:
                            Helper.WriteConsole(ConsoleColor.Red, "Select correct option number : ");
                            break;
                    }
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Select correct option : ");
                    goto SelectOption;
                }
            }
        }
        private static void GetMenues()
        {
            Helper.WriteConsole(ConsoleColor.Green, "1 - Create group's, 2 - Get group's by id , 3 - Update group's, 4 - Delete group's," +
                " 5 - Get all group's, 6 - Search for group by name, 7 - Get all groups  by teacher, 8 - Get all groups by room :");
        }
    }
}
