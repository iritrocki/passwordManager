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
}
