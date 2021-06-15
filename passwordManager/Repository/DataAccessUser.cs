using passwordManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessUser : IDataAccess<User>
    {
        public void Add(User entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Users.Add(entity);
                context.SaveChanges();
            }
        }

        public void Clear()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Users.RemoveRange(context.Users);
                context.SaveChanges();
            }
        }
        public void Delete(User entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                User userToDelete = context.Users.FirstOrDefault(u => u.Id == entity.Id);
                context.Users.Remove(userToDelete);
                context.SaveChanges();
            }
        }

        public User Get(User entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {

                return context.Users.FirstOrDefault(u => u.Id == entity.Id);
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Users.ToList();
            }
        }

        public void Modify(User entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                User userToModify = context.Users.FirstOrDefault(u => u.Id == entity.Id);

                userToModify.MasterKey = entity.MasterKey;

                context.SaveChanges();
            }
        }
    }
}
