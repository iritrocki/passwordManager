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
    public class PlainTextAdapterTest
    {
        [TestMethod]
        public void CreateNewPlainTextAdapterTest()
        {
            PlainTextAdapter adapter = new PlainTextAdapter();
            Assert.IsNotNull(adapter);
        }

        [TestMethod]
        public void AssignPlainTextToAdaptTest()
        {
            PlainTextAdapter adapter = new PlainTextAdapter();
            adapter.PlainText = "This is the text i have to adapt";
            Assert.AreEqual("This is the text i have to adapt", adapter.PlainText);
        }
        
        
        [TestMethod]
        public void ParamConstructorAssignPlainTextTest()
        {
            string data = "This is the text i have to adapt";
            PlainTextAdapter adapter = new PlainTextAdapter(data);
            Assert.AreEqual("This is the text i have to adapt", adapter.PlainText);
        }

        
        [TestMethod]
        public void AdaptOneLinePlainTextTest()
        {
            PlainTextAdapter adapter = new PlainTextAdapter();
            adapter.PlainText = "string de una linea";
            Assert.AreEqual(1, adapter.AdaptData().Count);
        }

        [TestMethod]
        public void AdaptOneLineCheckPlainTextTest()
        {
            PlainTextAdapter adapter = new PlainTextAdapter();
            adapter.PlainText = "string de una linea";
            Assert.IsTrue(adapter.AdaptData().Contains("string de una linea"));
        }

        [TestMethod]
        public void AdaptThreeLinesPlainTextTest()
        {
            PlainTextAdapter adapter = new PlainTextAdapter();
            adapter.PlainText = @"String linea 1
linea 2
linea 3
linea 4";
            Assert.AreEqual(4, adapter.AdaptData().Count);
        }

        

    }
}
