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
        public void StringValidationTest()
        {
            Assert.IsTrue(Validator.ValidateStringLength("123495", (5, 25)));
        }

        [TestMethod]
        public void TooShortStringValidationTest()
        {
            Assert.IsFalse(Validator.ValidateStringLength("000", (5, 25)));
        }

        [TestMethod]
        public void ValidSiteTest()
        {
            Assert.IsTrue(Validator.ValidateStringLength("Instagram", (3,25)));
        }
        
        [TestMethod]
        public void InvalidSiteTest()
        {
            Assert.IsFalse(Validator.ValidateStringLength("FB", (3, 25)));
        }

        [TestMethod]
        public void ValidNoteTest()
        {
            Assert.IsFalse(Validator.ValidateStringLength("", (3, 25)));
        }

        [TestMethod]
        public void InvalidNoteTest()
        {
            Assert.IsFalse(Validator.ValidateStringLength("Este string contiene mas de 250 caracteres-- > asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb; ashkbcwehjld; cwe ckfshbv; d; fkdfvw; kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv; iafbv; ae ivhbae; fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb", (3, 25)));
        }

        [TestMethod]
        public void ValidCreditCardNumber()
        {
            Assert.IsTrue(Validator.ValidateCreditCardNumber("1234 5678 1234 5678"));
        }

        [TestMethod]
        public void InvalidTooLongCreditCardNumber()
        {
            Assert.IsFalse(Validator.ValidateCreditCardNumber("1234 5678 1234 567478"));
        }

        
        [TestMethod]
        public void InvalidNotDigitsNumberTest()
        {
            Assert.IsFalse(Validator.ValidateCreditCardNumber("4a51 7a20 18r4 4153"));
        }

        [TestMethod]
        public void InvalidTooShortNumberTest()
        {
            Assert.IsFalse(Validator.ValidateCreditCardNumber("1874 4153"));
        }

        [TestMethod]
        public void ValidateValidCodeTest()
        {
            Assert.IsTrue(Validator.ValidateCreditCardCode("183"));
        }

        [TestMethod]
        public void ValidateInvalidCodeTest()
        {
            Assert.IsFalse(Validator.ValidateCreditCardCode("19"));
        }

        [TestMethod]
        public void ValidCodeFourDigitsTest()
        {
            Assert.IsTrue(Validator.ValidateCreditCardCode("1845"));
        }

        [TestMethod]
        public void InvalidCodeNotDigitsTest()
        {
            Assert.IsFalse(Validator.ValidateCreditCardCode("1js2"));
        }

        [TestMethod]
        public void ValidExpirationMonthTest()
        {
            Assert.IsTrue(Validator.ValidateExpirationMonth(3));
        }

        [TestMethod]
        public void InvalidExpirationMonthTest()
        {
            Assert.IsFalse(Validator.ValidateExpirationMonth(-5));
        }

        [TestMethod]
        public void ValidExpirationYearTest()
        {
            Assert.IsTrue(Validator.ValidateExpirationYear(2024));
        }

        [TestMethod]
        public void InvalidExpirationYearTest()
        {
            Assert.IsFalse(Validator.ValidateExpirationYear(20240));
        }

        [TestMethod]
        public void ValidExpirationDateTest()
        {
            Assert.IsTrue(Validator.ValidateExpirationDateInput("02/2022"));
        }

        [TestMethod]
        public void ValidAnotherFormatExpirationDateTest()
        {
            Assert.IsTrue(Validator.ValidateExpirationDateInput("2/2022"));
        }

        [TestMethod]
        public void InvalidMonthFormatExpirationDateTest()
        {
            Assert.IsFalse(Validator.ValidateExpirationDateInput("Feb/2022"));
        }

        [TestMethod]
        public void InvalidFormatExpirationDateTest()
        {
            Assert.IsFalse(Validator.ValidateExpirationDateInput("02-2022"));
        }


        

    }
}
