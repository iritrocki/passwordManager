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
                
                foreach (CreditCard cc in entity.ExposedCreditCards)
                {
                    context.CreditCards.Attach(cc);
                }
                foreach (Account a in entity.ExposedPasswords)
                {
                    context.Categories.Attach(a.Category);
                    context.Accounts.Attach(a);
                    
                }
                
                context.DataBreaches.Add(entity);
                context.SaveChanges();
            }
        }

        public void Clear()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.DataBreachLines.RemoveRange(context.DataBreachLines);
                context.DataBreaches.RemoveRange(context.DataBreaches);
                context.SaveChanges();
            }
        }

        public void Delete(DataBreachCheck entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                DataBreachCheck dataBreachToDelete = context.DataBreaches.Include(d => d.DataBreaches).FirstOrDefault(d => d.Id == entity.Id);
                context.DataBreachLines.RemoveRange(dataBreachToDelete.DataBreaches);
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
                foreach(DataBreachLine line in entity.DataBreaches)
                {
                    DataBreachLine dataBreachLineToModify = context.DataBreachLines.FirstOrDefault(d => d.Id == line.Id);
                    dataBreachLineToModify.Line = line.Line;
                }
                dataBreachToModify.TypeOfConversion = entity.TypeOfConversion;
                dataBreachToModify.Date = entity.Date;

                context.SaveChanges();


            }
        }
    }
}
