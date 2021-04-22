using passwordManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager.Exceptions;

namespace passwordManagerTest
{
    [TestClass]
    public class creditCardTest
    {
        [TestMethod]
        public void createNewCreditCardTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void createNewCreditCardWithNameTest()
        {
            CreditCard c = new CreditCard();
            c.name = "Visa Gold";
            Assert.AreEqual("Visa Gold", c.name);
        }

        [TestMethod]
        public void createNewCreditCardWithTypeTest()
        {
            CreditCard c = new CreditCard();
            c.company = "Visa";
            Assert.AreEqual("Visa", c.company);
        }

        [TestMethod]
        public void createNewCreditCardWithNumberTest()
        {
            CreditCard c = new CreditCard();
            c.number = "4551 7820 1874 4153";
            Assert.AreEqual("4551 7820 1874 4153", c.number);
        }

        [TestMethod]
        public void validateValidNumberTest()
        {
            CreditCard c = new CreditCard();
            c.number = "4551 7820 1874 4153";
            Assert.IsTrue(c.validateNumber("4551 7820 1874 4153"));
        }

        [TestMethod]
        public void validateInvalidNumberTest()
        {
            CreditCard c = new CreditCard();
            //c.number = "1874 4153";
            Assert.IsFalse(c.validateNumber("1874 4153"));
        }

        [ExpectedException(typeof(InvalidCreditCardNumberException))]
        [TestMethod]
        public void invalidNumberTest()
        {
            CreditCard c = new CreditCard();
            c.number = "9234 34";
        }

        [TestMethod]
        public void createNewCreditCardWithCodeTest()
        {
            CreditCard c = new CreditCard();
            c.code = "492";
            Assert.AreEqual("492", c.code);
        }

        [TestMethod]
        public void validateValidCodeTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.validateCode("183"));
        }

        [TestMethod]
        public void validateInvalidCodeTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsFalse(c.validateCode("19"));
        }

        [TestMethod]
        public void ValidCodeFourDigitsTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.validateCode("1845"));
        }

        [ExpectedException(typeof(InvalidCreditCardCodeException))]
        [TestMethod]
        public void TooLongCodeTest()
        {
            CreditCard c = new CreditCard();
            c.code = "938475";
        }

        [TestMethod]
        public void tooShortNameTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsFalse(c.validateText("AE"));
        }

        [TestMethod]
        public void validNameTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.validateText("Visa Gold"));
        }

        [ExpectedException(typeof(InvalidCreditCardNameException))]
        [TestMethod]
        public void invalidNameTest()
        {
            CreditCard c = new CreditCard();
            c.name = "AE";
        }

        [ExpectedException(typeof(InvalidCreditCardCompanyException))]
        [TestMethod]
        public void invalidCompanyTest()
        {
            CreditCard c = new CreditCard();
            c.company = "AE";
        }

        [TestMethod]
        public void createNewCreditCardWithExpirationMonthTest()
        {
            CreditCard c = new CreditCard();
            c.expirationMonth = 4;
            Assert.AreEqual(4, c.expirationMonth);
        }

        [TestMethod]
        public void createNewCreditCardWithExpirationYearTest()
        {
            CreditCard c = new CreditCard();
            c.expirationYear = 2024;
            Assert.AreEqual(2024, c.expirationYear);
        }

        [TestMethod]
        public void validExpirationMonthTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.validateExpirationMonth(3));
        }

        [TestMethod]
        public void invalidExpirationMonthTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsFalse(c.validateExpirationMonth(-5));
        }

        [TestMethod]
        public void validExpirationYearTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.validateExpirationYear(2024));
        }

        [TestMethod]
        public void invalidExpirationYearTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsFalse(c.validateExpirationYear(20240));
        }

        [ExpectedException(typeof(InvalidCreditCardExpirationDateException))]
        [TestMethod]
        public void invalidMonthExpirationDateTest()
        {
            CreditCard c = new CreditCard();
            c.expirationMonth = -2;
        }


        [ExpectedException(typeof(InvalidCreditCardExpirationDateException))]
        [TestMethod]
        public void invalidYearExpirationDateTest()
        {
            CreditCard c = new CreditCard();
            c.expirationYear = 1;
        }

        [TestMethod]
        public void createNewCreditCardWithNotesTest()
        {
            CreditCard c = new CreditCard();
            c.notes = "Limite 400k USD";
            Assert.AreEqual("Limite 400k USD", c.notes);
        }

        [TestMethod]
        public void validNotesTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsTrue(c.validateNotes(""));
        }

        [TestMethod]
        public void invalidNotesTest()
        {
            CreditCard c = new CreditCard();
            //El siguiente string contiene mas de 250 caracteres.
            Assert.IsFalse(c.validateNotes("asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb;ashkbcwehjld;cwe ckfshbv;d;fkdfvw;kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv;iafbv;ae ivhbae;fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb"));
        }

        [ExpectedException(typeof(InvalidCreditCardNotesException))]
        [TestMethod]
        public void TooLongNotesTest()
        {
            CreditCard c = new CreditCard();
            c.notes = "asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb;ashkbcwehjld;cwe ckfshbv;d;fkdfvw;kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv;iafbv;ae ivhbae;fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb";
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
            c.category = cat;
            Assert.AreEqual(cat, c.category);
        }

    }

}

