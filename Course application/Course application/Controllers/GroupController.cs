using Domain.Models;
using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_application.Controllers
{
    public class GroupController
    {
        GroupService groupService = new GroupService();

        public void Create()
        {
            Helper.WriteConsole(ConsoleColor.Blue, "Add group's name: ");
            string groupName = Console.ReadLine();
        inputname:
            Helper.WriteConsole(ConsoleColor.Blue, "Add group's teacher name: ");
            string groupTeacher = Console.ReadLine();

            foreach (var item in groupTeacher)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (item.ToString() == i.ToString())
                    {
                        Helper.WriteConsole(ConsoleColor.Red, "Please add correct please groupTeacher  : ");
                        goto inputname;
                    }
                    
                }




            }

            Helper.WriteConsole(ConsoleColor.Blue, "Add group's room name: ");
            string groupRoom = Console.ReadLine();


            Group group = new Group
            {
                Name = groupName,
                Teacher = groupTeacher,
                Room = groupRoom
            };

            var result = groupService.Create(group);
            Helper.WriteConsole(ConsoleColor.Green, $"Group Id : {result.Id}, Group name : {result.Name}, Group's teacher name: {result.Teacher}, Group's room name : {group.Room} ");


        }

        public void GetById()
        {
            Helper.WriteConsole(ConsoleColor.Blue, "Add group's id: ");
        GroupId: string groupId = Console.ReadLine();
            int id;
            bool isGroupId = int.TryParse(groupId, out id);

            if (isGroupId)
            {
                Group group1 = groupService.GetById(id);
                if (group1 != null)
                {
                    Helper.WriteConsole(ConsoleColor.Green, $"Group Id : {group1.Id}, Group name : {group1.Name}, Group's teacher name: {group1.Teacher}, Group's room name : {group1.Room} ");
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Select correct id type : ");
                    goto GroupId;
                }

            }
        }

        public void GetAll()
        {
            List<Group> group2 = groupService.GetAll();
            foreach (var item in group2)
            {
                Helper.WriteConsole(ConsoleColor.Green, $"Group Id : {item.Id}, Group name : {item.Name}, Group's teacher name: {item.Teacher}, Group's room name : {item.Room} ");
            }
        }

        public void Search()
        {
            Helper.WriteConsole(ConsoleColor.Blue, "Add group's search text: ");
        SearchText: string search = Console.ReadLine();

            List<Group> group3 = groupService.Search(search);
            if (group3.Count != 0)
            {
                foreach (var item in group3)
                {
                    Helper.WriteConsole(ConsoleColor.Green, $"Group Id : {item.Id}, Group name : {item.Name}, Group's teacher name: {item.Teacher}, Group's room name : {item.Room} ");
                }
            }
            else
            {
                Helper.WriteConsole(ConsoleColor.Red, "group not found : ");
                goto SearchText;
            }

        }

        public void Delete()
        {
            Helper.WriteConsole(ConsoleColor.Blue, "Add group's id: ");
        GroupId: string groupId = Console.ReadLine();
            int id;
            bool isGroupId = int.TryParse(groupId, out id);

            if (isGroupId)
            {
                groupService.Delete(id);
            }
            else
            {
                Helper.WriteConsole(ConsoleColor.Red, "Select correct id type : ");
                goto GroupId;
            }
        }

        public void Update()
        {
            Helper.WriteConsole(ConsoleColor.Blue, "Add group's id : ");

            GroupsId: string updateGroupId = Console.ReadLine();

            int groupsId;

            bool isGroupsId = int.TryParse(updateGroupId, out groupsId);

            if (isGroupsId)
            {
                Helper.WriteConsole(ConsoleColor.Blue, "Add group's new name : ");

                string groupNewName = Console.ReadLine();

                Helper.WriteConsole(ConsoleColor.Blue, "Add group's new teacher name : ");

                NewTeacher: string groupNewTeacher = Console.ReadLine();

                foreach (var item in groupNewTeacher)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (item.ToString() == i.ToString())
                        {
                            Helper.WriteConsole(ConsoleColor.Red, "not found : ");
                            goto NewTeacher;
                        }
                    }
                }

                Helper.WriteConsole(ConsoleColor.Blue, "Add group's new room : ");

                string groupNewRoom = Console.ReadLine();

                Group group = new Group()
                {
                    Name = groupNewName,
                    Teacher = groupNewTeacher,
                    Room = groupNewRoom
                };

                var groups = groupService.Update(groupsId, group);

                if(groups == null)
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Group not found,please try again : ");
                    goto GroupsId;

                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Green, $"Group Id : {groups.Id}, Group name : {groups.Name}, Group's teacher name: {groups.Teacher}, Group's room name : {group.Room} ");
                }


            }
            else
            {
                Helper.WriteConsole(ConsoleColor.Red, "Add correct group id : ");
                goto GroupsId;
            }
        }
    }
}
