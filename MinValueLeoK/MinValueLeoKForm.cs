using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinValueLeoK
{
    public partial class frmMinValueLeoK : Form
    {
        public frmMinValueLeoK()
        {
            InitializeComponent();
        }

        private int GetMinValue(int[] arrayOfNumbers)
        {
            //variables
            int tmpMinValue = 101;

            //loop through the  array and find the min value
            foreach (int tmpNumber in arrayOfNumbers)
            {
                if (tmpNumber < tmpMinValue)
                {
                    tmpMinValue = tmpNumber;
                }
            }

            return tmpMinValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //variables
            const int MAX_ARRAY_SIZE = 10;
            const int MIN_VALUE = -100;
            const int MAX_VALUE = 100;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNum, minValue;
            Random randomNumberGenerator = new Random();

            //clear the listbox items
            this.lstNumbers.Items.Clear();

            //generate the random numbers and assign them to different positions in the array
            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                //generate a random number
                randomNum = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE);

                //assign the number to the array
                arrayOfIntegers[counter] = randomNum;

                //add the number to the listbox
                this.lstNumbers.Items.Add(randomNum);

                //refresh the form
                this.Refresh();
            }

            //get the min value by calling the GetMinValue funtion
            minValue = GetMinValue(arrayOfIntegers);

            //display the min value
            this.lblAnswer.Text = "The min value is " + minValue;
        }
    }
}
