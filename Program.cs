using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        // 1
        public static void ListOperations(List<string> strList)
        {
            // 1.1
            if (strList.Count % 2 != 0)
            {
                strList.RemoveAt(strList.Count / 2);
            }

            // 1.2 
            if (strList.Any(s => s == "mamas"))
            {
                strList.Add("6");
            }


            // 1.3
            if (strList.IndexOf("aram") != -1)
            {
                if (strList.IndexOf("aram") % 2 != 0)
                {
                    strList.Reverse();
                }
            }


            // 1.4
            int allDiffrentNames  = strList.GroupBy(s => s).Count();
            if (allDiffrentNames == 3) 
            {
                var lastValues = strList.Skip(3).ToList();
                var newLs = strList.Take(2).ToList();

                newLs.Add("2");
                newLs.Add("3");
                newLs.Add("4");
                lastValues.ForEach(v => newLs.Add(v));
                strList = newLs.ToList();
            }
        }

        // 2
        public static void DictionaryOperations(Dictionary<string, int> dic) 
        {
            bool isExist = dic.Any(d => d.Key == "scuba" && d.Value == 6);
            if (isExist) {
                dic.Add("Empire", 6);
            }
        }

        //3
        public static void StackOperations(Stack<DateTime> dateTimes) 
        {
            if (dateTimes.Count > 0)
            {

                DateTime headDateTime = dateTimes.Pop();
                if (headDateTime < DateTime.Now)
                {
                    dateTimes.Push(DateTime.Now);
                }
                else
                {
                    dateTimes.Push(headDateTime);
                }
            }
        }
    }
}
