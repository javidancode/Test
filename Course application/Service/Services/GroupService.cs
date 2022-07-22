using Domain.Models;
using Repository.Repositories;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class GroupService : IGroupService
    {
        private GroupRepository _groupRepository;
        private int _count;

        public GroupService()
        {
            _groupRepository = new GroupRepository();
        }

        public Group Create(Group group)
        {
            group.Id = _count;
            _groupRepository.Create(group);
            _count++;
            return group;
        }

        public void Delete(int id)
        {
            Group group = GetById(id);
            _groupRepository.Delete(group);
        }

        public List<Group> GetAll()
        {
            return _groupRepository.GetAll();
        }

        public Group GetById(int id)
        {
            var group = _groupRepository.Get(m => m.Id == id);
            if (group is null) return null;
            return group;
        }

        public List<Group> Search(string search)
        {
            return _groupRepository.GetAll(m => m.Name.StartsWith(search.ToLower().Trim()));

            return _groupRepository.GetAll(m => m.Teacher.StartsWith(search.ToLower().Trim()));

            return _groupRepository.GetAll(m=> m.Room.StartsWith(search.ToLower().Trim()));
        }

        public Group Update(int id, Group group)
        {
            Group dbgroup = GetById(id);
            if (dbgroup is null) return null;
            group.Id = group.Id;
            _groupRepository.Update(group);
            return dbgroup;

            
        }
    }
}
