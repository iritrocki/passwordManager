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
        /*[TestInitialize]
        public void TestInitialize()
        {
            List<Category> categories = new List<Category>();
            List<Account> accounts = new List<Account>();
            List<CreditCard> creditCards = new List<CreditCard>();

            Category facultad = new Category("Facultad");
            Category trabajo = new Category("Trabajo");
            Category personal = new Category("Personal");

            categories.Add(facultad);
            categories.Add(trabajo);

        }*/
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

        [TestMethod]
        public void AssignCategoriesTest()
        {
            User u = new User();
            u.Categories = new List<Category>();
            Assert.IsNotNull(u.Categories);
        }

        [TestMethod]
        public void InicializedCategoriesTest()
        {
            User u = new User();
            Assert.IsNotNull(u.Categories);
        }

        [TestMethod]
        public void AddCategoryTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.Categories.Add(c);
            Assert.AreEqual(1, u.Categories.Count);
        }

        [TestMethod]
        public void RemoveCategoryTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.Categories.Add(c);
            u.Categories.Remove(c);
            Assert.AreEqual(0, u.Categories.Count);
        }

        [TestMethod]
        public void CheckCategoryNameTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.Categories.Add(c);
            Assert.AreEqual("Facultad", u.Categories[0].Name);
        }

        [TestMethod]
        public void AssignAccountsTest()
        {
            User u = new User();
            u.Accounts = new List<Account>();
            Assert.IsNotNull(u.Accounts);
        }

        [TestMethod]
        public void InicializedAccountsTest()
        {
            User u = new User();
            Assert.IsNotNull(u.Accounts);
        }

        [TestMethod]
        public void AddAccountTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            Account a = new Account() { Username="JuanPe123", Note="", Site="Instagram", Modification=DateTime.Now, category=c};
            u.Accounts.Add(a);
            Assert.AreEqual(1, u.Accounts.Count);
        }

        [TestMethod]
        public void InstagramAccountTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            //FALTA AGREGAR ACA PASSWOOOOOOORORDDDDDDDDD!!!!!! fIJARSE EN TODAS LAS PRUEBAS...
            //ELIMINAR COMENTARIO DE ARRIBA ANTES DE ENTREGAR Y ESTE TAMBIEN
            Account a = new Account() { 
                Username = "JuanPe123", 
                Note = "", 
                Site = "Instagram", 
                Modification = DateTime.Now, 
                category = c 
            };
            u.Accounts.Add(a);
            Assert.AreEqual("Instagram", u.Accounts[0].Site);
        }

        [TestMethod]
        public void FacultadAsCategoryForAccountTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.Categories.Add(c);
            Account a = new Account() { 
                Username = "JuanPe123", 
                Note = "", 
                Site = "Instagram", 
                Modification = DateTime.Now, 
                category = u.Categories[0] 
            };
            u.Accounts.Add(a);
            Assert.AreEqual(c, u.Accounts[0].category);
        }

        [TestMethod]
        public void AssignCreditCardTest()
        {
            User u = new User();
            u.CreditCards = new List<CreditCard>();
            Assert.IsNotNull(u.CreditCards);
        }

        [TestMethod]
        public void InicializedCreditCardsTest()
        {
            User u = new User();
            Assert.IsNotNull(u.CreditCards);
        }

        [TestMethod]
        public void AddCreditCardTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            CreditCard cc = new CreditCard()
            {
                Name = "Visa Gold",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "854",
                ExpirationMonth = 3,
                ExpirationYear = 2022,
                Notes = "Tarjeta sin limite",
                category = c
            };
            u.CreditCards.Add(cc);
            Assert.AreEqual(1, u.CreditCards.Count);
        }

        [TestMethod]
        public void CodeComparisonCreditCardTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            CreditCard cc = new CreditCard()
            {
                Name = "Visa Gold",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "854",
                ExpirationMonth = 3,
                ExpirationYear = 2022,
                Notes = "Tarjeta sin limite",
                category = c
            };
            u.CreditCards.Add(cc);
            Assert.AreEqual("854", u.CreditCards[0].Code);
        }

        [TestMethod]
        public void FacultadAsCategoryForCreditCardTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.Categories.Add(c);
            CreditCard cc = new CreditCard()
            {
                Name = "Visa Gold",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "854",
                ExpirationMonth = 3,
                ExpirationYear = 2022,
                Notes = "Tarjeta sin limite",
                category = u.Categories[0]
            };
            u.CreditCards.Add(cc);
            Assert.AreEqual(c, u.CreditCards[0].category);
        }

    }
}
