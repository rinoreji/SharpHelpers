using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpHelpers.ExtensionMethods;
using System;
using System.Collections.Generic;

namespace SharpHelpersTest.ExtensionMethods
{
    [TestClass]
    public class CollectionExtensionsTests
    {
        [TestMethod]
        public void IsNullOrEmpty()
        {
            List<object> nullList = null;
            List<string> list = new List<string> { Guid.NewGuid().ToString() };

            Assert.IsTrue(new List<string>().IsNullOrEmpty());
            Assert.IsTrue(nullList.IsNullOrEmpty());
            Assert.IsFalse(list.IsNullOrEmpty());
        }
    }
}
