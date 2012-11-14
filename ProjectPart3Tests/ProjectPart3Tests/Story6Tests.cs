using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPart3;

namespace ProjectPart3Tests
{
    [TestClass]
    public class Story6Tests
    {

        /// <summary>
        /// 6. As a principal investigator, I want to know how frequently two given keywords occur in the same paper so that I can understand how closely they are related.
        /// </summary>


        [TestMethod]
        public void CheckKeywordsRelated_NormalPath()
        {
            Paper p = new Paper("abc", "def", "ghi", 1234);
            p.addKeywords(new List<Keyword>() {new Keyword("test"), new Keyword("test2")});
            Paper p2 = new Paper("abcddd", "def", "ghi", 1234);
            p.addKeywords(new List<Keyword>() {new Keyword("test"), new Keyword("test2")});
            PaperList pl = new PaperList(new List<Paper>() { p, p2 });
            int expected = 2;
            int actual = pl.searchRelationFrequency("test", "test2");
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void CheckKeywordsRelated_DiffCaps()
        {
            Paper p = new Paper("abc", "def", "ghi", 1234);
            p.addKeywords(new List<Keyword>() { new Keyword("test"), new Keyword("test2") });
            Paper p2 = new Paper("abcddd", "def", "ghi", 1234);
            p.addKeywords(new List<Keyword>() { new Keyword("test"), new Keyword("test2") });
            PaperList pl = new PaperList(new List<Paper>() { p, p2 });
            int expected = 2;
            int actual = pl.searchRelationFrequency("Test", "tESt2");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckKeywordsRelated_SameWord()
        {
            Paper p = new Paper("abc", "def", "ghi", 1234);
            p.addKeywords(new List<Keyword>() { new Keyword("test"), new Keyword("test2") });
            Paper p2 = new Paper("abcddd", "def", "ghi", 1234);
            p.addKeywords(new List<Keyword>() { new Keyword("test"), new Keyword("test2") });
            PaperList pl = new PaperList(new List<Paper>() { p, p2 });
            int expected = -1;
            int actual = pl.searchRelationFrequency("test", "test");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckKeywordsRelated_InvalidInput()
        {
            Paper p = new Paper("abc", "def", "ghi", 1234);
            p.addKeywords(new List<Keyword>() { new Keyword("test"), new Keyword("test2") });
            Paper p2 = new Paper("abcddd", "def", "ghi", 1234);
            p.addKeywords(new List<Keyword>() { new Keyword("test"), new Keyword("test2") });
            PaperList pl = new PaperList(new List<Paper>() { p, p2 });
            int expected = -1;
            int actual = pl.searchRelationFrequency("test", "");
            Assert.AreEqual(expected, actual);
        }

    }
}
