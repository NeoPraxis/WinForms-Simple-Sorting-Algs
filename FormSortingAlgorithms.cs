using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// COMMON HEADER GOES HERE
namespace SortingAlgorithms
{
    public partial class FormSortingAlgorithms : Form
    {
        #region data
        private int[] valueArray = { 57, 63, 40, 13, 74, 99, 21, 8 };

        //public object numOfPasses { get; private set; }
        #endregion data


        public FormSortingAlgorithms()
        {
            InitializeComponent();
        }

        #region events
        private void buttonBubbleInLine_Click(object sender, EventArgs e)
        {
            DisplayData(valueArray, listBoxPreSort);

            // sort the data
            int temp;       // temp storage for the swap

            // make n-1 passes through the array data
            for (int pass = 0; pass <valueArray.GetUpperBound(0); pass++)

            {
                // for each pass compare adjacent values sarting from the left
                for (int index = 0; index < valueArray.GetUpperBound(0) - pass; index++)
                {
                    // bubble the largest remaining item to the top (right) of the array
                    if (valueArray[index] > valueArray[index + 1])
                    {
                        // if wrong order, swap them
                        temp = valueArray[index];
                        valueArray[index] = valueArray[index + 1];
                        valueArray[index +1] = temp;
                    }
                }
            }
            DisplayData(valueArray, listBoxPostSort);
        }


        /// <summary>
        /// When the user clicks this button, sort the data using a bubble sort
        /// function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFunction_Click(object sender, EventArgs e)
        {
            DisplayData(valueArray, listBoxPreSort);

            BubbleSortFunction(valueArray);

            DisplayData(valueArray, listBoxPostSort); 
        }
        /// <summary>
        /// This button will sort the data using the bubble sort class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBubbleSortClass_Click(object sender, EventArgs e)
        {
            DisplayData(valueArray, listBoxPreSort);

            // sort using the class
            //KMCBubbleSort.Sort(valueArray);

            DisplayData(valueArray, listBoxPostSort);
        }

        /// <summary>
        /// This button sorts the data using the generic class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonBubbleSortGeneric_Click(object sender, EventArgs e)
        {

            DisplayData(valueArray, listBoxPreSort);

            // sort using the class
            KMCBubbleSortGeneric.Sort(valueArray);

            DisplayData(valueArray, listBoxPostSort);

            listBoxPostSort.Items.Add("Number of passes: " + KMCBubbleSortGeneric.numOfPasses.ToString());
        }

        private void FormSortingAlgorithms_Load(object sender, EventArgs e)
        {

        }
        #endregion events

        #region methods
        /// <summary>
        /// This routine will display the array of data in the list box
        /// </summary>
        /// <param name="data"></param>
        /// <param name="theListBox"></param>
        private void DisplayData(int[] data, ListBox theListBox)
        {
            theListBox.Items.Clear();

            // index itself, is the value in the array, hence the naming.
            for (int numsInArray = 0; numsInArray <= data.GetUpperBound(0); numsInArray++)
            {
                // format and display each item in the array in the listbox
                theListBox.Items.Add(String.Format("[{0}] = {1}", numsInArray, data[numsInArray]));
            }
        }
        /// <summary>
        /// This routine will sort data using a bubble sort
        /// </summary>
        /// <param name="data"></param>
        public void BubbleSortFunction(int[] data)
        {
            // make n-1 passes through the array data
            for (int pass = 0; pass < data.GetUpperBound(0); pass++)
            {
                // for each pass compare adjacent values sarting from the left
                for (int index = 0; index < data.GetUpperBound(0) - pass; index++)
                {
                    // bubble the largest remaining item to the top (right) of the array
                    if (data[index] > data[index + 1])
                    {
                        Swap(data, index, index + 1);
                    }
                }
            }    
        }

        /// <summary>
        /// This method will swap the two items designated by the first and second index
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstIndex"></param>
        public void Swap(int[] data, int firstIndex, int secondIndex)
        {
            int temp;

            // swap the values using the temp node
            temp = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = temp;
        }

        #endregion methods

    }
}
