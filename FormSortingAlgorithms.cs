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
        #endregion data


        public FormSortingAlgorithms()
        {
            InitializeComponent();
        }

        #region events
        private void buttonBubbleInLine_Click(object sender, EventArgs e)
        {
            DisplayData(valueArray, listBoxPreSort);
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
        #endregion methods
    }
}
