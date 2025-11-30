using System;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Name: Rory Hughes
         * Date: November 28, 2025
         * This program rolls one dice or calculates mark stats.
         * Link to your repo in GitHub: https://github.com/Rory-Hughes/ProgLab5
         * */

        //class-level random object
        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //select one roll radiobutton
            radOneRoll.Checked = true;
            //add your name to end of form title
            string currentTitle = this.Text;
            this.Text = currentTitle + " - Rory Hughes";
            //end form load
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call the function
            ClearOneRoll();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //call the function
            ClearStats();

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int dice1, dice2;
            //call method RollDice, placing returned number into integers
            dice1 = RollDice();
            dice2 = RollDice();

            //place integers into labels
            lblDice1.Text = dice1.ToString();
            lblDice2.Text = dice2.ToString();
            // call method GetName sending total and returning named
            int total = dice1 + dice2;
            string name = GetName(total);

            //display name in label
            lblRollName.Text = name;
        }

        /* Name: ClearOneRoll
        *  Sent: nothing
        *  Return: nothing
        *  Clear the labels */
        private void ClearOneRoll()
        {
            lblDice1.ResetText();
            lblDice2.ResetText();
            lblRollName.ResetText();
        }


        /* Name: ClearStats
        *  Sent: nothing
        *  Return: nothing
        *  Reset nud to minimum value, chkbox unselected, 
        *  clear labels and listbox */
        private void ClearStats()
        {
            nudNumber.Value = nudNumber.Minimum;
            chkSeed.Checked = false;
            lblAverage.ResetText();
            lblPass.ResetText();
            lblFail.ResetText();
            lstMarks.Items.Clear();
        }



        /* Name: RollDice
        * Sent: nothing
        * Return: integer (1-6)
        * Simulates rolling one dice */
        private int RollDice()
        {
            return rand.Next(1, 7);
        }


        /* Name: GetName
        * Sent: 1 integer (total of dice1 and dice2) 
        * Return: string (name associated with total) 
        * Finds the name of dice roll based on total.
        * Use a switch statement with one return only
        * Names: 2 = Snake Eyes
        *        3 = Litle Joe
        *        5 = Fever
        *        7 = Most Common
        *        9 = Center Field
        *        11 = Yo-leven
        *        12 = Boxcars
        * Anything else = No special name*/
        private string GetName(int total)
        {
            string name;
            switch (total)
            {
                case 2:
                    name = "Snake Eyes";
                    break;
                case 3:
                    name = "Little Joe";
                    break;
                case 5:
                    name = "Fever";
                    break;
                case 7:
                    name = "Most Common";
                    break;
                case 9:
                    name = "Center Field";
                    break;
                case 11:
                    name = "Yo-leven";
                    break;
                case 12:
                    name = "Boxcars";
                    break;
                default:
                    name = "No special name";
                    break;
            }
            return name;
        }

        private void btnSwapNumbers_Click(object sender, EventArgs e)
        {
            string roll1, roll2;
            //get data from labels into strings
            roll1 = lblDice1.Text;
            roll2 = lblDice2.Text;
            //call method DataPresent twice sending string returning boolean
            bool dataInRoll1 = DataPresent(roll1);
            bool dataInRoll2 = DataPresent(roll2);
            //if data present in both labels, call SwapData sending both strings
            if (dataInRoll1 && dataInRoll2)
            {
                SwapData(ref roll1, ref roll2);
                //put data back into labels
                lblDice1.Text = roll1;
                lblDice2.Text = roll2;
            }
            //if data not present in either label display error msg
            else
            {
                MessageBox.Show("Roll the dice!", "Data Missing");
            }
        }

        /* Name: DataPresent
        * Sent: string
        * Return: bool (true if data, false if not) 
        * See if string is empty or not*/
        private bool DataPresent(string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }


        /* Name: SwapData
        * Sent: 2 strings
        * Return: none 
        * Swaps the memory locations of two strings*/
        private void SwapData(ref string roll1, ref string roll2)
        {
            //Use a temporary variable to hold the value of the first string.
            string temp = roll1;

            //Assign the value of the second string to the first string.
            roll1 = roll2;

            //Assign the original value of the first string (stored in temp) to the second string.
            roll2 = temp;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //declare variables and array
            int passCount, failCount;
            double average;
            int arraySize = (int)nudNumber.Value;
            int[] marksArray = new int[arraySize];

            //Check if the seed value is selected
            if (chkSeed.Checked)
            {
                // Reinitialize the static random object using a seed value of 1000
                // Re-creating the object ensures the sequence repeats exactly.
                rand = new Random(1000);
            }

            //Clear the listbox.
            lstMarks.Items.Clear();


            //fill array using random numbers
            int i = 0;

            while (i < arraySize)
            {
                // Random.Next(minValue, maxValue) returns a random integer 
                int mark = rand.Next(40, 101);

                marksArray[i] = mark;
                lstMarks.Items.Add($"{mark}");
                i++;
            }

            //call CalcStats sending and returning data
            average = CalcStats(marksArray, out passCount, out failCount);
            //display data sent back in labels - average, pass and fail
            //Format average always showing 2 decimal places 
            lblAverage.Text = average.ToString("F2");
            lblPass.Text = passCount.ToString();
            lblFail.Text = failCount.ToString();
            

        } // end Generate click

        private void radOneRoll_CheckedChanged(object sender, EventArgs e)
        {
            grpMarkStats.Hide();
            grpOneRoll.Show();
            ClearOneRoll();
        }

        private void radRollStats_CheckedChanged(object sender, EventArgs e)
        {
            grpMarkStats.Show();
            grpOneRoll.Hide();
            ClearStats();
        }

        private void chkSeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeed.Checked)
            {
                DialogResult result = MessageBox.Show("Are you sure you want a seed value?", "Confirm Seed Value", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    chkSeed.Checked = false;
                }
            }
        }


        /* Name: CalcStats
        * Sent: array and 2 integers
        * Return: average (double) 
        * Run a foreach loop through the array.
        * Passmark is 60%
        * Calculate average and count how many marks pass and fail
        * The pass and fail values must also get returned for display*/
        private double CalcStats(int[] marksArray, out int passCount, out int failCount)
        {
            double total = 0;
            passCount = 0;
            failCount = 0;
            foreach (int mark in marksArray)
            {
                total += mark;
                if (mark >= 60)
                {
                    passCount++;
                }
                else
                {
                    failCount++;
                }
            }
            return total / (double)marksArray.Length;
        }
    }
}
