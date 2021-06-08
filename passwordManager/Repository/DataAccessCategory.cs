using passwordManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessCategory : IDataAccess<Category>
    {
        public void Add(Category entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Categories.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category categoryToDelete = context.Categories.FirstOrDefault(c => c.Id == entity.Id);
                context.Categories.Remove(categoryToDelete);
                context.SaveChanges();
            }
        }

        public Category Get(Category entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Categories.FirstOrDefault(c => c.Id == entity.Id);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Categories.ToList();
            }
        }

        public void Modify(Category entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category categoryToModify = context.Categories.FirstOrDefault(c => c.Id == entity.Id);
                categoryToModify.Name = entity.Name;

                

                context.SaveChanges();
            }
        }

    }
}
