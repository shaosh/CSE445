//******************************************************************************************************************************
//Name: Shihuan Shao
//ASUID: 1203060451
//Assignment 1, Section 3, Question 5, 6, 7
//Description: A web  browser  that  can  take  any URL and display the content of the page in the upper part of the window; a WCF client which 
//encrypt a string and at the same time decrypt the encrypted string for validation; a WCF client which generate random strings.
//How to use: for the web brower, enter the address into the textbox at the top and click button Go;
//                      for the encryption client, enter your string and click the button Encrypt, the readOnly textboxes will show you the encrypted result
//                      and at the same time decrypt the resulted string;
//                      for the random string client, click button Random I, you will get a random string with length from 4 to 20; enter an positive integer
//                      in the textbox and click the button Random II, you will see the a random string with the length you just entered in the textbox.
//WSDL address: http://venus.eas.asu.edu/WSRepository/Services/EncryptionWcf/Service.svc?wsdl for encryption
//                           http://venus.eas.asu.edu/WSRepository/Services/RandomStringSvc/Service.svc?wsdl for random string 
//******************************************************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1_5.EncryptDecryptRef;

namespace _1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);      //go to the target address
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxEncrypt.Text.Trim() != "")
            {
                EncryptDecryptRef.ServiceClient encrypt = new EncryptDecryptRef.ServiceClient();
                textBoxEncrypted.Text = encrypt.Encrypt(textBoxEncrypt.Text);   //Encrypt the target string and generate the resulted string
                textBoxDecrypt.Text = textBoxEncrypted.Text;
                textBoxDecrypted.Text = encrypt.Decrypt(textBoxDecrypt.Text);   //Decrypt the resulted string for validation
                encrypt.Close();
            }
            else
                MessageBox.Show("Please enter a string to encrypt!");
        }

        private void btn4to20Char_Click(object sender, EventArgs e)     //Generate a random string with length 4 - 20
        {
            RandomStringRef.ServiceClient randomStr = new RandomStringRef.ServiceClient();
            random1Label.Text = randomStr.GetRandomString0();
            randomStr.Close();
        }

        private void btnFixLength_Click(object sender, EventArgs e)      //Generate a random string with given length
        {
            if (textBoxLength.Text.Trim() != "")
            {
                try
                {
                    int length = Convert.ToInt32(textBoxLength.Text);
                    if (length > 0)
                    {
                        RandomStringRef.ServiceClient randomStr = new RandomStringRef.ServiceClient();
                        textBoxRandom.Text = randomStr.GetRandomString(textBoxLength.Text);
                        randomStr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a positive integer!");
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a positive integer!");
                }
            }
            else
                MessageBox.Show("Please enter a positive integer!");            
        }     
    }
}
