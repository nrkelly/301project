using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPart3;

namespace ProjectPart3Tests
{
    [TestClass]
    public class Story2Tests
    {
        /// <summary>
        /// User story 2. As a research assistant, I want to add keywords to stored papers so that I can quickly remember what they are about. 
        /// </summary>

        [TestMethod]
        public void PaperAddKeywordsTest_NormalPath()
        {
            Paper p = new Paper("winning", "nolan kelly", "teaches you how to win", 1337);
            List<Keyword> list = new List<Keyword>() { new Keyword("success"), new Keyword("awesomeness") };
            p.addKeywords(list);
            List<Keyword> actual = p.getKeywords();
            Assert.AreEqual(list[0].getWord(), actual[0].getWord());
            Assert.AreEqual(list[1].getWord(), actual[1].getWord());
        }
        
        [TestMethod]
        public void PaperAddSingleKeywordTest_NormalPath()
        {
            Paper p = new Paper("winning", "nolan kelly", "teaches you how to win", 1337);
            p.addKeyword(new Keyword("success"));
            List<Keyword> actual = p.getKeywords();
            Assert.AreEqual("success", actual[0].getWord());
        }

        [TestMethod]
        public void PaperAddKeywordsTest_Duplicate()
        {
            Paper p = new Paper("winning", "nolan kelly", "teaches you how to win", 1337);
            List<Keyword> list = new List<Keyword>() { new Keyword("success"), new Keyword("awesomeness") };
            p.addKeywords(list);
            p.addKeyword(new Keyword("success"));
            List<Keyword> actual = p.getKeywords();
            Assert.AreEqual(list, actual);
        }

        [TestMethod]
        public void PaperAddSingleKeywordTest_Duplicate()
        {
            Paper p = new Paper("winning", "nolan kelly", "teaches you how to win", 1337);
            List<Keyword> list = new List<Keyword>() { new Keyword("success"), new Keyword("awesomeness") };
            p.addKeywords(list);
            p.addKeyword(new Keyword("success"));
            List<Keyword> actual = p.getKeywords();
            Assert.AreEqual(list, actual);
        }

        [TestMethod]
        public void PaperAddKeywordsTest_InvalidInput()
        {
            Paper p = new Paper("Harry Potter", "JK Rowling", "teaches you how to magic", 2003);
            List<Keyword> list = new List<Keyword>() { new Keyword("") };
            p.addKeywords(list);
            Assert.IsNull(p.getKeywords());
        }

        [TestMethod]
        public void PaperAddSingleKeywordTest_InvalidInput()
        {
            Paper p = new Paper("Harry Potter", "JK Rowling", "teaches you how to magic", 2003);
            p.addKeyword(new Keyword(""));
            Assert.IsNull(p.getKeywords());
        }

    }
}
