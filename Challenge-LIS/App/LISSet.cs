using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.LIS
{
    public class LISSet
    {
        static int[] arr;
        static int n;

        /* lis() returns the length of the longest increasing
        subsequence in arr[] of size n */
        public static void lisSet(string getList)
        {
            arr = getList.Split(' ').Select(Int32.Parse).ToArray();
            n = arr.Length;
            int[] lis = new int[n];
            Dictionary<string, string> sequenceValues = new Dictionary<string, string>();
  
            int count = 0;
            int index = 0;
            int max = 0;
            int currentCount = 0;
            int first = 0;
            int second = 1;

            try
            {
                for (int cnt = 1; cnt < n; cnt++)
                {
                    while (arr[first] < arr[second])
                    {

                        if (!sequenceValues.ContainsKey(count.ToString()))
                        {
                            currentCount = 2;
                            sequenceValues.Add(count.ToString(), arr[first].ToString() + " " + arr[second].ToString());
                        }
                        else
                        {
                            currentCount++;
                            sequenceValues[count.ToString()] += " " + arr[second].ToString();

                        }
                        if (max < currentCount)
                        {
                            max = currentCount;
                            index = count;
                        }

                        first = second;
                        second = first + 1;
                    }

                    count++;
                    first = cnt;
                    second = first + 1;

                }
            }
            catch(Exception)
            {
               
            }

         
            Console.WriteLine(sequenceValues[index.ToString()]);


        }
    }
}
