using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringFilter.Tests
{
    [TestClass]
    public class IntegartionTests
    {
        private readonly List<string> _baseList = new List<string>(), _comparisonList = new List<string>(); 
           
        private readonly List<string> _masterList = new List<string>()
                {
                    "al","albums","aver","bar","barely","be","befoul","bums","by","cat","con","convex","ely","foul","here",
                    "hereby","jig","jigsaw","or","saw","tail","tailor","vex","we","weaver"
                };

        private readonly List<string> _expectedList = new List<string>()
                {
                    "albums", "barely", "befoul", "convex", "hereby", "jigsaw", "tailor", "weaver"
                };

        List<String> _generatedList = new List<string>();

        [TestMethod]
        public void Should_give_same_output_as_specified_in_assessment_text()
        {
            FilterCore.GetSortedList(_masterList, _baseList,_comparisonList);
            _generatedList=FilterCore.FilterText(_baseList, _comparisonList);
            CollectionAssert.AreEqual(_generatedList, _expectedList);
        }

        [TestMethod]
        public void Should_give_equal_numberofelements_as_specified_in_assessment_text()
        {
            FilterCore.GetSortedList(_masterList, _baseList, _comparisonList);
            _generatedList = FilterCore.FilterText(_baseList, _comparisonList);
            Assert.AreEqual(_generatedList.Count, _expectedList.Count);
        }

    }
}
