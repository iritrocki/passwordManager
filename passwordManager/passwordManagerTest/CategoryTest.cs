using passwordManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using passwordManager.Exceptions;

namespace passwordManagerTest
{
    [TestClass]
    public class CategoryTest
    {
        [TestMethod]
        public void CreateCategoryTest()
        {
            Category c = new Category();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void CreateCategoryWithNameTest()
        {
            Category c = new Category();
            c.Name = "Facultad";
            Assert.AreEqual("Facultad", c.Name);
        }

        [TestMethod]
        public void CreateCategoryWithParameterTest()
        {
            Category c = new Category("Facultad");
            Assert.AreEqual("Facultad", c.Name);
        }

        

        [TestMethod]
        public void ValidateInvalidNameTest()
        {
            Category c = new Category();
            string unString = "ho";
            Assert.IsFalse(c.ValidateName(unString));
        }

        [TestMethod]
        public void validateValidNameTest()
        {
            Category c = new Category();
            string unString = "Ort";
            Assert.IsTrue(c.ValidateName(unString));
        }

        [TestMethod]
        public void validateLongerThanValidLengthTest()
        {
            Category c = new Category();
            string unString = "supercalifragilisticoespialidoso";
            Assert.IsFalse(c.ValidateName(unString));
        }


        [ExpectedException(typeof(invalidCategoryNameException))]
        [TestMethod]
        public void InvalidCategoryNameTest()
        {
            Category c = new Category();
            c.Name = "bp";
        }
    }
}
