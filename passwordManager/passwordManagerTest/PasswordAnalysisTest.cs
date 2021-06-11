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
    public class PasswordAnalysisTest
    {
        private List<Account> accounts;
        private List<CreditCard> creditCards;
        private List<DataBreachCheck> dataBreaches;

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
                Password = "1234duplicada",
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
            accounts = new List<Account>();
            creditCards = new List<CreditCard>();
            accounts.Add(github);
            accounts.Add(github2);
            accounts.Add(linkedIn);
            accounts.Add(instagram);
            creditCards.Add(itau);
            creditCards.Add(santander);
            creditCards.Add(americanExpress);

            DataBreachCheck db1 = new DataBreachCheck();
            IDataBreachesAdapter typeOfConv1 = new PlainTextAdapter("8945 2948 0498 1289");
            db1.CheckDataBreaches(typeOfConv1, accounts, creditCards);

            DataBreachCheck db2 = new DataBreachCheck();
            IDataBreachesAdapter typeOfConv2 = new PlainTextAdapter("juanjo0909");
            db2.CheckDataBreaches(typeOfConv2, accounts, creditCards);

            DataBreachCheck db3 = new DataBreachCheck();
            IDataBreachesAdapter typeOfConv3 = new PlainTextAdapter(@"Ekjdy2345
1234 1234 1234 1234
asdfghjkl
0987654321");
            db3.CheckDataBreaches(typeOfConv3, accounts, creditCards);

            dataBreaches = new List<DataBreachCheck>();
            dataBreaches.Add(db1);
            dataBreaches.Add(db2);
            dataBreaches.Add(db3);
        }

        [TestMethod]
        public void CreateNewInstance()
        {
            PasswordAnalysis pa = new PasswordAnalysis();
            Assert.IsNotNull(pa);
        }

        [TestMethod]
        public void BoolDataBreachInit()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            Assert.IsFalse(pa.DataBreach);
        }

        [TestMethod]
        public void BoolDuplicatedInit()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            Assert.IsFalse(pa.Duplicated);
        }

        [TestMethod]
        public void BoolSecureInit()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            Assert.IsFalse(pa.Secure);
        }

        [ExpectedException(typeof(NullListException))]
        [TestMethod]
        public void NullDataBreachList()
        {
            List<DataBreachCheck> nullList = null;
            PasswordAnalysis pa = new PasswordAnalysis(nullList, accounts);
        }

        [ExpectedException(typeof(NullListException))]
        [TestMethod]
        public void NullAccountsList()
        {
            List<Account> nullList = null;
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, nullList);
        }

        [TestMethod]
        public void DataBreachTrueAnalysis()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            string password = "juanjo0909";
            pa.RunAnalysis(password);
            Assert.IsTrue(pa.DataBreach);
        }

        [TestMethod]
        public void DataBreachFalseAnalysis()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            string password = "1234lkasjhd";
            pa.RunAnalysis(password);
            Assert.IsFalse(pa.DataBreach);
        }

        [TestMethod]
        public void DuplicatedTrueAnalysis()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            string password = "1234duplicada";
            pa.RunAnalysis(password);
            Assert.IsTrue(pa.Duplicated);
        }

        [TestMethod]
        public void DuplicatedFalseAnalysis()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            string password = "1234unica";
            pa.RunAnalysis(password);
            Assert.IsFalse(pa.Duplicated);
        }

        [TestMethod]
        public void SecureClassificationRedPassword()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            string password = "aaaaa";
            pa.SecureAnalysis(password);
            Assert.IsFalse(pa.Secure);
        }

        [TestMethod]
        public void SecureClassificationOrangePassword()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            string password = "aaBSJ124m";
            pa.SecureAnalysis(password);
            Assert.IsFalse(pa.Secure);
        }

        [TestMethod]
        public void SecureClassificationYellowPassword()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            string password = "ksfskfnfkejnfjsn";
            pa.SecureAnalysis(password);
            Assert.IsFalse(pa.Secure);
        }

        [TestMethod]
        public void SecureClassificationLightGreenPassword()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            string password = "ksBskAAfkejn123sn";
            pa.SecureAnalysis(password);
            Assert.IsTrue(pa.Secure);
        }

        [TestMethod]
        public void SecureClassificationDarkGreenPassword()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            string password = "k@AAsk*nf123jn?j/n";
            pa.SecureAnalysis(password);
            Assert.IsTrue(pa.Secure);
        }

        [TestMethod]
        public void DarkGreenPasswordAnalysis()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            string password = "k@AAsk*nf123jn?j/n";
            pa.RunAnalysis(password);
            Assert.IsTrue(pa.Secure);
        }

        [TestMethod]
        public void CompleteAnalysis()
        {
            PasswordAnalysis pa = new PasswordAnalysis(dataBreaches, accounts);
            string password = "k@AAsk*nf123jn?j/n";
            pa.RunAnalysis(password);
            Assert.IsTrue(!pa.DataBreach && !pa.Duplicated && pa.Secure);
        }

        [TestMethod]
        public void CompleteTrueAnalysis()
        {
            DataBreachCheck db = new DataBreachCheck();
            IDataBreachesAdapter typeOfConv = new PlainTextAdapter("kAAsknf123jnjnda");
            db.CheckDataBreaches(typeOfConv, accounts, creditCards);

            List<DataBreachCheck> auxiliarDataBreaches = new List<DataBreachCheck>();
            auxiliarDataBreaches.Add(db);

            Category hijos = new Category("Hijos");

            Account facebook = new Account()
            {
                Username = "Peter21",
                Password = "kAAsknf123jnjnda",
                Note = "",
                Site = "Instagram",
                Modification = DateTime.Now,
                Category = hijos
            };

            List<Account> auxiliarAccounts = new List<Account>();
            auxiliarAccounts.Add(facebook);

            PasswordAnalysis pa = new PasswordAnalysis(auxiliarDataBreaches, auxiliarAccounts);
            string password = "kAAsknf123jnjnda";
            pa.RunAnalysis(password);
            Assert.IsTrue(pa.DataBreach && pa.Duplicated && pa.Secure);
        }


    }
}
