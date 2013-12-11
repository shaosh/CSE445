//******************************************************************************************************************************
//Name: Shihuan Shao
//ASUID: 1203060451
//Assignment 1, Section 3, Question 3
//Description: A Windows Forms  Application for the service developed in the Question 1. It allows you to do conversion between Fahrenheit and 
//Celsius temperatures by consuming that the service.
//How to use: input an integer in either textbox, then click the Convert button, and you will get the corresponding 
//temperature in the other scale. 
//******************************************************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1_3.TempConvertRef;

namespace _1_3
{
    public partial class Form1 : Form
    {
        int focus = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c, f;
            TempConvertRef.ServiceClient tempConvert = new TempConvertRef.ServiceClient();//Create the proxy channel
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() == "")//When Celsius textbox is not empty and Fahrenheit textbox is empty, convert it to Fahrenheit
            {
                try
                {
                    c = Convert.ToInt32(textBox1.Text);
                    textBox2.Text = tempConvert.c2f(c).ToString();
                }
                catch
                {
                    MessageBox.Show("Please enter an integer!");
                }
            }
            else if (textBox1.Text.Trim() == "" && textBox2.Text.Trim() != "")//When Fahrenheit textbox is not empty and Celsius textbox is empty, convert it to Celsius
            {
                try
                {
                    f = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = tempConvert.f2c(f).ToString();
                }
                catch
                {
                    MessageBox.Show("Please enter an integer!");
                }
            }
            else if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")//When both textboxes are not empty, convert the latest input to the other scale
            {
                if (focus == 1)
                {
                    try
                    {
                        c = Convert.ToInt32(textBox1.Text);
                        textBox2.Text = tempConvert.c2f(c).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Please enter an integer!");
                    }
                }
                else if (focus == 2)
                {
                    try
                    {
                        f = Convert.ToInt32(textBox2.Text);
                        textBox1.Text = tempConvert.f2c(f).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Please enter an integer!");
                    }
                }
            }
            else
                MessageBox.Show("You must enter at least a temperature!");
        }

        //The following two functions are used to record which textbox has the latest input just before clicking the Convert button
        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            focus = 1;
            return;
        }

        private void textBox2_LostFocus(object sender, EventArgs e)
        {
            focus = 2;
            return;
        }
    }
}
