using System;
using BlazorProject.Shared.DataAnnotations;
using BlazorProject.Server.Serviсes.IServices;

namespace BlazorProject.Server.Servises
{
	public class UserServiсes : IUserService
	{
		protected readonly AppDbContext _UserContext;

		public UserServiсes(AppDbContext dbContext)
		{
			_UserContext = dbContext;
		}

		public List<User> GetUsers()
		{
			return _UserContext.User.ToList();
		}

		public bool Insert(User user)
		{
			_UserContext.User.Add(user);
			_UserContext.SaveChanges();
			return true;
		}

		public User Edit(int UserID)
		{
			User user = new User();
			return _UserContext.User.FirstOrDefault(u => u.ID == UserID);
		}

		public bool Update(User user)
		{
			var UserUpdate = _UserContext.User.FirstOrDefault(u => u.ID == user.ID);
			if (UserUpdate != null)
			{
				UserUpdate.Email = user.Email;
				UserUpdate.HashPassword = user.HashPassword;
				UserUpdate.Login = user.Login;
				_UserContext.SaveChanges();

			}
			else
			{
				return false;
			}
			return true;
		}

        public bool Delete(User user)
        {
            var UserDelete = _UserContext.User.FirstOrDefault(u => u.ID == user.ID);
            if (UserDelete != null)
            {
				_UserContext.Remove(UserDelete);
                _UserContext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}

