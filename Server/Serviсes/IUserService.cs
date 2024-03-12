using System;
using BlazorProject.Shared.DataAnnotations;

namespace BlazorProject.Server.Serviсes.IServices
{
	public interface IUserService
	{
        public List<User> GetUsers();

        bool Insert(User user);

        User Edit(int UserID);

        bool Update(User user);

        bool Delete(User user);
    }
}

