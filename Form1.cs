/*******************************************************************************************
 *NAME: Ash Mahein    11463887                                                             *
 *DATE: 9/12/17                                                                            *
 *Assignment: 2                                                                            *
 *Description: Winform application that allows a user to see different storage and time    *
 *complexities of a hashset.                                                               *
 *                                                                                         *
 *Outside Sources: Youtube, StackOverflow.                                                 *
 *******************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace _321Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //random variable.
            Random rnd = new Random();

            //list for the numbers.
            List<int> numbers = new List<int>();

            //for loop to populate the list of randome numbers
            for (int i = 0; i < 10000; i++)
            {
                int num = rnd.Next(0, 20000);
                numbers.Add(num);
            }

            int total = 0;

            //Number 1.
            HashSet<int> hSet = new HashSet<int>(numbers);

            //Number 2.
            //Sorts the list and then removes all duplicates. BubbleSort takes O(n^2) time and then O(1) to count up items in the list.
            for(int i = 0; i < numbers.Count; i++)
            {
                for(int j = 0; j < (numbers.Count - 1); j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                    else if (numbers[j] == numbers[j + 1])
                    {
                        numbers.RemoveAt(j);
                    }
                }
            }
            foreach (int i in numbers)
            {
                total += 1;
            }

            //Number 3.
            numbers.Sort();
            HashSet<int> set = new HashSet<int>(numbers);

            int items = 0;
            for (int i = 0; i < set.Count; i++)
            {
                //sums up the number of items in the list.
                //O(n) because 
                items += 1;
            }

            //prints the output to the text box.
            textBox1.Text = "1. Hash Set Method: " + hSet.Count + " unqiue numbers." + Environment.NewLine + "The time complexity of this method is O(1). The HashSet has to traverse through the entire array to check for duplicates and get rid of them. Also for counting it needs to do the same thing. For searching and adding it is still and O(1) time complexity." + Environment.NewLine + "2. O(1) storage method: " + total + " unique numbers" + Environment.NewLine + "3. Sorted Method: " + items + " unique numbers.";
        }
    }
}
