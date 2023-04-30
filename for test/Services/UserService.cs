using for_test.DTOs;
using for_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace for_test.Services
{
    public class UserService
    {
        private SQLDbContext dbContext;

        public UserService(SQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<UserDTO> GetAll()
        {
            return dbContext.Users.Select(u => ToDTO(u)).ToList();
        }

        public User GetById(int id)
        {
            return dbContext.Users.FirstOrDefault(p => p.Id == id);
        }

        public void Create(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public void Edit(User user)
        {
            User dbUser = GetById(user.Id);

            dbUser.Username = user.Username;
            dbUser.Password = user.Password;

            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            User dbUser = GetById(id);

            dbContext.Users.Remove(dbUser);
            dbContext.SaveChanges();
        }
        private static UserDTO ToDTO(User user)
        {
            return new UserDTO(user.Id, user.Username, user.Password);
        }
    }
}
