using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAPID_TEST_2
{
    public partial class Form1 : Form
    {
        List<string> itemsList = new List<string>();

        private int[] hourlyValues = new int[24];

        public Form1()
        {
            InitializeComponent();
            Random rand = new Random();
            for (int i = 0; i < hourlyValues.Length; i++)
            {
                hourlyValues[i] = rand.Next(10, 100);
            }

            // Convert the array of integers to an array of objects
            object[] hourlyValuesAsObjects = hourlyValues.Cast<object>().ToArray();

            // Add the array elements to the list box
            foreach (int value in hourlyValues)
            {
                lstBox.Items.Add(value.ToString());
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This part of the code is for the sort button
            lstBox.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // This part of the code is for the Binary search button
            {
                //BINARY SEARCH
                List<string> itemsList = new List<string>();
                foreach (String item in lstBox.Items)
                {
                    itemsList.Add(item.ToString());
                }

                var key = BinaryTxtBox.Text;


                var index = itemsList.BinarySearch(key);
                //if item found display message below:
                if (index >= 0)
                {
                    MessageBox.Show("Success; Item found at [" + index + "] ");
                }
                else
                {
                    MessageBox.Show("Search did not find the value", "Not Found");
                    BinaryTxtBox.Text = "";
                    BinaryTxtBox.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SEQUENTIAL SEARCH
            List<string> list = new List<string>();
            foreach (var items in lstBox.Items)
            {
                list.Add(items.ToString());
            }
            var key = SequentialTxtBox.Text;
            var index = lstBox.Items.IndexOf(key);
            if (index >= 0)
            {

                MessageBox.Show("Success; Item found", "Found Message");
            }

            // if (txtBox.Text == "")
            else
            {
                MessageBox.Show("Item not found");
            }
            //after item found the textbox search will be clear and refocused on
            SequentialTxtBox.Clear();
            SequentialTxtBox.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Check if an item is selected and the text box is not empty
            if (lstBox.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(EditTxtBox.Text))
            {
                int selectedInt = lstBox.SelectedIndex;
                string newItem = EditTxtBox.Text;

                // Remove the current item at the selected index
                lstBox.Items.RemoveAt(selectedInt);

                // Insert the new item at the selected index
                lstBox.Items.Insert(selectedInt, newItem);

                // Check if the index is valid before inserting into the list
                if (selectedInt + 1 < itemsList.Count)
                {
                    // Insert the new item at the corresponding index in the list
                    itemsList.Insert(selectedInt + 1, newItem);
                }

                // Clear and then refocus the text box
                EditTxtBox.Clear();
                EditTxtBox.Focus();

                // Sort list and ListBox
                itemsList.Sort();
                lstBox.Sorted = true;

                MessageBox.Show("Item has been updated/edited!", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please select an item and enter a new value, textbox is empty.", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //Average

            double average = hourlyValues.Average();
            MessageBox.Show("Average: " + average, "Average");
            AvgTxt.Text = average.ToString();
        }

        private void btnMidExtreme_Click(object sender, EventArgs e)
        {
            double lowMidExtreme = hourlyValues.Min();

            double highMidExtreme = hourlyValues.Max();

            double midExtreme = (highMidExtreme - lowMidExtreme) / 2;

            MessageBox.Show("Mid-Extreme: " + midExtreme);

            midExTxt.Text = midExtreme.ToString();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            // Mode

            List<int> x = lstBox.Items.Cast<string>().Select(int.Parse).ToList();

            Dictionary<int, int> itemsList = new Dictionary<int, int>();

            foreach (int a in x)
            {
                if (itemsList.ContainsKey(a))
                    itemsList[a] = itemsList[a] + 1;
                else
                {
                    itemsList[a] = 1;
                }
            }

            int max = itemsList.Values.Max();
            List<int> modes = new List<int>();

            foreach (var item in itemsList)
            {
                if (item.Value == max)
                    modes.Add(item.Key);
            }
            MessageBox.Show("Mode(s)" + string.Join(", ", modes));

            string messageBoxText = (string.Join(", ", modes));
            modeTxt.Text = messageBoxText;

           




        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            // Range
            
            double rangeLowest = hourlyValues.Min();

            double rangeHighest = hourlyValues.Max();

            double range = (rangeHighest - rangeLowest);

            MessageBox.Show("Range: " + range);

            RangeTxt.Text = range.ToString();


        }

        private void midExTxt_TextChanged(object sender, EventArgs e)
        {
            midExTxt.Text = midExTxt.Text.Trim();
        }
    }
}
