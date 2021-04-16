using gestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gestorTest
{
    [TestClass]
    public class CategoriaTest
    {
        [TestMethod]
        public void crearCategoriaTest()
        {
            Categoria c = new Categoria();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void crearCategoriaConNombreTest()
        {
            Categoria c = new Categoria();
            c.nombre = "Facultad";
            Assert.AreEqual("Facultad", c.nombre);
        }

        [TestMethod]
        public void crearCategoriaConNombrePorParamTest()
        {
            Categoria c = new Categoria("Facultad");
            Assert.AreEqual("Facultad", c.nombre);
        }

        [TestMethod]
        public void modificarNombreTest()
        {
            Categoria c = new Categoria();
            c.nombre = "Facultad";
            c.modificar(c, "Trabajo");
            Assert.AreNotEqual("Facultad", c.nombre);
        }

        [TestMethod]
        public void validarNombreInvalidoTest()
        {
            Categoria c = new Categoria();
            string unString = "ho";
            Assert.IsFalse(c.validarNombre(unString));
        }
        
        [TestMethod]
        public void validarNombreValidoTest()
        {
            Categoria c = new Categoria();
            string unString = "Ort";
            Assert.IsTrue(c.validarNombre(unString));
        }

        [TestMethod]
        public void validarNombre16LetrasTest()
        {
            Categoria c = new Categoria();
            string unString = "supercalifragilisticoespialidoso";
            Assert.IsFalse(c.validarNombre(unString));
        }


    }

    
}
