using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using passwordManager;

namespace RepositoryTest
{
    [TestClass]
    public class DataAccessUserTest
    {
        public DataAccessUser testRepo;

        [TestInitialize]
        public void SetUp()
        {
            testRepo = new DataAccessUser();
            testRepo.Clear();
        }

        [TestMethod]
        public void AddMasterKeyTest()
        {
            User u = new User()
            {
                MasterKey = "soyUnaMasterKey",
            };

            testRepo.Add(u);

            Assert.AreEqual(testRepo.Get(u).MasterKey,"soyUnaMasterKey");
        }

        [TestMethod]
        public void CheckCountTest()
        {
            User u = new User()
            {
                MasterKey = "soyUnaMasterKey",
            };

            testRepo.Add(u);

            Assert.AreEqual(1, testRepo.GetAll().Count());
        }

        [TestMethod]
        public void DeleteMasterKeyTest()
        {
            User u = new User()
            {
                MasterKey = "soyUnaMasterKey",
            };

            testRepo.Add(u);
            testRepo.Delete(testRepo.GetAll().First());

            Assert.AreEqual(0, testRepo.GetAll().Count());
        }

        [TestMethod]
        public void ModifyMasterKeyTest()
        {
            User u = new User()
            {
                MasterKey = "soyUnaMasterKey",
            };

         
            testRepo.Add(u);

            u.MasterKey = "nuevaPassword";

            testRepo.Modify(u);

            Assert.AreEqual("nuevaPassword", testRepo.Get(u).MasterKey);
        }

    }
}
