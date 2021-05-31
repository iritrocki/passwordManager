using passwordManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager.Exceptions;

namespace passwordManagerTest
{
    [TestClass]
    public class creditCardTest
    {
        [TestMethod]
        public void CreateNewCreditCardTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void CreateNewCreditCardWithNameTest()
        {
            CreditCard c = new CreditCard();
            c.Name = "Visa Gold";
            Assert.AreEqual("Visa Gold", c.Name);
        }

        [TestMethod]
        public void CreateNewCreditCardWithTypeTest()
        {
            CreditCard c = new CreditCard();
            c.Company = "Visa";
            Assert.AreEqual("Visa", c.Company);
        }

        [TestMethod]
        public void CreateNewCreditCardWithNumberTest()
        {
            CreditCard c = new CreditCard();
            c.Number = "4551 7820 1874 4153";
            Assert.AreEqual("4551 7820 1874 4153", c.Number);
        }

        

        [ExpectedException(typeof(InvalidCreditCardNumberException))]
        [TestMethod]
        public void InvalidNumberTest()
        {
            CreditCard c = new CreditCard();
            c.Number = "9234 34";
        }

        [ExpectedException(typeof(InvalidCreditCardNumberException))]
        [TestMethod]
        public void InvalidNumberNotDigitsTest()
        {
            CreditCard c = new CreditCard();
            c.Number = "a132 bdfd 2345 slf2";
        }

        [TestMethod]
        public void CreateNewCreditCardWithCodeTest()
        {
            CreditCard c = new CreditCard();
            c.Code = "492";
            Assert.AreEqual("492", c.Code);
        }

        

        [ExpectedException(typeof(InvalidCreditCardCodeException))]
        [TestMethod]
        public void TooLongCodeTest()
        {
            CreditCard c = new CreditCard();
            c.Code = "938475";
        }


        [ExpectedException(typeof(InvalidCreditCardNameException))]
        [TestMethod]
        public void InvalidNameTest()
        {
            CreditCard c = new CreditCard();
            c.Name = "AE";
        }

        [ExpectedException(typeof(InvalidCreditCardCompanyException))]
        [TestMethod]
        public void InvalidCompanyTest()
        {
            CreditCard c = new CreditCard();
            c.Company = "AE";
        }

        [TestMethod]
        public void CreateNewCreditCardWithExpirationMonthTest()
        {
            CreditCard c = new CreditCard();
            c.ExpirationMonth = 4;
            Assert.AreEqual(4, c.ExpirationMonth);
        }

        [TestMethod]
        public void CreateNewCreditCardWithExpirationYearTest()
        {
            CreditCard c = new CreditCard();
            c.ExpirationYear = 2024;
            Assert.AreEqual(2024, c.ExpirationYear);
        }


        [ExpectedException(typeof(InvalidCreditCardExpirationDateException))]
        [TestMethod]
        public void InvalidMonthExpirationDateTest()
        {
            CreditCard c = new CreditCard();
            c.ExpirationMonth = -2;
        }


        [ExpectedException(typeof(InvalidCreditCardExpirationDateException))]
        [TestMethod]
        public void InvalidYearExpirationDateTest()
        {
            CreditCard c = new CreditCard();
            c.ExpirationYear = 1;
        }

        [TestMethod]
        public void CreateNewCreditCardWithNotesTest()
        {
            CreditCard c = new CreditCard();
            c.Notes = "Limite 400k USD";
            Assert.AreEqual("Limite 400k USD", c.Notes);
        }

        [ExpectedException(typeof(InvalidCreditCardNotesException))]
        [TestMethod]
        public void TooLongNotesTest()
        {
            CreditCard c = new CreditCard();
            c.Notes = "asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb;ashkbcwehjld;cwe ckfshbv;d;fkdfvw;kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv;iafbv;ae ivhbae;fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb";
        }
        
        [TestMethod]
        public void CreateCreditCardAsDataUnitTest()
        {
            DataUnit c = new CreditCard();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void CreateCreditCardWithCategoryTest()
        {
            Category cat = new Category("Trabajo");
            DataUnit c = new CreditCard();
            c.Category = cat;
            Assert.AreEqual(cat, c.Category);
        }

        [TestMethod]
        public void ModifyCreditCardTest()
        {
            Category facultad = new Category("facultad");
            CreditCard itau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "827",
                ExpirationMonth = 3,
                ExpirationYear = 2020,
                Notes = "Sin limite",
                Category = facultad
            };

            CreditCard newItau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "123",
                ExpirationMonth = 3,
                ExpirationYear = 2024,
                Notes = "Sin limite",
                Category = facultad
            };
            itau.ModifyCreditCard(newItau);
            Assert.AreEqual("123", itau.Code);
        }

        [TestMethod]
        public void ModifyAccountVersion2Test()
        {
            Category facultad = new Category("facultad");
            CreditCard itau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "827",
                ExpirationMonth = 3,
                ExpirationYear = 2020,
                Notes = "Sin limite",
                Category = facultad
            };

            CreditCard newItau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "123",
                ExpirationMonth = 3,
                ExpirationYear = 2024,
                Notes = "Sin limite",
                Category = facultad
            };
            itau.ModifyCreditCard(newItau);
            Assert.AreEqual(2024, newItau.ExpirationYear);
        }

        [ExpectedException(typeof(InvalidCreditCardNumberException))]
        [TestMethod]
        public void ModifyAccountVersion3Test()
        {
            Category facultad = new Category("facultad");
            CreditCard itau = new CreditCard()
            {
                Name = "Itau credito",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "123",
                ExpirationMonth = 3,
                ExpirationYear = 2024,
                Notes = "Sin limite",
                Category = facultad
            };

            CreditCard newItau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678",
                Code = "123",
                ExpirationMonth = 3,
                ExpirationYear = 2024,
                Notes = "Sin limite",
                Category = facultad
            };
            itau.ModifyCreditCard(newItau);
            Assert.AreNotEqual("Itau volar", itau.Name);
        }

        [TestMethod]
        public void EqualAccountsTest()
        {
            Category facultad = new Category("facultad");
            CreditCard itau = new CreditCard()
            {
                Name = "Itau credito",
                Company = "Master",
                Number = "1234 5678 2345 5342",
                Code = "275",
                ExpirationMonth = 4,
                ExpirationYear = 2020,
                Notes = "",
                Category = facultad
            };

            CreditCard newItau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "123",
                ExpirationMonth = 3,
                ExpirationYear = 2024,
                Notes = "Sin limite",
                Category = facultad
            };
            Assert.IsTrue(itau.Equals(newItau));

        }

        [TestMethod]
        public void ToStringTest()
        {
            CreditCard newItau = new CreditCard()
            {
                Name = "Itau volar",
                Company = "Visa",
                Number = "1234 5678 2345 5342",
                Code = "123",
                ExpirationMonth = 3,
                ExpirationYear = 2024,
                Notes = "Sin limite"
            };
            Assert.AreEqual("[Itau volar] [Visa] [1234 5678 2345 5342]", newItau.ToString());
        }

        [TestMethod]
        public void SetExpirationDateMonthComparisonTest()
        {
            CreditCard newCreditCard = new CreditCard();
            newCreditCard.SetExpirationDate("02/2022");
            Assert.AreEqual(2, newCreditCard.ExpirationMonth);
        }

        [TestMethod]
        public void SetExpirationDateYearComparisonTest()
        {
            CreditCard newCreditCard = new CreditCard();
            newCreditCard.SetExpirationDate("02/2022");
            Assert.AreEqual(2022, newCreditCard.ExpirationYear);
        }

        [ExpectedException(typeof(InvalidCreditCardExpirationDateException))]
        [TestMethod]
        public void WrongSetExpirationDateTest()
        {
            CreditCard newCreditCard = new CreditCard();
            newCreditCard.SetExpirationDate("22/2022");
        }

        [ExpectedException(typeof(InvalidCreditCardExpirationDateException))]
        [TestMethod]
        public void InvalidFormatSetExpirationDateTest()
        {
            CreditCard newCreditCard = new CreditCard();
            newCreditCard.SetExpirationDate("02-2022");
        }


    }

}

