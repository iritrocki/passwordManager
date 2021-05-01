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
            u.TryAddCategory(c);
            Assert.AreEqual(1, u.Categories.Count);
        }

        [ExpectedException(typeof(ExistentCategoryNameException))]
        [TestMethod]
        public void TryAddRepeatedCategoryTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.TryAddCategory(c);
            Category c2 = new Category("Facultad");
            u.TryAddCategory(c2);
        }

        [ExpectedException(typeof(ExistentCategoryNameException))]
        [TestMethod]
        public void TryAddRepeatedCategoryCaseInsensitiveTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.TryAddCategory(c);
            Category c2 = new Category("facultad");
            u.TryAddCategory(c2);
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
        public void TryAddAccountTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            Account a = new Account() {
                Username = "JuanPe123",
                Password = "kfjbvskSKS??",
                Note="", 
                Site="Instagram", 
                Modification=DateTime.Now, 
                category=c};
            u.TryAddAccount(a);
            Assert.AreEqual(1, u.Accounts.Count);
        }

        [ExpectedException(typeof(InvalidAccountUsernameException))]
        [TestMethod]
        public void TryAddInvalidAccountTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            Account a = new Account()
            {
                Username = "Ju",
                Password = "kfjbvskSKS??",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                category = c
            };
            u.TryAddAccount(a);
        }

        [TestMethod]
        public void TryRemoveAccountTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            Account a = new Account()
            {
                Username = "JuanPe123",
                Password = "kfjbvskSKS??",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                category = c
            };
            u.TryAddAccount(a);
            u.TryRemoveAccount(a);
            Assert.AreEqual(0, u.Accounts.Count);
        }

        [ExpectedException(typeof(InexistentAccountException))]
        [TestMethod]
        public void TryRemoveInexistentAccountTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            Account a = new Account()
            {
                Username = "JuanPe123",
                Password = "kfjbvskSKS??",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                category = c
            };
            u.TryRemoveAccount(a);
        }

        [TestMethod]
        public void InstagramAccountTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            Account a = new Account() { 
                Username = "JuanPe123", 
                Password = "12345678",
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
                Password = "viuwbdkSVHSBD",
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
        public void TryAddCreditCardTest()
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
            u.TryAddCreditCard(cc);
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

        [TestMethod]
        public void TryRemoveCreditCardTest()
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
            u.TryAddCreditCard(cc);
            u.TryRemoveCreditCard(cc);
            Assert.AreEqual(0, u.CreditCards.Count);
        }

        [ExpectedException(typeof(InexistentCreditCardException))]
        [TestMethod]
        public void TryRemoveInexistentCreditCardTest()
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
            u.TryRemoveCreditCard(cc);
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

        [TestMethod]
        public void AccountColorCountInitializedTest()
        {
            User u = new User();
            Assert.IsNotNull(u.ColorCount);
        }

        [TestMethod]
        public void AccountColorCountLengthTest()
        {
            User u = new User();
            Assert.AreEqual(5, u.ColorCount.Length);
        }

        [TestMethod]
        public void AddAccountColorCountChangesTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.Categories.Add(c);
            Account a = new Account()
            {
                Username = "JuanPe123",
                Password = "viuwbd",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                category = u.Categories[0]
            };
            u.TryAddAccount(a);
            Assert.AreEqual(1, u.ColorCount[(int)a.Classification]);
        }

        [TestMethod]
        public void RemoveAccountColorCountChangesTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.Categories.Add(c);
            Account a = new Account()
            {
                Username = "JuanPe123",
                Password = "vsjkdjfjsdhjf",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                category = u.Categories[0]
            };
            u.TryAddAccount(a);
            u.TryRemoveAccount(a);
            Assert.AreEqual(0, u.ColorCount[(int)a.Classification]);
        }

        //FALTA BAJAR Y SUBIR COUNT DE COLORES CUANDO SE MODIFICA PASSWORD
        
        [TestMethod]
        public void FilterByColorLengthTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.Categories.Add(c);
            Account a = new Account()
            {
                Username = "JuanPe123",
                Password = "vsjkdjfjsdhjf",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                category = u.Categories[0]
            };
            u.TryAddAccount(a);
            Assert.AreEqual(1, u.FilterBy(a.Classification).Count());
        }

        [TestMethod]
        public void FilterByColorAccountAddedTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.Categories.Add(c);
            Account a = new Account()
            {
                Username = "JuanPe123",
                Password = "vsjkdjfjsdhjf",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                category = u.Categories[0]
            };
            u.TryAddAccount(a);
            Assert.AreEqual(a, u.FilterBy(a.Classification)[0]);
        }

        [TestMethod]
        public void FilterByColorAccountNotAddedTest()
        {
            User u = new User();
            Category c = new Category("Facultad");
            u.Categories.Add(c);
            Account a = new Account()
            {
                Username = "JuanPe123",
                Password = "vsjkdjfjsdhjf",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                category = u.Categories[0]
            };
            u.TryAddAccount(a);
            Assert.AreEqual(0, u.FilterBy(Account.Color.Red).Count());
        }

    }

    [TestClass]
    public class UserTestWithInitializedData
    {
        User u;

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
                category = personal
            };

            Account linkedIn = new Account()
            {
                Username = "JuanPerez",
                Password = "Ekjdy2345",
                Note = "Soy nuevo en linked in",
                Site = "Linked In",
                Modification = DateTime.Now,
                category = personal
            };

            Account github = new Account()
            {
                Username = "JuanPerez123",
                Note = "Github para el laburo",
                Site = "github.com",
                Modification = DateTime.Now,
                category = trabajo
            };
            github.GeneratePassword(20, true, true, true, true);

            Account github2 = new Account()
            {
                Username = "Juanchoperez",
                Note = "Github para la facu",
                Site = "github.com",
                Modification = DateTime.Now,
                category = facultad
            };
            github.GeneratePassword(12, true, true, false, false);

            CreditCard itau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "827",
                ExpirationMonth = 3,
                ExpirationYear = 2023,
                Notes = "Sin limite",
                category = personal
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
                category = trabajo
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
                category = personal
            };

            u = new User();
            u.TryAddCategory(facultad);
            u.TryAddCategory(trabajo);
            u.TryAddCategory(personal);
            u.TryAddAccount(github);
            u.TryAddAccount(github2);
            u.TryAddAccount(linkedIn);
            u.TryAddAccount(instagram);
            u.TryAddCreditCard(itau);
            u.TryAddCreditCard(santander);
            u.TryAddCreditCard(americanExpress);

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
                category = u.Categories[1]
            };
            u.TryAddAccount(linkedIn);
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
                category = u.Categories[0]
            };
            u.TryAddCreditCard(cc);
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
                category = u.Categories[0]
            };
            u.TryModifyAccount(u.Accounts[0], modificationAccount);
            Assert.AreEqual("VSCO", u.Accounts[0].Site);

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
                category = u.Categories[0]
            };
            Account toChange = u.Accounts[0];
            u.TryModifyAccount(u.Accounts[0], modificationAccount);
            Assert.IsTrue(u.Accounts.Contains(toChange));

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
                category = u.Categories[0]
            };

            u.TryModifyAccount(u.Accounts[0], modificationAccount);

        }

        [TestMethod]
        public void TryModifyCategoryTest()
        {
            u.TryModifyCategory(u.Categories[0], "Hobbies");
            Assert.AreEqual("Hobbies", u.Categories[0].Name);

        }

        [TestMethod]
        public void TryModifyCategoryAddedToListTest()
        {
            Category toChange = u.Categories[0];
            u.TryModifyCategory(u.Categories[0], "Hobbies");
            Assert.IsTrue(u.Categories.Contains(toChange));

        }

        [ExpectedException(typeof(ExistentCategoryNameException))]
        [TestMethod]
        public void TryModifyToRepeatedCategoryTest()
        {
            u.TryModifyCategory(u.Categories[0], "trabajo");

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
                category = u.Categories[0]
            };
            u.TryModifyCreditCard(u.CreditCards[0], modifiedItau);
            Assert.AreEqual("3526 4827 2387 2873", u.CreditCards[0].Number);

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
                category = u.Categories[0]
            };
            u.TryModifyCreditCard(u.CreditCards[0], modifiedItau);
        }

    }
}
