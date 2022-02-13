﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1.MoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyser moodAnalyser;
            string message = " I am in happy Mood";
            [TestInitialize]
            public void SetUp()
            {
                moodAnalyser = new MoodAnalyser(message);
            }
            [TestMethod]
            public void TestMethodForHappyMood()

            {
                string expected = "happy";

                string actual = moodAnalyser.AnalyzeMood();
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestMethodForSadMood()

            {
                string expected = "sad";
                MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad Mood");
                string actual = moodAnalyser.AnalyzeMood();
                Assert.AreEqual(expected, actual);
            }
        }

    }
}
}
