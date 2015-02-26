using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSAlumni.Utils;
namespace CSAlumniTest {
    [TestFixture]
    class TestStringHelper {


        [Test]
        public void testIsStringEmpty() {
            string emptyString = "";
            Boolean isEmpty = StringHelper.isEmpty(emptyString);
            Assert.AreEqual(true, isEmpty);
        }
        [Test]
        public void testIsStringNotEmpty() {
            string notAnEmptyString = "text";
            Boolean isEmpty = StringHelper.isEmpty(notAnEmptyString);
            Assert.AreEqual(false, isEmpty);
        }
        [Test]
        public void testEncodeString()
        {
            string Username = "username";
            string Password = "password";
            string toEncode = StringHelper.EncodeString(Username, Password);
            string expected = String.Format("{0}:{1}", Username, Password).EncodeString();

            Assert.AreEqual(expected, toEncode);
        }

    }

}
