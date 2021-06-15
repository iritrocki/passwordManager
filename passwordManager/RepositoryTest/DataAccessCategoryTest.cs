using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryTest
{
    [TestClass]
    public class DataAccesCategoryTest
    {
        private DataAccessCategory testRepo;

        [TestInitialize]
        public void SetUp()
        {
            IDataAccess<Account> daAccounts = new DataAccessAccount();
            daAccounts.Clear();
            IDataAccess<CreditCard> daCreditCards = new DataAccessCreditCard();
            daCreditCards.Clear();
            testRepo = new DataAccessCategory();
            testRepo.Clear();

        }


        [TestMethod]
        public void AddCategoryTest()
        {
            Category c = new Category("Facultad");
            testRepo.Add(c);
            Assert.AreEqual("Facultad", testRepo.Get(c).Name);

        }



        [TestMethod]
        public void CheckCountTest()
        {
            Category c = new Category("Facultad");
            testRepo.Add(c);
            Assert.AreEqual(1, testRepo.GetAll().Count());
        }

        [TestMethod]
        public void DeleteCategoryTest()
        {
            Category c = new Category("Facultad");
            testRepo.Add(c);

            testRepo.Delete(testRepo.GetAll().First());

            Assert.AreEqual(0, testRepo.GetAll().Count());
        }

        [TestMethod]
        public void ModifyCategoryNameTest()
        {
            Category c = new Category("Facultad");
            testRepo.Add(c);

            c.Name = "nuevoNombre";

            testRepo.Modify(c);

            Assert.AreEqual("nuevoNombre", testRepo.Get(c).Name);
        }
    }
}
