using Microsoft.VisualStudio.TestTools.UnitTesting;
using Draw4Fun___client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw4Fun___client.Tests
{
    [TestClass()]
    public class RegisterTests
    {
        [TestMethod()]
        public void isUsernameValidTest()
        {
            RegisterTests test = new RegisterTests();
            Register reg = new Register();
            Assert.IsNotNull(reg.isUsernameValid("karol"));
            Assert.IsTrue(reg.isUsernameValid("slovensko"));
            Assert.IsFalse(reg.isUsernameValid("\"; drop users"));
            Assert.IsTrue(reg.isUsernameValid("oke"));
            Assert.IsFalse(reg.isUsernameValid("kk"));
            


        }

        [TestMethod()]
        public void isPasswordValidTest()
        {
            RegisterTests test = new RegisterTests();
            Register reg = new Register();
            Assert.IsNotNull(reg.isPasswordValid("12345678"));
            Assert.IsTrue(reg.isPasswordValid("yamahadotjap"));
            Assert.IsTrue(reg.isPasswordValid("Kamikadze123SK"));
            Assert.IsFalse(reg.isPasswordValid("heslo"));

        }

        [TestMethod()]
        public void isPasswordEqualTest()
        {
            RegisterTests test = new RegisterTests();
            Register reg = new Register();
            Assert.AreEqual(reg.isPasswordEqual("hesloheslo", "hesloheslo"), true);
            Assert.AreEqual(reg.isPasswordEqual("hesloheslo", "hesloheslO"), false);
            Assert.AreNotEqual(reg.isPasswordEqual("heslo", "heslo5"), true);
            Assert.AreNotEqual(reg.isPasswordEqual("12345", "12345"), false);
            Assert.IsNotNull(reg.isPasswordEqual("heslo", "heslo"));
        }
    }
}