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
    public partial class Form2 : Form
    {
        MainForm1 form1;

        public Form2(Form mainFrm)
        {
            InitializeComponent();
            form1 = (MainForm1)mainFrm;            
            _ButtonGridGenerator();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (form1.buttonClicks == 0)
            {
                form1.textBox6.Text = clickedButton.Text.ToString();
                clickedButton.Enabled = false;
                clickedButton.BackColor = Color.ForestGreen;
            }
            else if (form1.buttonClicks == 1)
            {
                form1.textBox7.Text = clickedButton.Text.ToString();
                clickedButton.Enabled = false;
                clickedButton.BackColor = Color.ForestGreen;
            }
            else if (form1.buttonClicks == 2)
            {
                form1.textBox8.Text = clickedButton.Text.ToString();
                clickedButton.Enabled = false;
                clickedButton.BackColor = Color.ForestGreen;
            }
            else if (form1.buttonClicks == 3)
            {
                form1.textBox9.Text = clickedButton.Text.ToString();
                clickedButton.Enabled = false;
                clickedButton.BackColor = Color.ForestGreen;
            }
            else if (form1.buttonClicks == 4)
            {
                form1.textBox10.Text = clickedButton.Text.ToString();
                clickedButton.Enabled = false;
                clickedButton.BackColor = Color.ForestGreen;
            }
            else if (form1.buttonClicks == 5)
            {
                form1.textBox11.Text = clickedButton.Text.ToString();
                clickedButton.Enabled = false;
                clickedButton.BackColor = Color.ForestGreen;
            }
            else if (form1.buttonClicks == 6)
            {
                form1.textBox12.Text = clickedButton.Text.ToString();
                clickedButton.Enabled = false;
                clickedButton.BackColor = Color.ForestGreen;
            }
            else if (form1.buttonClicks == 7)
            {
                form1.textBox13.Text = clickedButton.Text.ToString();
                clickedButton.Enabled = false;
                clickedButton.BackColor = Color.ForestGreen;
            }

            form1.buttonClicks++;

            if(form1.buttonClicks == 8)
            {
                this.Close();
            } 
        } //end bt_click

        string buttonText;

        public void _ButtonGridGenerator()
        {
            ArrayList alButtonLocationY = new ArrayList();
            ArrayList alButtonLocationX = new ArrayList();

            Point buttonLocation = new Point(7, 55);
            Point buttonOrigin = new Point(7, 55);

            int t = 1;
            bool done = false;

            if (done == false)
            {
                for (int d = 0; d < 69; d++)
                {
                    alButtonLocationX.Add(buttonLocation.X);
                    alButtonLocationY.Add(buttonLocation.Y);
                    buttonLocation.X += 30;

                    if (d == 8 || d == 17 || d == 26 || d == 35 || d == 44 || d == 53 || d == 62)
                    {
                        Point temp = new Point((int)alButtonLocationX[d], (int)alButtonLocationY[d]);

                        buttonLocation.X = 7;
                        buttonLocation.Y += 25;
                        Button button = new Button();
                        button.Text = "" + (t); t++;
                        buttonText = button.Text.ToString();
                        button.Click += bt_Click;
                        button.Size = new Size(30, 25);
                        button.Location = temp;
                        Controls.Add(button);
                    } //end if
                    else
                    {
                        Point temp = new Point((int)alButtonLocationX[d], (int)alButtonLocationY[d]);

                        Button button = new Button();
                        button.Text = "" + (t); t++;
                        buttonText = button.Text.ToString();
                        button.Click += bt_Click;
                        button.Size = new Size(30, 25);
                        button.Location = temp;
                        Controls.Add(button);
                    }//end else
                } // end for(d)
            } //end if

            done = true; //change bool(done)

        } //end ButtonGridGenerator
    }
}
