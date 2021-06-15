using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryTest
{
    [TestClass]
    public class DataAccessDataBreachesTest
    {
        private DataAccessDataBreaches testRepo;
        private DataAccessAccount daAccounts;
        private DataAccessCreditCard daCreditCards;

        [TestInitialize]
        public void SetUp()
        {
            daAccounts = new DataAccessAccount();
            daAccounts.Clear();

            daCreditCards = new DataAccessCreditCard();
            daCreditCards.Clear();

            IDataAccess<Category> daCategories = new DataAccessCategory();
            daCategories.Clear();

            testRepo = new DataAccessDataBreaches();
            testRepo.Clear();

            

            Category trabajo = new Category("Trabajo");
            Category personal = new Category("Personal");
            daCategories.Add(trabajo);
            daCategories.Add(personal);

            Account instagram = new Account()
            {
                Username = "JuanPe123",
                Password = "apareceEnDataBreach",
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
                Category = trabajo
            };
            Account instagram2 = new Account()
            {
                Username = "JuanPe1234",
                Password = "apareceEnDataBreach2",
                Note = "",
                Site = "Instagram2",
                Modification = DateTime.Now,
                Category = personal
            };

            daAccounts.Add(instagram);
            daAccounts.Add(linkedIn);
            daAccounts.Add(instagram2);

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

            CreditCard itau2 = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 1234 1234 1234",
                Code = "827",
                ExpirationMonth = 3,
                ExpirationYear = 2023,
                Notes = "Sin limite",
                Category = personal
            };
            daCreditCards.Add(itau);
            daCreditCards.Add(santander);
            daCreditCards.Add(itau2);
        }

        [TestMethod]
        public void AddDataBreachWithNOExposedDataTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            string data = "";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAllWithoutInclude());
            testRepo.Add(db);
            Assert.AreEqual(0, testRepo.Get(db).ExposedPasswords.Count());

        }

        [TestMethod]
        public void AddDataBreachWithAttachedPasswordTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
apareceEnDataBreach
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAllWithoutInclude());
            testRepo.Add(db);
            Assert.AreEqual(1, testRepo.Get(db).ExposedPasswords.Count());

        }

        [TestMethod]
        public void AddDataBreachWithTwoAttachedPasswordsSameCategoryTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
apareceEnDataBreach
apareceEnDataBreach2
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAllWithoutInclude());
            testRepo.Add(db);
            Assert.AreEqual(2, testRepo.Get(db).ExposedPasswords.Count());

        }

        [TestMethod]
        public void AddDataBreachWithTwoAttachedPasswordsTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
apareceEnDataBreach
Ekjdy2345
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAllWithoutInclude());
            testRepo.Add(db);
            Assert.AreEqual(2, testRepo.Get(db).ExposedPasswords.Count());

        }

        [TestMethod]
        public void AddDataBreachWithAttachedCreditCardTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
1234 5678 2345 5342
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAllWithoutInclude());
            testRepo.Add(db);
            Assert.AreEqual(1, testRepo.Get(db).ExposedCreditCards.Count());

        }

        [TestMethod]
        public void AddDataBreachWithAttachedPasswordAndCreditCardTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
1234 5678 2345 5342
apareceEnDataBreach
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAllWithoutInclude());
            testRepo.Add(db);
            Assert.AreEqual(2, testRepo.Get(db).ExposedPasswords.Count() + testRepo.Get(db).ExposedCreditCards.Count());
        }

        [TestMethod]
        public void AddDataBreachWithAttachedPasswordAndCreditCardDifferentCategoryTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
4324 5342 5543 2345
apareceEnDataBreach
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAllWithoutInclude());
            testRepo.Add(db);
            Assert.AreEqual(2, testRepo.Get(db).ExposedPasswords.Count() + testRepo.Get(db).ExposedCreditCards.Count());

        }

        [TestMethod]
        public void AddDataBreachWithTwoAttachedCreditCardsSameCategoryTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
1234 5678 2345 5342
1234 1234 1234 1234
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAllWithoutInclude());
            testRepo.Add(db);
            Assert.AreEqual(2, testRepo.Get(db).ExposedCreditCards.Count());

        }

        [TestMethod]
        public void AddDataBreachWithTwoAttachedCreditCardsTest()
        {
            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
1234 5678 2345 5342
4324 5342 5543 2345
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAllWithoutInclude());
            testRepo.Add(db);
            Assert.AreEqual(2, testRepo.Get(db).ExposedCreditCards.Count());

        }

        [TestMethod]
        public void CheckCountTest()
        {

            DataBreachCheck db = new DataBreachCheck();
            testRepo.Add(db);

            Assert.AreEqual(1, testRepo.GetAll().Count());
        }

        [TestMethod]
        public void DeleteDataBreachTest()
        {

            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
apareceEnDataBreach
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAllWithoutInclude());
            testRepo.Add(db);

            testRepo.Delete(testRepo.GetAll().First());

            Assert.AreEqual(0, testRepo.GetAll().Count());
        }

        [TestMethod]
        public void ModifyDataBreachDateTest()
        {

            DataBreachCheck db = new DataBreachCheck();
            string data = @"thisPasswordIsBrandNew123
apareceEnDataBreach
password1298";
            IDataBreachesAdapter plainText = new PlainTextAdapter(data);
            db.CheckDataBreaches(plainText, (List<Account>)daAccounts.GetAll(), (List<CreditCard>)daCreditCards.GetAllWithoutInclude());
            testRepo.Add(db);

            DateTime newDate = DateTime.Now;
            db.Date = newDate;

            testRepo.Modify(db);

            Assert.AreEqual(testRepo.Get(db).Date.ToString(), newDate.ToString());
        }
    }
}
