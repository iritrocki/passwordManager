using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManagerTest
{
    [TestClass]

    class ModificatorTest
    {
        List<Category> categories;
        List<Account> accounts;
        List<CreditCard> creditCards;

        [TestInitialize]

        public void TestInitialize()
        {

            Category facultad = new Category("Facultad");
            Category trabajo = new Category("Trabajo");
            Category personal = new Category("Personal");


            Account instagram = new Account()
            {
                Username = "JuanPe123",
                Password = "vsjkdjfjsdhjf",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                Category = personal
            };

            Account linkedIn = new Account()
            {
                Username = "JuanPerez",
                Password = "Ekjdy2345",
                Note = "Soy nuevo en linked in",
                Site = "Linked In",
                Modification = DateTime.Now,
                Category = personal
            };

            Account github = new Account()
            {
                Username = "JuanPerez123",
                Password = "fvjnwqj42kfn",
                Note = "Github para el laburo",
                Site = "github.com",
                Modification = DateTime.Now,
                Category = trabajo
            };

            Account github2 = new Account()
            {
                Username = "Juanchoperez",
                Password = "DSVNsjfj?.>",
                Note = "Github para la facu",
                Site = "github.com",
                Modification = DateTime.Now,
                Category = facultad
            };

            CreditCard itau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "827",
                ExpirationMonth = 3,
                ExpirationYear = 2023,
                Notes = "Sin limite",
                Category = personal
            };

            CreditCard santander = new CreditCard()
            {
                Name = "Santander universidades",
                Company = "Master Card",
                Number = "4324 5342 5543 2345",
                Code = "836",
                ExpirationMonth = 4,
                ExpirationYear = 2022,
                Notes = "Limite 50k dolares",
                Category = trabajo
            };

            CreditCard americanExpress = new CreditCard()
            {
                Name = "American Platinum",
                Company = "American Express",
                Number = "8945 2948 0498 1289",
                Code = "2393",
                ExpirationMonth = 2,
                ExpirationYear = 2025,
                Notes = "Sin limite, para compras en el exterior",
                Category = personal
            };

            //u = new User();
            categories.Add(facultad);
            categories.Add(trabajo);
            categories.Add(personal);
            accounts.Add(github);
            accounts.Add(github2);
            accounts.Add(linkedIn);
            accounts.Add(instagram);
            creditCards.Add(itau);
            creditCards.Add(santander);
            creditCards.Add(americanExpress);

        }
    }
}
