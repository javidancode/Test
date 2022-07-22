using Domain.Models;
using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_application.Controllers
{
    public class StudentController
    {
        StudentService studentService = new StudentService();

        public void Create()
        {

            Helper.WriteConsole(ConsoleColor.Blue, "Select correct option : ");

        GroupId: string groupId = Console.ReadLine();

            int selectedGroupId;
            int SelectedAge;

            bool isSelectedId = int.TryParse(groupId, out selectedGroupId);

            if (isSelectedId)
            {
                Helper.WriteConsole(ConsoleColor.Blue, "Select correct option : ");

                string StudentName = Console.ReadLine();

                Helper.WriteConsole(ConsoleColor.Blue, "Select correct option : ");

                string StudentSurname = Console.ReadLine();

                Helper.WriteConsole(ConsoleColor.Blue, "Select correct option : ");

                //int StudentAge = Console.ReadLine();



                Student student = new Student
                {
                    Name = StudentName,
                    Surname = StudentSurname,
                    //Age = StudentAge
                };
            }

        }
    }
}
