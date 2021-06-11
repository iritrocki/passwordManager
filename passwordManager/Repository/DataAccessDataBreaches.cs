using passwordManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessDataBreaches : IDataAccess<DataBreachCheck>
    {
        public void Add(DataBreachCheck entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                foreach(CreditCard cc in entity.ExposedCreditCards)
                {
                    context.CreditCards.Attach(cc);
                }
                foreach (Account a in entity.ExposedPasswords)
                {
                    context.Accounts.Attach(a);
                }
                context.DataBreaches.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(DataBreachCheck entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                DataBreachCheck dataBreachToDelete = context.DataBreaches.FirstOrDefault(d => d.Id == entity.Id);
                context.DataBreaches.Remove(dataBreachToDelete);
                context.SaveChanges();
            }
        }

        public DataBreachCheck Get(DataBreachCheck entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.DataBreaches.Include(d=>d.ExposedCreditCards).Include(d=>d.ExposedPasswords).Include(d => d.ExposedPasswords.Select(p=>p.Category)).FirstOrDefault(a => a.Id == entity.Id);
            }
        }

        public IEnumerable<DataBreachCheck> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.DataBreaches.Include(d => d.ExposedCreditCards).Include(d => d.ExposedPasswords).Include(d => d.ExposedPasswords.Select(p => p.Category)).Include(d=>d.DataBreaches).ToList();

            }
        }

        public void Modify(DataBreachCheck entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                DataBreachCheck dataBreachToModify = context.DataBreaches.FirstOrDefault(d => d.Id == entity.Id);

                dataBreachToModify.ExposedPasswords = entity.ExposedPasswords;
                dataBreachToModify.ExposedCreditCards = entity.ExposedCreditCards;
                dataBreachToModify.DataBreaches = entity.DataBreaches;
                dataBreachToModify.TypeOfConversion = entity.TypeOfConversion;
                dataBreachToModify.Date = entity.Date;

                context.SaveChanges();


            }
        }
    }
}
