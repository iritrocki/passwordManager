using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using passwordManager;
using passwordManager.Exceptions;

namespace passwordManagerTest
{
    [TestClass]
    public class accountTest
    {
        [TestMethod]
        public void CreateNewAccountTest()
        {
            Account a = new Account();
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void AssignUsernameTest()
        {
            Account a = new Account();
            a.Username = "juanpe123";
            Assert.AreEqual("juanpe123", a.Username);
        }

        [TestMethod]
        public void AppropiateUsernameTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ValidateUsernameAndPassword("juanpe123"));
        }

        [TestMethod]
        public void InappropiateUsernameTest()
        {
            Account a = new Account();
            Assert.IsFalse(a.ValidateUsernameAndPassword("jprs"));
        }

        [ExpectedException(typeof(InvalidAccountUsernameException))]
        [TestMethod]
        public void InvalidUsernameTest()
        {
            Account a = new Account();
            a.Username = "jprs";
        }

        [TestMethod]
        public void AssignPasswordTest()
        {
            Account a = new Account();
            Password p = new Password();
            a.Password = p;
            Assert.AreEqual(p, a.Password);
        }

        /*[TestMethod]
        public void createPasswordTest()
        {
            Account a = new Account();
            a.password = a.createPassword("1234893");
            Assert.AreEqual("1234893", a.password.p);
        }*/

        [TestMethod]
        public void AppropiatePasswordTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ValidateUsernameAndPassword("123495"));
        }

        [TestMethod]
        public void InappropiatePasswordTest()
        {
            Account a = new Account();
            Assert.IsFalse(a.ValidateUsernameAndPassword("000"));
        }

        [TestMethod]
        public void AssignSiteTest()
        {
            Account a = new Account();
            a.Site = "Instagram";
            Assert.AreEqual("Instagram", a.Site);
        }

        [TestMethod]
        public void ValidSiteTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ValidateSite("Instagram"));
        }
        
        [TestMethod]
        public void InvalidSiteTest()
        {
            Account a = new Account();
            Assert.IsFalse(a.ValidateSite("FB"));
        }

        [ExpectedException(typeof(InvalidAccountSiteException))]
        [TestMethod]
        public void TooLongSiteTest()
        {
            Account a = new Account();
            a.Site = "www.maniakdenim.com/maniakbrava";
        }


        [TestMethod]
        public void AssignNoteTest()
        {
            Account a = new Account();
            a.Note = "Cuenta personal";
            Assert.AreEqual("Cuenta personal", a.Note);
        }

        [TestMethod]
        public void ValidNotesTest()
        {
            Account a = new Account();
            Assert.IsTrue(a.ValidateNotes(""));
        }

        [TestMethod]
        public void InvalidNotesTest()
        {
            Account a = new Account();
            //El siguiente string contiene mas de 250 caracteres.
            Assert.IsFalse(a.ValidateNotes("asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb;ashkbcwehjld;cwe ckfshbv;d;fkdfvw;kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv;iafbv;ae ivhbae;fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb"));
        }

        [ExpectedException(typeof(InvalidAccountNotesException))]
        [TestMethod]
        public void TooLongNotesTest()
        {
            Account a = new Account();
            a.Note = "asdfghjk lpoqdcnsdjncka csn v,as dfv, as vaskhcb;ashkbcwehjld;cwe ckfshbv;d;fkdfvw;kjnwroiwuf bvldfhubvjdshfbvl dfbvldj hfbvlja shfbvdjs lahfbvl dfhbv;iafbv;ae ivhbae;fibhvldfjhbvldjsfbhv fvfvfvafibhvasljfv asvashbas dlvjcb safjlvlshi asljdvb ajv jbv qj vehrbfje rvlejbr velhrleiblehrbf rflrefhb";
        }

        [TestMethod]
        public void AssignModificationDateTest()
        {
            Account a = new Account();
            DateTime d= DateTime.Now;
            a.Modification = d;
            Assert.AreEqual(d, a.Modification);
        }

        [TestMethod]
        public void CreateAccountAsDataUnitTest()
        {
            DataUnit a = new Account();
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void CreateAccountWithCategoryTest()
        {
            Category cat = new Category("Trabajo");
            DataUnit a = new Account();
            a.category = cat;
            Assert.AreEqual(cat, a.category);
        }

        

    }
}
