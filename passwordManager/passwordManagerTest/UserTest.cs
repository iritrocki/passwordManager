using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager;
using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManagerTest
{
    [TestClass]
    public class UserTest
    {

        [TestMethod]
        public void CreateUserTest()
        {
            User u = new User();
            Assert.IsNotNull(u);
        }

        [TestMethod]
        public void InitializedStatusTest()
        {
            User u = new User();
            Assert.IsFalse(u.Status);
        }

        [TestMethod]
        public void AssignMasterKeyTest()
        {
            User u = new User();
            u.MasterKey = "soyUnaMasterKey123";
            Assert.AreEqual("soyUnaMasterKey123", u.MasterKey);
        }



        //[TestMethod]
        //public void AssignCategoriesTest()
        //{
        //    User u = new User();
        //    u.Categories = new List<Category>();
        //    Assert.IsNotNull(u.Categories);
        //}

        //[TestMethod]
        //public void InicializedCategoriesTest()
        //{
        //    User u = new User();
        //    Assert.IsNotNull(u.Categories);
        //}

      
        

       


        //[TestMethod]
        //public void CheckCategoryNameTest()
        //{
        //    User u = new User();
        //    Category c = new Category("Facultad");
        //    u.Categories.Add(c);
        //    Assert.AreEqual("Facultad", u.Categories[0].Name);
        //}

        //[TestMethod]
        //public void AssignAccountsTest()
        //{
        //    User u = new User();
        //    u.Accounts = new List<Account>();
        //    Assert.IsNotNull(u.Accounts);
        //}

        //[TestMethod]
        //public void InicializedAccountsTest()
        //{
        //    User u = new User();
        //    Assert.IsNotNull(u.Accounts);
        //}

        //[TestMethod]
        //public void TryAddAccountTest()
        //{
        //    User u = new User();
        //    Category c = new Category("Facultad");
        //    Account a = new Account()
        //    {
        //        Username = "JuanPe123",
        //        Password = "kfjbvskSKS??",
        //        Note = "",
        //        Site = "Instagram",
        //        Modification = DateTime.Now,
        //        Category = c
        //    };
        //    u.UniqueAccountCheck(a);
        //    Assert.AreEqual(1, u.Accounts.Count);
        //}

        

       



    
        //[TestMethod]
        //public void AssignCreditCardTest()
        //{
        //    User u = new User();
        //    u.CreditCards = new List<CreditCard>();
        //    Assert.IsNotNull(u.CreditCards);
        //}

        //[TestMethod]
        //public void InicializedCreditCardsTest()
        //{
        //    User u = new User();
        //    Assert.IsNotNull(u.CreditCards);
        //}

        //[TestMethod]
        //public void TryAddCreditCardTest()
        //{
        //    User u = new User();
        //    Category c = new Category("Facultad");
        //    CreditCard cc = new CreditCard()
        //    {
        //        Name = "Visa Gold",
        //        Company = "Visa",
        //        Number = "1234 5678 2345 5342",
        //        Code = "854",
        //        ExpirationMonth = 3,
        //        ExpirationYear = 2022,
        //        Notes = "Tarjeta sin limite",
        //        Category = c
        //    };
        //    u.UniqueCreditCardCheck(cc);
        //    Assert.AreEqual(1, u.CreditCards.Count);
        //}

        //[TestMethod]
        //public void CodeComparisonCreditCardTest()
        //{
        //    User u = new User();
        //    Category c = new Category("Facultad");
        //    CreditCard cc = new CreditCard()
        //    {
        //        Name = "Visa Gold",
        //        Company = "Visa",
        //        Number = "1234 5678 2345 5342",
        //        Code = "854",
        //        ExpirationMonth = 3,
        //        ExpirationYear = 2022,
        //        Notes = "Tarjeta sin limite",
        //        Category = c
        //    };
        //    u.CreditCards.Add(cc);
        //    Assert.AreEqual("854", u.CreditCards[0].Code);
        //}

        //[TestMethod]
        //public void FacultadAsCategoryForCreditCardTest()
        //{
        //    User u = new User();
        //    Category c = new Category("Facultad");
        //    u.Categories.Add(c);
        //    CreditCard cc = new CreditCard()
        //    {
        //        Name = "Visa Gold",
        //        Company = "Visa",
        //        Number = "1234 5678 2345 5342",
        //        Code = "854",
        //        ExpirationMonth = 3,
        //        ExpirationYear = 2022,
        //        Notes = "Tarjeta sin limite",
        //        Category = u.Categories[0]
        //    };
        //    u.CreditCards.Add(cc);
        //    Assert.AreEqual(c, u.CreditCards[0].Category);
        //}

        //[TestMethod]
        //public void TryRemoveCreditCardTest()
        //{
        //    User u = new User();
        //    Category c = new Category("Facultad");
        //    CreditCard cc = new CreditCard()
        //    {
        //        Name = "Visa Gold",
        //        Company = "Visa",
        //        Number = "1234 5678 2345 5342",
        //        Code = "854",
        //        ExpirationMonth = 3,
        //        ExpirationYear = 2022,
        //        Notes = "Tarjeta sin limite",
        //        Category = c
        //    };
        //    u.UniqueCreditCardCheck(cc);
        //    u.TryRemoveCreditCard(cc);
        //    Assert.AreEqual(0, u.CreditCards.Count);
        //}

        //[ExpectedException(typeof(InexistentCreditCardException))]
        //[TestMethod]
        //public void TryRemoveInexistentCreditCardTest()
        //{
        //    User u = new User();
        //    Category c = new Category("Facultad");
        //    CreditCard cc = new CreditCard()
        //    {
        //        Name = "Visa Gold",
        //        Company = "Visa",
        //        Number = "1234 5678 2345 5342",
        //        Code = "854",
        //        ExpirationMonth = 3,
        //        ExpirationYear = 2022,
        //        Notes = "Tarjeta sin limite",
        //        Category = c
        //    };
        //    u.TryRemoveCreditCard(cc);
        //}




        [TestMethod]
        public void TryCreateValidMasterKeyTest()
        {
            User u = new User();
            u.MasterKey = "holaSoyUnaMasterKey";
            Assert.IsTrue(Validator.ValidateStringLength(u.MasterKey,(5,25)));
        }

        [ExpectedException(typeof(InvalidMasterKeyException))]
        [TestMethod]
        public void TryCreateInvalidMasterKeyTest()
        {
            User u = new User();
            u.MasterKey = "hola";
        }

        [TestMethod]
        public void SignInTest()
        {
            User u = new User();
            u.MasterKey = "soyUnaMasterKey123";
            u.SignIn("soyUnaMasterKey123");
            Assert.IsTrue(u.Status);
        }

        [ExpectedException(typeof(InvalidMasterKeyException))]
        [TestMethod]
        public void WrongMasterKeyTest()
        {
            User u = new User();
            u.MasterKey = "soyUnaMasterKey123";
            u.SignIn("soyUnaMasterKey");
        }

        [TestMethod]
        public void SignOutTest()
        {
            User u = new User();
            u.MasterKey = "soyUnaMasterKey123";
            u.SignIn("soyUnaMasterKey123");
            u.SignOut();
            Assert.IsFalse(u.Status);
        }

        [TestMethod]
        public void SuccessfullyChangeMasterKeyTest()
        {
            User u = new User();
            u.MasterKey = "soyUnaMasterKey123";
            u.ChangeMasterKey("soyUnaMasterKey123", "holaSoyUnaNuevaContra");
            Assert.AreEqual("holaSoyUnaNuevaContra", u.MasterKey);
        }

        [ExpectedException(typeof(InvalidMasterKeyException))]
        [TestMethod]
        public void UnsuccessfullyChangeMasterKeyTest()
        {
            User u = new User();
            u.MasterKey = "soyUnaMasterKey123";
            u.ChangeMasterKey("soyUnaMasterKey", "holaSoyUnaNuevaContra");
        }

        


    }


}
