using passwordManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessCreditCard : IDataAccess<CreditCard>
    {
        public void Add(CreditCard entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.CreditCards.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(CreditCard entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                CreditCard cardToDelete = context.CreditCards.FirstOrDefault(c => c.Id == entity.Id);
                context.CreditCards.Remove(cardToDelete);
                context.SaveChanges();
            }
        }

        public CreditCard Get(CreditCard entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.CreditCards.FirstOrDefault(c => c.Id == entity.Id);
            }
        }

        public IEnumerable<CreditCard> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.CreditCards.ToList();
            }
        }

        public void Modify(CreditCard entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                CreditCard cardToModify = context.CreditCards.FirstOrDefault(c => c.Id == entity.Id);

                cardToModify.Category = entity.Category;
                cardToModify.Code = entity.Code;
                cardToModify.Company = entity.Company;
                cardToModify.ExpirationMonth = entity.ExpirationMonth;
                cardToModify.ExpirationYear = entity.ExpirationYear;
                cardToModify.Name = entity.Name;
                cardToModify.Notes = entity.Notes;
                cardToModify.Number = entity.Number;

                context.SaveChanges();
            }
        }
    }
}
