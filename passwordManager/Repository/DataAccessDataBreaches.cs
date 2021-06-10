using passwordManager;
using System;
using System.Collections.Generic;
using System.Linq;
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
                return context.DataBreaches.Include("ExposedCreditCards").Include("ExposedPasswords").FirstOrDefault(a => a.Id == entity.Id);
            }
        }

        public IEnumerable<DataBreachCheck> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.DataBreaches.Include("ExposedCreditCards").Include("ExposedPasswords").ToList();

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
