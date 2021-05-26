using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager;
using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManagerTest
{
    [TestClass]
    public class PasswordGeneratorTest
    {
        public PasswordRequirement upper;
        public PasswordRequirement lower;
        public PasswordRequirement digits;
        public PasswordRequirement specials;

        [TestInitialize]
        public void TestInitialize()
        {
            this.upper = new NeedUpperCase();
            this.lower = new NeedLowerCase();
            this.digits = new NeedDigits();
            this.specials = new NeedSpecials();
            
        }
        [TestMethod]
        public void CorrectPasswordLengthTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(upper);
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
            string password = passwordGenerator.Password;

            Assert.AreEqual(12, password.Length);
        }

        
        [TestMethod]
        public void UpperCasePasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(upper);
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
            string password = passwordGenerator.Password;

            Assert.AreEqual(password.ToUpper(), password);
        }
        
        [TestMethod]
        public void LowerCasePasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(lower);
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
            string password = passwordGenerator.Password;

            Assert.AreEqual(password.ToLower(), password);
        }
        
        [TestMethod]
        public void LowerAndUpperCasePasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(upper);
            requirements.Add(lower);
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
            string password = passwordGenerator.Password;

            Assert.AreNotEqual(password.ToLower(), password);
        }
        
        [TestMethod]
        public void ContainsDigitsPasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(upper);
            requirements.Add(lower);
            requirements.Add(digits);
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
            string password = passwordGenerator.Password;

            Assert.IsTrue(digits.ContainsRequirement(password));
        }

        [TestMethod]
        public void ContainsSpecialsPasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(upper);
            requirements.Add(lower);
            requirements.Add(specials);
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
            string password = passwordGenerator.Password;

            Assert.IsTrue(specials.ContainsRequirement(password));
        }

        [TestMethod]
        public void DoesNotContainDigitsPasswordTest()
        {
            PasswordRequirement upper = new NeedUpperCase();
            PasswordRequirement lower = new NeedLowerCase();
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(upper);
            requirements.Add(lower);
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
            string password = passwordGenerator.Password;

            Assert.IsFalse(digits.ContainsRequirement(password));
        }
        
        [TestMethod]
        public void DoesNotContainSpecialsPasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(upper);
            requirements.Add(lower);
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
            string password = passwordGenerator.Password;

            Assert.IsFalse(specials.ContainsRequirement(password));
        }

        
        [TestMethod]
        public void ContainSpecialsDigitsPasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(specials);
            requirements.Add(digits);
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
            string password = passwordGenerator.Password;

            Assert.IsTrue(specials.ContainsRequirement(password) && digits.ContainsRequirement(password) && !upper.ContainsRequirement(password) && !lower.ContainsRequirement(password));
        }

        
        [TestMethod]
        public void ContainSpecialsDigitsUpperPasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(upper);
            requirements.Add(digits);
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
            string password = passwordGenerator.Password;

            Assert.IsTrue(!specials.ContainsRequirement(password) && digits.ContainsRequirement(password) && upper.ContainsRequirement(password) && !lower.ContainsRequirement(password));
        }
        
        [TestMethod]
        public void ContainSpecialsDigitsLowerPasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(lower);
            requirements.Add(digits);
            requirements.Add(specials);
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
            string password = passwordGenerator.Password;

            Assert.IsTrue(specials.ContainsRequirement(password) && digits.ContainsRequirement(password) && !upper.ContainsRequirement(password) && lower.ContainsRequirement(password));
        }

        
        [ExpectedException(typeof(InvalidSelectionForPasswordException))]
        [TestMethod]
        public void EverythingFalsePasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            PasswordGenerator passwordGenerator = new PasswordGenerator(12, requirements);
        }

        [ExpectedException(typeof(InvalidAccountPasswordException))]
        [TestMethod]
        public void TooShortPasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(lower);
            requirements.Add(digits);
            PasswordGenerator passwordGenerator = new PasswordGenerator(4, requirements);
        }

        [ExpectedException(typeof(InvalidAccountPasswordException))]
        [TestMethod]
        public void TooLongPasswordTest()
        {
            List<PasswordRequirement> requirements = new List<PasswordRequirement>();
            requirements.Add(lower);
            requirements.Add(digits);
            PasswordGenerator passwordGenerator = new PasswordGenerator(26, requirements);
        }
    }
}
