using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager;
using Repository;
using System;

namespace RepositoryTest
{
    [TestClass]
    public class DataAccesAccountTest
    {
        private DataAccessAccount testRepo;

        [TestInitialize]
        public void SetUp()
        {
            testRepo = new DataAccessAccount();
            testRepo.Clear();
        }

        //[TestMethod]
        //public void AddAccountTest()
        //{
        //    Category c = new Category("Facultad");
        //    Account instagram = new Account()
        //    {
        //        Username = "JuanPe123",
        //        Password = "vsjkdjfjsdhjf",
        //        Note = "",
        //        Site = "Instagram",
        //        Modification = DateTime.Now,
        //        Category = c
        //    };
        //    testRepo.Add(instagram);
        //    Assert.AreEqual(testRepo.Get(instagram),instagram);
        
        //}
    }
}
