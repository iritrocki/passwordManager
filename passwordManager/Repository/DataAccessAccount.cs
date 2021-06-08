using passwordManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessAccount : IDataAccess<Account>
    {
        public void Add(Account entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Categories.Attach(entity.Category);
                context.Accounts.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Account entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Account accountToDelete = context.Accounts.FirstOrDefault(a => a.Id == entity.Id);
                context.Accounts.Remove(accountToDelete);
                context.SaveChanges();
            }
        }

        public Account Get(Account entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Accounts.Include("Category").FirstOrDefault(a => a.Id == entity.Id);
            }
        }

        public IEnumerable<Account> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Accounts.Include("Category").ToList();
            }
        }

        public void Modify(Account entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Account accountToModify = context.Accounts.FirstOrDefault(a => a.Id == entity.Id);

                accountToModify.Category = entity.Category;
                accountToModify.Classification = entity.Classification;
                accountToModify.Modification = entity.Modification;
                accountToModify.Note = entity.Note;
                accountToModify.Password = entity.Password;
                accountToModify.Site = entity.Site;
                accountToModify.Username = entity.Username;

                context.SaveChanges();


            }

        }
    }
}
