using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FooBarQixTests
    {
        [TestMethod]
        public void one_is_1()
        {
            FooBarQix fooBarQix = new FooBarQix();
            var what = fooBarQix.What(1);
            Assert.AreEqual("1", what);
        }
    }
}