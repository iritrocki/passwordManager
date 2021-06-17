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
        public void ValidateValidNameTest()
        {
            Category c = new Category();
            c.Name = "Ort";
            Assert.AreEqual("Ort", c.Name);
        }

        [ExpectedException(typeof(invalidCategoryNameException))]
        [TestMethod]
        public void ValidateLongerThanValidLengthTest()
        {
            Category c = new Category();
            string unString = "supercalifragilisticoespialidoso";
            c.Name = unString;
        }


        [ExpectedException(typeof(invalidCategoryNameException))]
        [TestMethod]
        public void InvalidCategoryNameTest()
        {
            Category c = new Category();
            c.Name = "bp";
        }

        [TestMethod]
        public void ModifyCategoryTest()
        {
            Category c = new Category("facultad");
            c.ModifyCategory("Trabajo");
            Assert.AreEqual("Trabajo", c.Name);
        }

        [ExpectedException(typeof(invalidCategoryNameException))]
        [TestMethod]
        public void TryModifyCategoryTest()
        {
            Category c = new Category("facultad");
            c.ModifyCategory("MT");
        }

        [TestMethod]
        public void ModifyCategoryChangeToUpperCaseTest()
        {
            Category c = new Category("facultad");
            c.ModifyCategory("FACULTAD");
            Assert.AreEqual("FACULTAD", c.Name);
        }
    }
}
