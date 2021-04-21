using passwordManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }

}

