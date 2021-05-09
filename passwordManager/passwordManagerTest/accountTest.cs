﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        public void AppropiateUsernameTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ValidateUsernameAndPassword("juanpe123"));
        }

        [TestMethod]
        public void InappropiateUsernameTest()
        {
            Account a = new Account();
            Assert.IsFalse(a.ValidateUsernameAndPassword("jprs"));
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


        [TestMethod]
        public void AppropiatePasswordTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ValidateUsernameAndPassword("123495"));
        }

        [TestMethod]
        public void InappropiatePasswordTest()
        {
            Account a = new Account();
            Assert.IsFalse(a.ValidateUsernameAndPassword("000"));
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

        [TestMethod]
        public void ValidSiteTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ValidateSite("Instagram"));
        }
        
        [TestMethod]
        public void InvalidSiteTest()
        {
            Account a = new Account();
            Assert.IsFalse(a.ValidateSite("FB"));
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

        [TestMethod]
        public void ValidNotesTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ValidateNotes(""));
        }

        [TestMethod]
        public void InvalidNotesTest()
        {
            Account a = new Account();
            //El siguiente string contiene mas de 250 caracteres.
            Assert.IsFalse(a.ValidateNotes("asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb;ashkbcwehjld;cwe ckfshbv;d;fkdfvw;kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv;iafbv;ae ivhbae;fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb"));
        }

        [ExpectedException(typeof(InvalidAccountNotesException))]
        [TestMethod]
        public void TooLongNotesTest()
        {
            Account a = new Account();
            a.Note = "asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb;ashkbcwehjld;cwe ckfshbv;d;fkdfvw;kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv;iafbv;ae ivhbae;fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb";
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
        public void ContainsUpperCaseTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ContainsUpperCase("1Aa/t?er2345764"));
        }

        [TestMethod]
        public void NoUpperCaseTest()
        {
            Account a = new Account();
            Assert.IsFalse(a.ContainsUpperCase("12a/t?er2345764"));
        }

        [TestMethod]
        public void ContainsLowerCaseTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ContainsLowerCase("1Aa/t?er2345764"));
        }

        [TestMethod]
        public void NoLowerCaseTest()
        {
            Account a = new Account();
            Assert.IsFalse(a.ContainsLowerCase("12A/T?ITR2345764"));
        }

        [TestMethod]
        public void ContainsDigitsTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ContainsDigits("1Aa/t?er2345764"));
        }

        [TestMethod]
        public void NoDigitsTest()
        {
            Account a = new Account();
            Assert.IsFalse(a.ContainsDigits("A/T?ITRksjdb"));
        }

        [TestMethod]
        public void ContainsSpecialsTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ContainsSpecials("1Aa/t?er2345764"));
        }

        [TestMethod]
        public void NoSpecialsTest()
        {
            Account a = new Account();
            Assert.IsFalse(a.ContainsSpecials("A3143TITRksjdb"));
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
