using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringFilter.Tests
{
    [TestClass]
    public class StringFilterUnitTests
    {

        private readonly List<string> _baseList = new List<string>(), _comparisonList = new List<string>();
        List<String> _generatedList = new List<string>();

        
        [TestMethod]
        public void Should_consider_and_output_only_6_letter_words()
        {
            List<string> masterList= new List<string>()
                    {
                        "al","albums","aver","averba","barely","be","behold","hold"
                    };

            List<string> expectedList = new List<string>()
                   {
                       "behold"
                   };

            FilterCore.GetSortedList(masterList, _baseList,_comparisonList);
            _generatedList=FilterCore.FilterText(_baseList, _comparisonList);
            CollectionAssert.AreEqual(_generatedList, expectedList);
        }

        [TestMethod]
        public void Should_not_output_matching_more_than_6_letter_words()
        {
            List<string> masterList = new List<string>()
                    {
                        "allalbums","albums","aver","averbarely","barely","be","betold","told", "all"
                    };

            List<string> expectedList = new List<string>()
                   {
                       "betold"
                   };

            FilterCore.GetSortedList(masterList, _baseList, _comparisonList);
            _generatedList = FilterCore.FilterText(_baseList, _comparisonList);
            CollectionAssert.AreEqual(_generatedList, expectedList);
        }

        [TestMethod]
        public void Should_not_output_matching_less_than_6_letter_words()
        {
            List<string> masterList = new List<string>()
                    {
                        "alls","s","remem","te","remems","be","bete","told", "a", "atold"
                    };

            List<string> expectedList = new List<string>()
                   {
                       "remems"
                   };

            FilterCore.GetSortedList(masterList, _baseList, _comparisonList);
            _generatedList = FilterCore.FilterText(_baseList, _comparisonList);
            CollectionAssert.AreEqual(_generatedList, expectedList);
        }
    }
}
