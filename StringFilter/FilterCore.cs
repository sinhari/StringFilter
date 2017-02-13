using System;
using System.Collections.Generic;
using System.Linq;

namespace StringFilter
{
    public class FilterCore
    {
        public static List<string> FilterText(List<string> baseList, List<string> comparisonList)
        {
            List<string> output=new List<string>();
            foreach (var item in baseList)
            {
                int itemIndex = baseList.IndexOf(item);

                for (int i = 0; i < baseList.Count; i++)
                {
                    if (((item + baseList[i]).Length == 6) && comparisonList.Contains((item + baseList[i]), StringComparer.CurrentCultureIgnoreCase) && i != itemIndex)
                    {
                       output.Add(item + baseList[i]);
                    }
                }
            }
            return output;
        }

        public static void GetSortedList(List<string> inputList, List<string> baseList ,List<string> comparisonList)
        {
            foreach (var item in inputList)
            {
                if (item.Length == 6)
                {
                    comparisonList.Add(item);
                }
                else if (item.Length <= 5)
                {
                    baseList.Add(item);
                }
            }
        }
    }
}
