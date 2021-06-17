using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryTest
{
    [TestClass]
    public class DataAccessCreditCardTest
    {
        private DataAccessCreditCard testRepo;
        private DataAccessCategory daCategory;

        [TestInitialize]
        public void SetUp()
        {
            IDataAccess<Account> daAccounts = new DataAccessAccount();
            daAccounts.Clear();

            daCategory = new DataAccessCategory();
            testRepo = new DataAccessCreditCard();
            testRepo.Clear();
            
            daCategory.Clear();



        }

        [TestMethod]
        public void AddCreditCardTest()
        {
            Category c = new Category("Facultad");
            daCategory.Add(c);
            CreditCard itau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "123",
                ExpirationMonth = 3,
                ExpirationYear = 2024,
                Notes = "Sin limite",
                Category = c,
            };
            testRepo.Add(itau);
            Assert.AreEqual(testRepo.Get(itau).Number, "1234 5678 2345 5342");

        }



        [TestMethod]
        public void CheckCountTest()
        {
            Category c = new Category("Facultad");
            daCategory.Add(c);
            CreditCard itau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "123",
                ExpirationMonth = 3,
                ExpirationYear = 2024,
                Notes = "Sin limite",
                Category = c,
            };
            testRepo.Add(itau);

            Assert.AreEqual(1, testRepo.GetAll().Count());
        }

        [TestMethod]
        public void DeleteCreditCardTest()
        {
            Category c = new Category("Facultad");
            daCategory.Add(c);
            CreditCard itau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "123",
                ExpirationMonth = 3,
                ExpirationYear = 2024,
                Notes = "Sin limite",
                Category = c,
            };
            testRepo.Add(itau);

            testRepo.Delete(testRepo.GetAll().First());

            Assert.AreEqual(0, testRepo.GetAll().Count());
        }

        [TestMethod]
        public void ModifyCreditCardNameTest()
        {
            Category c = new Category("Facultad");
            daCategory.Add(c);
            CreditCard itau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "123",
                ExpirationMonth = 3,
                ExpirationYear = 2024,
                Notes = "Sin limite",
                Category = c,
            };

            testRepo.Add(itau);

            itau.Name = "Itau gold";

            testRepo.Modify(itau);

            Assert.AreEqual("Itau gold", testRepo.Get(itau).Name);
        }
    }
}
