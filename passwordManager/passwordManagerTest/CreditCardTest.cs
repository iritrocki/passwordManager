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

        [TestMethod]
        public void ValidateValidNumberTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.ValidateNumber("4551 7820 1874 4153"));
        }


        [TestMethod]
        public void ValidateInvalidNumberTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsFalse(c.ValidateNumber("4a51 7a20 18r4 4153"));
        }

        [TestMethod]
        public void validateInvalidNumberTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsFalse(c.ValidateNumber("1874 4153"));
        }

        [ExpectedException(typeof(InvalidCreditCardNumberException))]
        [TestMethod]
        public void invalidNumberTest()
        {
            CreditCard c = new CreditCard();
            c.Number = "9234 34";
        }

        [ExpectedException(typeof(InvalidCreditCardNumberException))]
        [TestMethod]
        public void invalidNumberNotDigitsTest()
        {
            CreditCard c = new CreditCard();
            c.Number = "a132 bdfd 2345 slf2";
        }

        [TestMethod]
        public void createNewCreditCardWithCodeTest()
        {
            CreditCard c = new CreditCard();
            c.Code = "492";
            Assert.AreEqual("492", c.Code);
        }

        [TestMethod]
        public void validateValidCodeTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.ValidateCode("183"));
        }

        [TestMethod]
        public void validateInvalidCodeTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsFalse(c.ValidateCode("19"));
        }

        [TestMethod]
        public void ValidCodeFourDigitsTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.ValidateCode("1845"));
        }

        [ExpectedException(typeof(InvalidCreditCardCodeException))]
        [TestMethod]
        public void TooLongCodeTest()
        {
            CreditCard c = new CreditCard();
            c.Code = "938475";
        }

        [TestMethod]
        public void tooShortNameTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsFalse(c.ValidateText("AE"));
        }

        [TestMethod]
        public void validNameTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.ValidateText("Visa Gold"));
        }

        [ExpectedException(typeof(InvalidCreditCardNameException))]
        [TestMethod]
        public void invalidNameTest()
        {
            CreditCard c = new CreditCard();
            c.Name = "AE";
        }

        [ExpectedException(typeof(InvalidCreditCardCompanyException))]
        [TestMethod]
        public void invalidCompanyTest()
        {
            CreditCard c = new CreditCard();
            c.Company = "AE";
        }

        [TestMethod]
        public void createNewCreditCardWithExpirationMonthTest()
        {
            CreditCard c = new CreditCard();
            c.ExpirationMonth = 4;
            Assert.AreEqual(4, c.ExpirationMonth);
        }

        [TestMethod]
        public void createNewCreditCardWithExpirationYearTest()
        {
            CreditCard c = new CreditCard();
            c.ExpirationYear = 2024;
            Assert.AreEqual(2024, c.ExpirationYear);
        }

        [TestMethod]
        public void validExpirationMonthTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.ValidateExpirationMonth(3));
        }

        [TestMethod]
        public void invalidExpirationMonthTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsFalse(c.ValidateExpirationMonth(-5));
        }

        [TestMethod]
        public void validExpirationYearTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.ValidateExpirationYear(2024));
        }

        [TestMethod]
        public void invalidExpirationYearTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsFalse(c.ValidateExpirationYear(20240));
        }

        [ExpectedException(typeof(InvalidCreditCardExpirationDateException))]
        [TestMethod]
        public void invalidMonthExpirationDateTest()
        {
            CreditCard c = new CreditCard();
            c.ExpirationMonth = -2;
        }


        [ExpectedException(typeof(InvalidCreditCardExpirationDateException))]
        [TestMethod]
        public void invalidYearExpirationDateTest()
        {
            CreditCard c = new CreditCard();
            c.ExpirationYear = 1;
        }

        [TestMethod]
        public void createNewCreditCardWithNotesTest()
        {
            CreditCard c = new CreditCard();
            c.Notes = "Limite 400k USD";
            Assert.AreEqual("Limite 400k USD", c.Notes);
        }

        [TestMethod]
        public void validNotesTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.ValidateNotes(""));
        }

        [TestMethod]
        public void invalidNotesTest()
        {
            CreditCard c = new CreditCard();
            //El siguiente string contiene mas de 250 caracteres.
            Assert.IsFalse(c.ValidateNotes("asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb;ashkbcwehjld;cwe ckfshbv;d;fkdfvw;kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv;iafbv;ae ivhbae;fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb"));
        }

        [ExpectedException(typeof(InvalidCreditCardNotesException))]
        [TestMethod]
        public void TooLongNotesTest()
        {
            CreditCard c = new CreditCard();
            c.Notes = "asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb;ashkbcwehjld;cwe ckfshbv;d;fkdfvw;kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv;iafbv;ae ivhbae;fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb";
        }
        
        [TestMethod]
        public void createCreditCardAsDataUnitTest()
        {
            DataUnit c = new CreditCard();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void createCreditCardWithCategoryTest()
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
    }

}

