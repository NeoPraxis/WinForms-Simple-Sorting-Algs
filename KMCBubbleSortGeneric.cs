using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithms
{
    internal class KMCBubbleSortGeneric
    {
        #region data

        #endregion data

        #region properties
        public static int numOfPasses { get; set; }

        //public int NumOfPasses { get => numOfPasses; }
        #endregion properties

        #region events
        #endregion events

        #region methods
        public static void Sort<T>(T[] data) where T : IComparable
        {
            numOfPasses = 0;
            for (int pass = 0; pass < data.GetUpperBound(0); pass++)
            {
                for (int index = 0; index < data.GetUpperBound(0) - pass; index++)
                {
                    if (data[index].CompareTo(data[index+1]) > 0)
                    {
                        // if out of order, swap
                        Swap(data, index, index + 1);
                        numOfPasses++;
                        
                    }
                }
            }
        }
        private static void Swap<T>(T[] data, int firstIndex, int secondIndex)
        {
            T temp;

            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;
        }    
        #endregion methods


    }
}
