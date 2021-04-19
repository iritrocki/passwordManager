using passwordManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestor;

namespace passwordManagerTest
{
    [TestClass]
    public class CategoryTest
    {
        [TestMethod]
        public void createCategoryTest()
        {
            Category c = new Category();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void CreateCategoryWithNameTest()
        {
            Category c = new Category();
            c.name = "Facultad";
            Assert.AreEqual("Facultad", c.name);
        }

        [TestMethod]
        public void createCategoryWithParameterTest()
        {
            Category c = new Category("Facultad");
            Assert.AreEqual("Facultad", c.name);
        }

        [TestMethod]
        public void updateNameTest()
        {
            Category c = new Category();
            c.name = "Facultad";
            c.update(c, "Trabajo");
            Assert.AreNotEqual("Facultad", c.name);
        }

        [TestMethod]
        public void validateInvalidNameTest()
        {
            Category c = new Category();
            string unString = "ho";
            Assert.IsFalse(c.validateName(unString));
        }
        
        [TestMethod]
        public void validateValidNameTest()
        {
            Category c = new Category();
            string unString = "Ort";
            Assert.IsTrue(c.validateName(unString));
        }

        [TestMethod]
        public void validateLongerThanValidLengthTest()
        {
            Category c = new Category();
            string unString = "supercalifragilisticoespialidoso";
            Assert.IsFalse(c.validateName(unString));
        }
        
        
        [ExpectedException(typeof(invalidCategoryNameException))]
        [TestMethod]
        public void InvalidCategoryNameTest()
        {
            Category c = new Category();
            c.name = "bp";
        }


    }
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
            Assert.IsTrue(c.validateNumber(c.number));
        }

        [TestMethod]
        public void validateInvalidNumberTest()
        {
            CreditCard c = new CreditCard();
            c.number = "1874 4153";
            Assert.IsFalse(c.validateNumber(c.number));
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
        public void ValidateInvalidCodeFiveDigitsTest()
        {
            CreditCard c = new CreditCard();
            Assert.IsFalse(c.validateCode("18456"));
        }




    }

    
}
