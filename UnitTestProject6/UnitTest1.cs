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

        [TestMethod]
        public void five_is_barbar()
        {
            FooBarQix fooBarQix = new FooBarQix();
            var what = fooBarQix.What(5);
            Assert.AreEqual("BarBar", what);
        }

        [TestMethod]
        public void six_is_foo()
        {
            FooBarQix fooBarQix = new FooBarQix();
            var what = fooBarQix.What(6);
            Assert.AreEqual("Foo", what);
        }

        [TestMethod]
        public void seven_is_qixqix()
        {
            FooBarQix fooBarQix = new FooBarQix();
            var what = fooBarQix.What(7);
            Assert.AreEqual("QixQix", what);
        }

        [TestMethod]
        public void eight_is_8()
        {
            FooBarQix fooBarQix = new FooBarQix();
            var what = fooBarQix.What(8);
            Assert.AreEqual("8", what);
        }

        [TestMethod]
        public void nine_is_foo()
        {
            FooBarQix fooBarQix = new FooBarQix();
            var what = fooBarQix.What(9);
            Assert.AreEqual("Foo", what);
        }

        [TestMethod]
        public void ten_is_bar()
        {
            FooBarQix fooBarQix = new FooBarQix();
            var what = fooBarQix.What(10);
            Assert.AreEqual("Bar", what);
        }
    }
}