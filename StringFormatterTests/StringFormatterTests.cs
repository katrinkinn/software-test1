using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringFormatterApp;
using System;

namespace StringFormatterTests
{
    [TestClass]
    public class StringFormatterTests
    {
        [TestMethod]
        public void VoidLineTest()
        {
            string s = "";
            StringFormatter str = new StringFormatter();
            string actual = str.SafeString(s);
            Assert.AreEqual(s, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullLineTest()
        {
            string s = null;
            StringFormatter str = new StringFormatter();
            string actual = str.SafeString(s);
        }

        [TestMethod]
        public void QuotationMarksTest()
        {
            string s = "Строка с 'кавычками'";
            string expected = "Строка с \"кавычками\"";
            StringFormatter str = new StringFormatter();
            string actual = str.SafeString(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SelectTest()
        {
            string s = "select";
            string expected = "SELECT";
            StringFormatter str = new StringFormatter();
            string actual = str.SafeString(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            string s = "insert";
            string expected = "INSERT";
            StringFormatter str = new StringFormatter();
            string actual = str.SafeString(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            string s = "update";
            string expected = "UPDATE";
            StringFormatter str = new StringFormatter();
            string actual = str.SafeString(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteTest()
        {
            string s = "delete";
            string expected = "DELETE";
            StringFormatter str = new StringFormatter();
            string actual = str.SafeString(s);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllConditionsTest()
        {
            string s = "Строка в которой есть и 'кавычки'  и select, insert, update, delete ";
            string expected = "Строка в которой есть и \"кавычки\"  и SELECT, INSERT, UPDATE, DELETE ";
            StringFormatter str = new StringFormatter();
            string actual = str.SafeString(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
