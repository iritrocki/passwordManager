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
    public class DataCheckerTest
    {
        List<Category> categories = new List<Category>();
        List<Account> accounts = new List<Account>();
        List<CreditCard> creditCards = new List<CreditCard>();

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
                Password = "fvjnwqj42kfn",
                Note = "Github para el laburo",
                Site = "github.com",
                Modification = DateTime.Now,
                Category = trabajo
            };

            Account github2 = new Account()
            {
                Username = "Juanchoperez",
                Password = "DSVNsjfj?.>",
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

            
            categories.Add(facultad);
            categories.Add(trabajo);
            categories.Add(personal);
            accounts.Add(github);
            accounts.Add(github2);
            accounts.Add(linkedIn);
            accounts.Add(instagram);
            creditCards.Add(itau);
            creditCards.Add(santander);
            creditCards.Add(americanExpress);

        }

        [ExpectedException(typeof(ExistentCategoryNameException))]
        [TestMethod]
        public void TryAddRepeatedCategoryTest()
        {
            Category facu = new Category("Facultad");
            
            DataChecker.UniqueCategoryCheck(facu, categories);
        }

        [ExpectedException(typeof(ExistentAccountException))]
        [TestMethod]
        public void TryAddRepeatedAccountTest()
        {
            Account linkedIn = new Account()
            {
                Username = "JuanPerez",
                Password = "juanpe2",
                Note = "Soy nuevo en linked in",
                Site = "Linked In",
                Modification = DateTime.Now,
                Category = categories[1]
            };
            DataChecker.UniqueAccountCheck(linkedIn,accounts);
        }

        [ExpectedException(typeof(ExistentCreditCardException))]
        [TestMethod]
        public void TryAddRepeatedCreditCardTest()
        {
            CreditCard cc = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "8945 2948 0498 1289",
                Code = "827",
                ExpirationMonth = 3,
                ExpirationYear = 2023,
                Notes = "Limite 50k dolares",
                Category = categories[0]
            };
            DataChecker.UniqueCreditCardCheck(cc,creditCards);
        }

        [TestMethod]
        public void TryModifyAccountTest()
        {
            Account modificationAccount = new Account()
            {
                Username = "JuanPerez",
                Password = "Ekjdy2345",
                Note = "Tengo muchas fotos para subir a vsco",
                Site = "VSCO",
                Modification = DateTime.Now,
                Category = categories[0]
            };
            Modificator.TryModifyAccount(accounts[0], modificationAccount,accounts);
            Assert.AreEqual("VSCO", accounts[0].Site);

        }

        [TestMethod]
        public void TryModifyAccountAddedToListTest()
        {
            Account modificationAccount = new Account()
            {
                Username = "JuanPerez",
                Password = "Ekjdy2345",
                Note = "Tengo muchas fotos para subir a vsco",
                Site = "VSCO",
                Modification = DateTime.Now,
                Category = categories[0]
            };
            Account toChange = accounts[0];
            Modificator.TryModifyAccount(accounts[0], modificationAccount, accounts);
            Assert.IsTrue(accounts.Contains(toChange));

        }

        [ExpectedException(typeof(ExistentAccountException))]
        [TestMethod]
        public void TryModifyToRepeatedAccountTest()
        {
            Account modificationAccount = new Account()
            {
                Username = "JuanPerez",
                Password = "Ekjdy2345",
                Note = "Soy nuevo en linked in",
                Site = "Linked In",
                Modification = DateTime.Now,
                Category = categories[0]
            };

            Modificator.TryModifyAccount(accounts[0], modificationAccount,accounts);

        }

        [TestMethod]
        public void TryModifyCategoryTest()
        {
            Modificator.TryModifyCategory(categories[0], "Hobbies",categories);
            Assert.AreEqual("Hobbies", categories[0].Name);

        }

        [TestMethod]
        public void TryModifyCategoryAddedToListTest()
        {
            Category toChange = categories[0];
            Modificator.TryModifyCategory(categories[0], "Hobbies",categories);
            Assert.IsTrue(categories.Contains(toChange));

        }

        [ExpectedException(typeof(ExistentCategoryNameException))]
        [TestMethod]
        public void TryModifyToRepeatedCategoryTest()
        {
            Modificator.TryModifyCategory(categories[0], "trabajo",categories);

        }


        [TestMethod]
        public void TryModifyCreditCardTest()
        {
            CreditCard modifiedItau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Master Card",
                Number = "3526 4827 2387 2873",
                Code = "239",
                ExpirationMonth = 5,
                ExpirationYear = 2024,
                Notes = "Limite 100k euros",
                Category = categories[0]
            };
            Modificator.TryModifyCreditCard(creditCards[0], modifiedItau,creditCards);
            Assert.AreEqual("3526 4827 2387 2873", creditCards[0].Number);

        }


        [ExpectedException(typeof(ExistentCreditCardException))]
        [TestMethod]
        public void TryModifyToRepeatedCreditCardTest()
        {
            CreditCard modifiedItau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Master Card",
                Number = "8945 2948 0498 1289",
                Code = "239",
                ExpirationMonth = 5,
                ExpirationYear = 2024,
                Notes = "Limite 100k euros",
                Category = categories[0]
            };
            Modificator.TryModifyCreditCard(creditCards[0], modifiedItau,creditCards);
        }
    }
}
