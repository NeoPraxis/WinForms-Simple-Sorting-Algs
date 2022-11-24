// COMMON HEADER HERE

using System.CodeDom.Compiler;

namespace SortingAlgorithms
{
    internal class KMCBubbleSort
    {
        #region enum
        #endregion enum

        #region data
        #endregion data

        #region properties
        #endregion properties

        #region events
        #endregion events

        #region methods
        /// <summary>
        /// This method will sort an array of integers using a bubble sort
        /// </summary>
        /// <param name="data"></param>
        public void Sort(int[] data)
        {
            // make n-1 passes through the data
            for (int pass = 0; pass < data.GetUpperBound(0); pass++)
            {
                // for each pass, examine adjacent passes
                for (int index = 0; index < data.GetUpperBound(0); index++)
                {
                    // out of order check
                    if (data[index] > data[index + 1])
                    {
                        Swap(data, index, index + 1);
                    }
                }
            }
        }

        /// <summary>
        /// This routine will swap the two array elements specified by the first
        /// and second index
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        private static void Swap(int[] data, int firstIndex, int secondIndex)
        {
            int temp;

            // set temp node
            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;
        }
        #endregion methods
    }
}
