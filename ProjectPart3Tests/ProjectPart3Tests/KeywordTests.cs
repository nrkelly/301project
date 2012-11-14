using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPart3;

namespace ProjectPart3Tests
{
    [TestClass]
    public class KeywordTests
    {
        [TestMethod]
        public void KeywordCreateTest()
        {
            Keyword k = new Keyword("word");
            Assert.IsTrue(k.getWord().Equals("word"));
        }

        [TestMethod]
        public void KeywordEmptyWordTest()
        {
            Keyword k = new Keyword("");
            Assert.IsNull(k);
        }

    }
}
