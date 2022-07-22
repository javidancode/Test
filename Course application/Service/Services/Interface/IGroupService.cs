using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interface
{
    public interface IGroupService
    {
        Group Create(Group group);
        Group Update(int id, Group group);
        void Delete(int id);
        Group GetById(int id);
        List<Group> GetAll();
        List<Group> Search(string search);
    }
}
