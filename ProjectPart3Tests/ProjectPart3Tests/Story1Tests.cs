using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPart3;

namespace ProjectPart3Tests
{
    [TestClass]
    public class Story1Tests
    {
        /// <summary>
        /// User story 1. As a research assistant, I want to store titles, author names, years of publication, and abstracts of papers so that I can keep track of them.
        /// </summary>

        [TestMethod]
        public void AddPaperTest_NormalPath()
        {
            Paper p = new Paper("not winning", "sean boyd", "teaches you how to lose", 1535);
            PaperList actual = new PaperList();
            actual.addPaper(p);
            Paper expected = new Paper("not winning", "sean boyd", "teaches you how to lose", 1535);
            Assert.AreEqual(expected.getName(), actual.getPaper("not winning").getName());

        }

        [TestMethod]
        public void AddPaperTest_HasPaper()
        {
            Paper p = new Paper("not winning", "sean boyd", "teaches you how to lose", 1535);
            Paper p1 = new Paper("test", "test mcgee", "how to test", 2012);
            PaperList actual = new PaperList();
            actual.addPaper(p1);
            actual.addPaper(p);
            Paper expected = new Paper("not winning", "sean boyd", "teaches you how to lose", 1535);
            Assert.AreEqual(expected.getName(), actual.getPaper("not winning").getName());
        }

        [TestMethod]
        public void AddPaperTest_Duplicate()
        {
            PaperList expected = new PaperList(new Paper("testing", "dovahkiin", "this is a test", 500));
            PaperList actual = new PaperList(new Paper("testing", "dovahkiin", "this is a test", 500));
            actual.addPaper(new Paper("testing", "dovahkiin", "this is a test", 500));
            Assert.AreEqual(expected.getList()[0].getName(), actual.getList()[0].getName());
            Assert.IsTrue(actual.getList().Count == 1);
        }

        [TestMethod]
        public void AddPaperTest_InvalidArguments()
        {
            PaperList expected = new PaperList( new Paper("this is", "a valid", "paper", 2000) );
            PaperList actual = new PaperList( new Paper("this is", "a valid", "paper", 2000) );
            actual.addPaper(new Paper("", "", "", -20));
            Assert.AreEqual(expected.getList()[0].getName(), actual.getList()[0].getName());
            Assert.IsTrue(actual.getList().Count == 1);
        }
 
    }
}
