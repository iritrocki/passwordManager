using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryTest
{
    [TestClass]
    public class DataAccessAccountTest
    {
        private DataAccessAccount testRepo;
        private DataAccessCategory daCategory;

        [TestInitialize]
        public void SetUp()
        {
            daCategory = new DataAccessCategory();
            testRepo = new DataAccessAccount();
            testRepo.Clear();
            daCategory.Clear();

            
            
        }

        [TestMethod]
        public void AddAccountTest()
        {
            Category c = new Category("Facultad");
            daCategory.Add(c);
            Account instagram = new Account()
            {
                Username = "JuanPe123",
                Password = "vsjkdjfjsdhjf",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                Category = c
            };
            testRepo.Add(instagram);
            Assert.AreEqual(testRepo.Get(instagram).Username, instagram.Username);

        }

        

        [TestMethod]
        public void CheckCountTest()
        {
            Category c = new Category("Facultad");
            daCategory.Add(c);
            Account instagram = new Account()
            {
                Username = "JuanPe123",
                Password = "vsjkdjfjsdhjf",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                Category = c
            };
            testRepo.Add(instagram);

            Assert.AreEqual(1, testRepo.GetAll().Count());
        }

        [TestMethod]
        public void DeleteAccountTest()
        {
            Category c = new Category("Facultad");
            daCategory.Add(c);
            Account instagram = new Account()
            {
                Username = "JuanPe123",
                Password = "vsjkdjfjsdhjf",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                Category = c
            };
            testRepo.Add(instagram);

            testRepo.Delete(testRepo.GetAll().First());

            Assert.AreEqual(0, testRepo.GetAll().Count());
        }

        [TestMethod]
        public void ModifyUsernameTest()
        {
            Category c = new Category("Facultad");
            daCategory.Add(c);
            Account instagram = new Account()
            {
                Username = "JuanPe123",
                Password = "vsjkdjfjsdhjf",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                Category = c
            };

            testRepo.Add(instagram);

            instagram.Username = "nuevoUsuario";

            testRepo.Modify(instagram);

            Assert.AreEqual("nuevoUsuario", testRepo.Get(instagram).Username);
        }
    }
}
