using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using passwordManager;
using passwordManager.Exceptions;

namespace passwordManagerTest
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void CreateNewAccountTest()
        {
            Account a = new Account();
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void AssignUsernameTest()
        {
            Account a = new Account();
            a.Username = "juanpe123";
            Assert.AreEqual("juanpe123", a.Username);
        }


        [ExpectedException(typeof(InvalidAccountUsernameException))]
        [TestMethod]
        public void InvalidUsernameTest()
        {
            Account a = new Account();
            a.Username = "jprs";
        }

        [TestMethod]
        public void AssignPasswordTest()
        {
            Account a = new Account();
            a.Password = "12345";
            Assert.AreEqual("12345", a.Password);
        }


        [ExpectedException(typeof(InvalidAccountPasswordException))]
        [TestMethod]
        public void InvalidPasswordTest()
        {
            Account a = new Account();
            a.Password = "1";
        }

        [TestMethod]
        public void AssignSiteTest()
        {
            Account a = new Account();
            a.Site = "Instagram";
            Assert.AreEqual("Instagram", a.Site);
        }

        [ExpectedException(typeof(InvalidAccountSiteException))]
        [TestMethod]
        public void TooLongSiteTest()
        {
            Account a = new Account();
            a.Site = "www.maniakdenim.com/maniakbrava";
        }

        [TestMethod]
        public void AssignNoteTest()
        {
            Account a = new Account();
            a.Note = "Cuenta personal";
            Assert.AreEqual("Cuenta personal", a.Note);
        }

        

        [ExpectedException(typeof(InvalidAccountNotesException))]
        [TestMethod]
        public void TooLongNotesTest()
        {
            Account a = new Account();
            a.Note = "Este string contiene mas de 250 caracteres --> asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb;ashkbcwehjld;cwe ckfshbv;d;fkdfvw;kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv;iafbv;ae ivhbae;fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb";
        }

        [TestMethod]
        public void AssignModificationDateTest()
        {
            Account a = new Account();
            DateTime d= DateTime.Now;
            a.Modification = d;
            Assert.AreEqual(d, a.Modification);
        }

        [TestMethod]
        public void CreateAccountAsDataUnitTest()
        {
            DataUnit a = new Account();
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void CreateAccountWithCategoryTest()
        {
            Category cat = new Category("Trabajo");
            DataUnit a = new Account();
            a.Category = cat;
            Assert.AreEqual(cat, a.Category);
        }
        

       
        

        [TestMethod]
        public void ModifyAccountTest()
        {
            Category c = new Category("facultad");
            Account a = new Account()
            {
                Username = "JuanPe123",
                Password = "kfjbvskSKS??",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now
            };

            Account newAccount = new Account()
            {
                Username = "JuanPe1",
                Password = "holaEstaEsunacontra",
                Note = "",
                Site = "Instagram",
            };
            a.ModifyAccount(newAccount);
            Assert.AreEqual("JuanPe1", a.Username);
        }

        [TestMethod]
        public void ModifyAccountVersion2Test()
        {
            Category c = new Category("facultad");
            Account a = new Account()
            {
                Username = "JuanPe123",
                Password = "kfjbvskSKS??",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now
            };

            Account newAccount = new Account()
            {
                Username = "JuanPe1",
                Password = "1234njkfd",
                Note = "",
                Site = "Instagram",
            };
            a.ModifyAccount(newAccount);
            Assert.AreNotEqual("kfjbvskSKS??", a.Password);
        }

        [ExpectedException(typeof(InvalidAccountPasswordException))]
        [TestMethod]
        public void ModifyAccountVersion3Test()
        {
            Category c = new Category("facultad");
            Account a = new Account()
            {
                Username = "JuanPe123",
                Password = "kfjbvskSKS??",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now
            };

            Account newAccount = new Account()
            {
                Username = "JuanPe1",
                Password = "123",
                Note = "",
                Site = "Instagram",
            };
            a.ModifyAccount(newAccount);
            Assert.AreNotEqual("kfjbvskSKS??", a.Password);
        }

        [TestMethod]
        public void EqualAccountsTest() 
        {
            Account a1 = new Account()
            {
                Username = "JuanPe1",
                Password = "1233278462",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now
            };
            Account a2 = new Account()
            {
                Username = "JuanPe1",
                Password = "djhfkjsrhkjr",
                Note = "New Account",
                Site = "Instagram",
                Modification = DateTime.Now
            };
            Assert.IsTrue(a1.Equals(a2));

        }

        [TestMethod]
        public void ToStringTest()
        {
            Category c = new Category("Facultad");
            Account a2 = new Account()
            {
                Username = "JuanPe1",
                Password = "djhfkjsrhkjr",
                Note = "New Account",
                Site = "Instagram",
                Modification = DateTime.Now,
                Category = c
            };
            Assert.AreEqual("[Facultad] [Instagram] [JuanPe1]", a2.ToString());
        }
    }
}
