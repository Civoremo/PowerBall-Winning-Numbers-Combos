using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RandomNumberSGenerator
{
    public partial class MainForm1 : Form
    {
        public string numberSelected;
        public int buttonClicks;

        public MainForm1()
        {
            InitializeComponent();    
        } //end mainform1

        private void bGenerate_Click(object sender, EventArgs e)
        {
            _RandomNumberGenerator();
        } //end bGenrate_Click

        public void _RandomNumberGenerator()
        {
            int[] randomNumbers = new int[6];
            Random randomNum = new Random();

            for (int i = 0; i < randomNumbers.Count(); i++)
            {
                randomNumbers[i] = randomNum.Next(1, 69);
            } //end for(i)

            randomNumbers[randomNumbers.Count() - 1] = randomNum.Next(1, 25);

            for (int k = 0; k < randomNumbers.Count(); k++)
            {
                int temp;

                for (int u = randomNumbers.Count(); u >= 0; u--)
                {
                    if (u < 4 && randomNumbers[u] == randomNumbers[u + 1])
                    {
                        randomNumbers[u] = randomNum.Next(1, 69);
                    }

                    if (u < 4)
                    {
                        if (randomNumbers[u + 1] < randomNumbers[u])
                        {
                            temp = randomNumbers[u + 1];
                            randomNumbers[u + 1] = randomNumbers[u];
                            randomNumbers[u] = temp;
                        }
                    }
                } //end for(u)
            } // end for(k)

            textBox.Text = randomNumbers[0].ToString();
            textBox1.Text = randomNumbers[1].ToString();
            textBox2.Text = randomNumbers[2].ToString();
            textBox3.Text = randomNumbers[3].ToString();
            textBox4.Text = randomNumbers[4].ToString();
            textBox5.Text = randomNumbers[5].ToString();
        }

        private void pick1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);
            frm2.Text = "Pick Your Lucky Numbers";
            buttonClicks = 0;
            frm2.ShowDialog();
            frm2.FormBorderStyle = FormBorderStyle.FixedSingle;
        } //end pick1_Click

        private void bCombine_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
            _GenerateCombinations();
        } // end bCombine_Click

        public int[] aCombination = new int[5];

        public void _GenerateCombinations()
        {
            int one, six, temp;            
            bool[] active = new bool[8];
            Random random = new Random();

            for (int combination = 0; combination < 10; combination++)
            {                
                for(int j = 0; j  < 8; j++)
                {
                    active[j] = true;
                } //end for(j)

                for (int x = 0; x < 5; x++)
                {
                    temp = random.Next(0, 7);

                    while (active[temp] == false)
                    {
                        temp = random.Next(0, 7);
                    }

                    if (temp == 0 && active[0] == true)
                    {
                        one = Convert.ToInt16(textBox6.Text.ToString());
                        aCombination[x] = one;

                        active[0] = false;
                    }
                    else if (temp == 1 && active[1] == true)
                    {
                        one = Convert.ToInt16(textBox7.Text.ToString());
                        aCombination[x] = one;

                        active[1] = false;
                    }
                    else if (temp == 2 && active[2] == true)
                    {
                        one = Convert.ToInt16(textBox8.Text.ToString());
                        aCombination[x] = one;

                        active[2] = false;
                    }
                    else if (temp == 3 && active[3] == true)
                    {
                        one = Convert.ToInt16(textBox9.Text.ToString());
                        aCombination[x] = one;

                        active[3] = false;
                    }
                    else if (temp == 4 && active[4] == true)
                    {
                        one = Convert.ToInt16(textBox10.Text.ToString());
                        aCombination[x] = one;

                        active[4] = false;
                    }
                    else if (temp == 5 && active[5] == true)
                    {
                        one = Convert.ToInt16(textBox11.Text.ToString());
                        aCombination[x] = one;

                        active[5] = false;
                    }
                    else if (temp == 6 && active[6] == true)
                    {
                        one = Convert.ToInt16(textBox12.Text.ToString());
                        aCombination[x] = one;

                        active[6] = false;
                    }
                    else if (temp == 7 && active[7] == true)
                    {
                        one = Convert.ToInt16(textBox13.Text.ToString());
                        aCombination[x] = one;

                        active[7] = false;
                    }
                } //end for(x)

                six = random.Next(1, 25);
                _IntergerSortList(aCombination); //outside method
                displayTextBox.Text += "" + aCombination[0] + " - " + aCombination[1] + " - " + aCombination[2] + " - " + aCombination[3] + " - " + aCombination[4] + "        " + six + "\n";
            } //end for (combination)
        } //end generate combination

        private void _IntergerSortList(int[] list)
        {
            Random rand = new Random();
            int[] aList = list;

            for (int k = 0; k < aList.Count(); k++)
            {
                int temp;

                for (int u = aList.Count(); u >= 0; u--)
                {
                    if (u < 4 && aList[u] == aList[u + 1])
                    {
                        aList[u] = rand.Next(1, aList.Count());
                    }

                    if (u < 4)
                    {
                        if (aList[u + 1] < aList[u])
                        {
                            temp = aList[u + 1];
                            aList[u + 1] = aList[u];
                            aList[u] = temp;
                        }
                    }
                } //end for(u)
            } //end for(k)
        } //end sortEndList

        private void randomNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
    } //end mainform1
} //end namespace
