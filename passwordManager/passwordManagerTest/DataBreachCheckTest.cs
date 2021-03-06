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
    public class DataBreachCheckTest
    {
        User u;
        List <Account> accounts;
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
                Password = "ThisIsMyPassword123",
                Note = "Github para el laburo",
                Site = "github.com",
                Modification = DateTime.Now,
                Category = trabajo
            };

            Account github2 = new Account()
            {
                Username = "Juanchoperez",
                Password = "sjdkjsbsnd3278?",
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

            u = new User();
            accounts = new List<Account>();
            accounts.Add(instagram);
            accounts.Add(linkedIn);
            accounts.Add(github);
            accounts.Add(github2);
            creditCards = new List<CreditCard>();
            creditCards.Add(itau);
            creditCards.Add(santander);
            creditCards.Add(americanExpress);

        }

        [TestMethod]
        public void CreateNewDataBreachCheckTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            Assert.IsNotNull(db);
        }

        [TestMethod]
        public void CheckInitiatedPasswordListTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            Assert.IsNotNull(db.ExposedPasswords);
        }

        [TestMethod]
        public void CheckEmptyPasswordListTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            Assert.IsTrue(db.ExposedPasswords.Count == 0);
        }

        [TestMethod]
        public void AddExposedPasswordToListTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            db.ExposedPasswords.Add(accounts[0]);
            Assert.IsTrue(db.ExposedPasswords.Count == 1);
        }


        [TestMethod]
        public void CheckInitiatedCreditCardListTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            Assert.IsNotNull(db.ExposedCreditCards);
        }

        [TestMethod]
        public void CheckEmptyCreditCardListTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            Assert.IsTrue(db.ExposedCreditCards.Count == 0);
        }

        [TestMethod]
        public void AssignInterfaceForDataConversionTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            IDataBreachesAdapter plainText = new PlainTextAdapter();
            db.TypeOfConversion = plainText;
            Assert.AreEqual(plainText, db.TypeOfConversion);
        }

        [TestMethod]
        public void AddExposedCreditCardToListTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            db.ExposedCreditCards.Add(creditCards[0]);
            Assert.IsTrue(db.ExposedCreditCards.Count == 1);
        }

        [TestMethod]
        public void CheckEmptyStringListTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            List<DataBreachLine> data = new List<DataBreachLine>();
            db.DataBreaches = data;
            db.CheckDataBreachesExposure(accounts, creditCards);
            Assert.IsTrue(db.ExposedPasswords.Count == 0 && db.ExposedCreditCards.Count == 0);
        }

        [TestMethod]
        public void CheckDataBreachExposedGithubAccountTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            List<DataBreachLine> data = new List<DataBreachLine>();
            DataBreachLine d = new DataBreachLine("vsjkdjfjsdhjf");
            data.Add(d);
            db.DataBreaches = data;
            db.CheckDataBreachesExposure(accounts, creditCards);
            Assert.IsTrue(db.ExposedPasswords.Contains(accounts[0]));
        }

        [TestMethod]
        public void CheckDataBreachNoAccountExposedTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            List<DataBreachLine> data = new List<DataBreachLine>();
            DataBreachLine d = new DataBreachLine("thisPasswordIsBrandNew123");
            data.Add(d);
            db.DataBreaches = data;
            db.CheckDataBreachesExposure(accounts, creditCards);
            Assert.IsTrue(db.ExposedPasswords.Count == 0);
        }


        [TestMethod]
        public void CheckDataBreachExposedItauCreditCardTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            List<DataBreachLine> data = new List<DataBreachLine>();
            DataBreachLine d = new DataBreachLine("1234 5678 2345 5342");
            data.Add(d);
            db.DataBreaches = data;
            db.CheckDataBreachesExposure(accounts, creditCards);
            Assert.IsTrue(db.ExposedCreditCards.Contains(creditCards[0]));
        }

        [TestMethod]
        public void CheckDataBreachInvalidNumberNoCreditCardExposedTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            List<DataBreachLine> data = new List<DataBreachLine>();
            DataBreachLine d = new DataBreachLine("thisPasswordIsBrandNew123");
            data.Add(d);
            db.DataBreaches = data;
            db.CheckDataBreachesExposure(accounts, creditCards);
            Assert.IsTrue(db.ExposedCreditCards.Count == 0);
        }

        [TestMethod]
        public void CheckDataBreachesFromPlainTextTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
1234 5678 2345 5342
vsjkdjfjsdhjf
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, accounts, creditCards);
            Assert.IsTrue(db.ExposedPasswords.Count == 1 && db.ExposedCreditCards.Count == 1);
        }

        [TestMethod]
        public void CheckDataBreachesFromPlainTextAddedExposedItemsTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
1234 5678 2345 5342
vsjkdjfjsdhjf
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, accounts, creditCards);
            Assert.IsTrue(db.ExposedCreditCards.Contains(creditCards[0]) && db.ExposedPasswords.Contains(accounts[0]));
        }


    }
}
