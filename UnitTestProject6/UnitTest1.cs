﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject6
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void one_is_1()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.GetResult(1);
            Assert.AreEqual("1", result);
        }
    }
}