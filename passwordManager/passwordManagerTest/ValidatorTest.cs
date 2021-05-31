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
    public class ValidatorTest
    {
        [TestMethod]
        public void NotNullTest()
        {
            Validator v = new Validator();
            Assert.IsNotNull(v);
        }

        [TestMethod]
        public void StringValidationTest()
        {
            Validator v = new Validator();
            Assert.IsTrue(v.ValidateStringLength("123495", (5, 25)));
        }

        [TestMethod]
        public void TooShortStringValidationTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateStringLength("000", (5, 25)));
        }

        [TestMethod]
        public void ValidSiteTest()
        {
            Validator v = new Validator();
            Assert.IsTrue(v.ValidateStringLength("Instagram", (3,25)));
        }
        
        [TestMethod]
        public void InvalidSiteTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateStringLength("FB", (3, 25)));
        }

        [TestMethod]
        public void ValidNoteTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateStringLength("", (3, 25)));
        }

        [TestMethod]
        public void InvalidNoteTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateStringLength("Este string contiene mas de 250 caracteres-- > asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb; ashkbcwehjld; cwe ckfshbv; d; fkdfvw; kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv; iafbv; ae ivhbae; fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb", (3, 25)));
        }

        [TestMethod]
        public void ValidCreditCardNumber()
        {
            Validator v = new Validator();
            Assert.IsTrue(v.ValidateCreditCardNumber("1234 5678 1234 5678"));
        }

        [TestMethod]
        public void InvalidTooLongCreditCardNumber()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateCreditCardNumber("1234 5678 1234 567478"));
        }

        
        [TestMethod]
        public void InvalidNotDigitsNumberTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateCreditCardNumber("4a51 7a20 18r4 4153"));
        }

        [TestMethod]
        public void InvalidTooShortNumberTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateCreditCardNumber("1874 4153"));
        }

        [TestMethod]
        public void ValidateValidCodeTest()
        {
            Validator v = new Validator();
            Assert.IsTrue(v.ValidateCreditCardCode("183"));
        }

        [TestMethod]
        public void ValidateInvalidCodeTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateCreditCardCode("19"));
        }

        [TestMethod]
        public void ValidCodeFourDigitsTest()
        {
            Validator v = new Validator();
            Assert.IsTrue(v.ValidateCreditCardCode("1845"));
        }

        [TestMethod]
        public void InvalidCodeNotDigitsTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateCreditCardCode("1js2"));
        }

        [TestMethod]
        public void ValidExpirationMonthTest()
        {
            Validator v = new Validator();
            Assert.IsTrue(v.ValidateExpirationMonth(3));
        }

        [TestMethod]
        public void InvalidExpirationMonthTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateExpirationMonth(-5));
        }

        [TestMethod]
        public void ValidExpirationYearTest()
        {
            Validator v = new Validator();
            Assert.IsTrue(v.ValidateExpirationYear(2024));
        }

        [TestMethod]
        public void InvalidExpirationYearTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateExpirationYear(20240));
        }

        [TestMethod]
        public void ValidExpirationDateTest()
        {
            Validator v = new Validator();
            Assert.IsTrue(v.ValidateExpirationDateInput("02/2022"));
        }

        [TestMethod]
        public void ValidAnotherFormatExpirationDateTest()
        {
            Validator v = new Validator();
            Assert.IsTrue(v.ValidateExpirationDateInput("2/2022"));
        }

        [TestMethod]
        public void InvalidMonthFormatExpirationDateTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateExpirationDateInput("Feb/2022"));
        }

        

        [TestMethod]
        public void InvalidFormatExpirationDateTest()
        {
            Validator v = new Validator();
            Assert.IsFalse(v.ValidateExpirationDateInput("02-2022"));
        }


        

    }
}
