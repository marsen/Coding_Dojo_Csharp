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

        [TestMethod]
        public void three_is_foofoo()
        {
            FooBarQix fooBarQix = new FooBarQix();
            var what = fooBarQix.What(3);
            Assert.AreEqual("FooFoo", what);
        }

        [TestMethod]
        public void four_is_4()
        {
            FooBarQix fooBarQix = new FooBarQix();
            var what = fooBarQix.What(4);
            Assert.AreEqual("4", what);
        }
    }
}