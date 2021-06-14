using Microsoft.VisualStudio.TestTools.UnitTesting;
using passwordManager;
using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordManagerTest
{
    [TestClass]
    public class TxtFileAdapterTest
    {
        [TestMethod]
        public void CreateNewTxtFileAdapterTest()
        {
            TxtFileAdapter adapter = new TxtFileAdapter();
            Assert.IsNotNull(adapter);
        }

        [ExpectedException(typeof(InvalidPathException))]
        [TestMethod]
        public void AssignDirectoryToAdaptTest()
        {
            string path = Directory.GetCurrentDirectory();
            TxtFileAdapter adapter = new TxtFileAdapter(path);
        }

        [ExpectedException(typeof(InvalidPathException))]
        [TestMethod]
        public void AssignEmptyDirectoryTest()
        {
            string path = "";
            TxtFileAdapter adapter = new TxtFileAdapter(path);
        }


        [TestMethod]
        public void AdaptDataCountCheck()
        {
            TxtFileAdapter adapter = new TxtFileAdapter();
            adapter.dataBreach = "contrasena1\tcontrasena2\tcontrasena3";
            Assert.AreEqual(3, adapter.AdaptData().Count());
        }

        [TestMethod]
        public void AdaptOneDataBreachCheck()
        {
            TxtFileAdapter adapter = new TxtFileAdapter();
            adapter.dataBreach = "unaSolaContrasena";
            Assert.AreEqual(1, adapter.AdaptData().Count());
        }

        [TestMethod]
        public void AdaptDataFirstItemCheck()
        {
            TxtFileAdapter adapter = new TxtFileAdapter();
            adapter.dataBreach = "contrasena1\tcontrasena2\tcontrasena3";
            Assert.AreEqual("contrasena1", adapter.AdaptData()[0]);
        }

        [TestMethod]
        public void AdaptDataSeparationCheck()
        {
            TxtFileAdapter adapter = new TxtFileAdapter();
            adapter.dataBreach = "separacion con espacio no funciona";
            Assert.AreEqual(1, adapter.AdaptData().Count());
        }
    }
}
