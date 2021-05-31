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
    public class PasswordRequirementTest
    {
        [TestMethod]
        public void ContainsUpperCaseTest()
        {
            PasswordRequirement upper = new NeedUpperCase();
            Assert.IsTrue(upper.ContainsRequirement("1Aa/t?er2345764"));
        }

        [TestMethod]
        public void NoUpperCaseTest()
        {
            PasswordRequirement upper = new NeedUpperCase();
            Assert.IsFalse(upper.ContainsRequirement("12a/t?er2345764"));
        }

        [TestMethod]
        public void ContainsLowerCaseTest()
        {
            PasswordRequirement lower = new NeedLowerCase();
            Assert.IsTrue(lower.ContainsRequirement("1Aa/t?er2345764"));
        }

        [TestMethod]
        public void NoLowerCaseTest()
        {
            PasswordRequirement lower = new NeedLowerCase();
            Assert.IsFalse(lower.ContainsRequirement("12A/T?ITR2345764"));
        }

        [TestMethod]
        public void ContainsDigitsTest()
        {
            PasswordRequirement digits = new NeedDigits();
            Assert.IsTrue(digits.ContainsRequirement("1Aa/t?er2345764"));
        }

        [TestMethod]
        public void NoDigitsTest()
        {
            PasswordRequirement digits = new NeedDigits();
            Assert.IsFalse(digits.ContainsRequirement("A/T?ITRksjdb"));
        }

        [TestMethod]
        public void ContainsSpecialsTest()
        {
            PasswordRequirement specials = new NeedSpecials();
            Assert.IsTrue(specials.ContainsRequirement("1Aa/t?er2345764"));
        }

        [TestMethod]
        public void NoSpecialsTest()
        {
            PasswordRequirement specials = new NeedSpecials();
            Assert.IsFalse(specials.ContainsRequirement("A3143TITRksjdb"));
        }
    }
}
