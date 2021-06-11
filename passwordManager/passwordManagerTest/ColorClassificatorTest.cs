using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManagerTest
{


    [TestClass]


    public class ColorClassificatorTest
    {


        [TestMethod]
        public void RedPasswordClassificationTest()
        {
            Account a = new Account();
            a.Password = "12345";
            Assert.AreEqual(ColorClassification.Red, a.Classification);
        }

        [TestMethod]
        public void RedPasswordVersion2ClassificationTest()
        {
            Account a = new Account();
            a.Password = "1Aa/t?e";
            Assert.AreEqual(ColorClassification.Red, a.Classification);
        }

        [TestMethod]
        public void NotRedPasswordClassificationTest()
        {
            Account a = new Account();
            a.Password = "1Aa/t?er";
            Assert.AreNotEqual(ColorClassification.Red, a.Classification);
        }

        [TestMethod]
        public void OrangePasswordClassificationTest()
        {
            Account a = new Account();
            a.Password = "1Aa/t?er";
            Assert.AreEqual(ColorClassification.Orange, a.Classification);
        }

        [TestMethod]
        public void NotOrangePasswordClassificationTest()
        {
            Account a = new Account();
            a.Password = "1Aa/t?er2345764";
            Assert.AreNotEqual(ColorClassification.Orange, a.Classification);
        }


        [TestMethod]
        public void YellowPasswordOnlyUpperCaseClassificationTest()
        {
            Account a = new Account();
            a.Password = "ABSHDBKSJFBFVKSVJSDCJN";
            Assert.AreEqual(ColorClassification.Yellow, a.Classification);
        }

        [TestMethod]
        public void YellowPasswordOnlyLowerCaseClassificationTest()
        {
            Account a = new Account();
            a.Password = "ksjdvsjdnvnnvjfvsfjv";
            Assert.AreEqual(ColorClassification.Yellow, a.Classification);
        }

        [TestMethod]
        public void YellowPasswordOnlyDigitsClassificationTest()
        {
            Account a = new Account();
            a.Password = "1234567890123434";
            Assert.AreEqual(ColorClassification.Yellow, a.Classification);
        }

        [TestMethod]
        public void YellowPasswordOnlySpecialsClassificationTest()
        {
            Account a = new Account();
            a.Password = "????@#$%%&()<>:?//";
            Assert.AreEqual(ColorClassification.Yellow, a.Classification);
        }

        [TestMethod]
        public void LightGreenPasswordClassificationTest()
        {
            Account a = new Account();
            a.Password = "djfheNSJVFjdbfbCDJFVJ";
            Assert.AreEqual(ColorClassification.LightGreen, a.Classification);
        }

        [TestMethod]
        public void YellowPasswordLowerSpecialsClassificationTest()
        {
            Account a = new Account();
            a.Password = "jsdnkj////##@$$%";
            Assert.AreEqual(ColorClassification.Yellow, a.Classification);
        }

        [TestMethod]
        public void YellowPasswordLowerDigitsClassificationTest()
        {
            Account a = new Account();
            a.Password = "jsdnkj31465768723";
            Assert.AreEqual(ColorClassification.Yellow, a.Classification);
        }

        [TestMethod]
        public void YellowPasswordUpperDigitsClassificationTest()
        {
            Account a = new Account();
            a.Password = "JDCKJFJ31465768723";
            Assert.AreEqual(ColorClassification.Yellow, a.Classification);
        }

        [TestMethod]
        public void YellowPasswordUpperSpecialsClassificationTest()
        {
            Account a = new Account();
            a.Password = "HBFSBSEJ#@$%^#^#$";
            Assert.AreEqual(ColorClassification.Yellow, a.Classification);
        }

        [TestMethod]
        public void YellowPasswordDigitsSpecialsClassificationTest()
        {
            Account a = new Account();
            a.Password = "2345267823#@$%^#^#$";
            Assert.AreEqual(ColorClassification.Yellow, a.Classification);
        }

        [TestMethod]
        public void LightGreenPasswordLowerUpperDigitsTest()
        {
            Account a = new Account();
            a.Password = "2345267823KJSDBKSkajkj";
            Assert.AreEqual(ColorClassification.LightGreen, a.Classification);
        }

        [TestMethod]
        public void LightGreenPasswordLowerUpperSpecialsTest()
        {
            Account a = new Account();
            a.Password = "@&$*@#(@(*KJSDBKSkajkj";
            Assert.AreEqual(ColorClassification.LightGreen, a.Classification);
        }

        [TestMethod]
        public void LightGreenPasswordLowerDigitsSpecialsTest()
        {
            Account a = new Account();
            a.Password = "@&$*@#(@(*32648748ajkj";
            Assert.AreEqual(ColorClassification.LightGreen, a.Classification);
        }

        [TestMethod]
        public void LightGreenPasswordUpperDigitsSpecialsTest()
        {
            Account a = new Account();
            a.Password = "@&$*@#(@(*KJSDBKS3456";
            Assert.AreEqual(ColorClassification.LightGreen, a.Classification);
        }

        [TestMethod]
        public void DarkGreenPasswordTest()
        {
            Account a = new Account();
            a.Password = "@&$(@(*KDBKksdjnkS36";
            Assert.AreEqual(ColorClassification.DarkGreen, a.Classification);
        }
    }

    [TestClass]

    public class ColorClassificatorWithTestInitializeTest
    {
        List<Category> categories;
        List<Account> accounts;
     
        [TestInitialize]
        public void TestInitialize()
        {
            categories = new List<Category>();
            accounts = new List<Account>();

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
                Password = "AAAAbb",
                Note = "Soy nuevo en linked in",
                Site = "Linked In",
                Modification = DateTime.Now,
                Category = personal
            };

            Account github = new Account()
            {
                Username = "JuanPerez123",
                Password = "fvjnwqj42kfn9898989898",
                Note = "Github para el laburo",
                Site = "github.com",
                Modification = DateTime.Now,
                Category = trabajo
            };

            Account github2 = new Account()
            {
                Username = "Juanchoperez",
                Password = "DSVNsjfj?.>90909090",
                Note = "Github para la facu",
                Site = "github.com",
                Modification = DateTime.Now,
                Category = facultad
            };

            
            categories.Add(facultad);
            categories.Add(trabajo);
            categories.Add(personal);
            accounts.Add(github);
            accounts.Add(github2);
            accounts.Add(linkedIn);
            accounts.Add(instagram);
            

        }
     
        [TestMethod]
        public void AccountColorCountLengthTest()
        {
            
            Assert.AreEqual(5, ColorClassificator.PasswordStrengthCount(accounts).Length);
        }

        [TestMethod]
        public void CorrectNumberOfRedPasswordsTest()
        {
            Assert.AreEqual(1, ColorClassificator.PasswordStrengthCount(accounts)[0]);
        }

        [TestMethod]

        public void AddRedPasswordTest()
        {
            Account twitter = new Account()
            {
                Username = "Pedro Gomez",
                Password = "red12",
                Note = "twitter para la facu",
                Site = "twitter.com",
                Modification = DateTime.Now,
                Category = categories[0]
            };

            accounts.Add(twitter);
            Assert.AreEqual(2, ColorClassificator.PasswordStrengthCount(accounts)[0]);
        }

        [TestMethod]
        public void CheckNumeberRedPasswordWithFilterByTest()
        {
            Account twitter = new Account()
            {
                Username = "Pedro Gomez",
                Password = "red12",
                Note = "twitter para la facu",
                Site = "twitter.com",
                Modification = DateTime.Now,
                Category = categories[0]
            };
            Account tiktok = new Account()
            {
                Username = "Pedro Gomez",
                Password = "rojared",
                Note = "tiktok para la facu",
                Site = "tiktok.com",
                Modification = DateTime.Now,
                Category = categories[0]
            };
            accounts.Add(twitter);
            accounts.Add(tiktok);
            Assert.AreEqual(ColorClassificator.FilterBy(ColorClassification.Red, accounts).Count, ColorClassificator.PasswordStrengthCount(accounts)[0]);
        }

        [TestMethod]
        public void CheckNumeberDarkGreenPasswordWithFilterByTest()
        {
            Account twitter = new Account()
            {
                Username = "Pedro Gomez",
                Password = "1234AAAAbbbb?????",
                Note = "twitter para la facu",
                Site = "twitter.com",
                Modification = DateTime.Now,
                Category = categories[0]
            };
            Account tiktok = new Account()
            {
                Username = "Pedro Gomez",
                Password = "1Ma2Ns#33333lklkosos",
                Note = "tiktok para la facu",
                Site = "tiktok.com",
                Modification = DateTime.Now,
                Category = categories[0]
            };
            accounts.Add(twitter);
            accounts.Add(tiktok);
            Assert.AreEqual(ColorClassificator.FilterBy(ColorClassification.DarkGreen, accounts).Count, ColorClassificator.PasswordStrengthCount(accounts)[4]);
        }




    }
}
