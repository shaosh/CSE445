namespace _1_5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDecrypt = new System.Windows.Forms.TextBox();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEncrypt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.random1Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFixLength = new System.Windows.Forms.Button();
            this.btn4to20Char = new System.Windows.Forms.Button();
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 30);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(693, 286);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(621, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 21);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(3, 5);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(612, 21);
            this.txtURL.TabIndex = 2;
            this.txtURL.Text = "http://";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 320);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEncrypt);
            this.panel2.Controls.Add(this.textBoxDecrypted);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxDecrypt);
            this.panel2.Controls.Add(this.textBoxEncrypted);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxEncrypt);
            this.panel2.Location = new System.Drawing.Point(2, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 272);
            this.panel2.TabIndex = 4;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(280, 34);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(59, 21);
            this.btnEncrypt.TabIndex = 13;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Location = new System.Drawing.Point(11, 223);
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.ReadOnly = true;
            this.textBoxDecrypted.Size = new System.Drawing.Size(264, 21);
            this.textBoxDecrypted.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Decrypted string:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "String to decrypt:";
            // 
            // textBoxDecrypt
            // 
            this.textBoxDecrypt.Location = new System.Drawing.Point(11, 162);
            this.textBoxDecrypt.Name = "textBoxDecrypt";
            this.textBoxDecrypt.ReadOnly = true;
            this.textBoxDecrypt.Size = new System.Drawing.Size(264, 21);
            this.textBoxDecrypt.TabIndex = 9;
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Location = new System.Drawing.Point(10, 95);
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.ReadOnly = true;
            this.textBoxEncrypted.Size = new System.Drawing.Size(264, 21);
            this.textBoxEncrypted.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Encrypted string:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter a string for encryption:";
            // 
            // textBoxEncrypt
            // 
            this.textBoxEncrypt.Location = new System.Drawing.Point(10, 34);
            this.textBoxEncrypt.Name = "textBoxEncrypt";
            this.textBoxEncrypt.Size = new System.Drawing.Size(264, 21);
            this.textBoxEncrypt.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxRandom);
            this.panel3.Controls.Add(this.random1Label);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxLength);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnFixLength);
            this.panel3.Controls.Add(this.btn4to20Char);
            this.panel3.Location = new System.Drawing.Point(355, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 272);
            this.panel3.TabIndex = 5;
            // 
            // random1Label
            // 
            this.random1Label.AutoSize = true;
            this.random1Label.Location = new System.Drawing.Point(143, 38);
            this.random1Label.Name = "random1Label";
            this.random1Label.Size = new System.Drawing.Size(161, 12);
            this.random1Label.TabIndex = 8;
            this.random1Label.Text = "Result string for Random I";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Expected Length:";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(153, 95);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(39, 21);
            this.textBoxLength.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Generate a random string with given length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Generate a random string with 4 - 20 chars";
            // 
            // btnFixLength
            // 
            this.btnFixLength.Location = new System.Drawing.Point(211, 93);
            this.btnFixLength.Name = "btnFixLength";
            this.btnFixLength.Size = new System.Drawing.Size(81, 21);
            this.btnFixLength.TabIndex = 1;
            this.btnFixLength.Text = "Random II";
            this.btnFixLength.UseVisualStyleBackColor = true;
            this.btnFixLength.Click += new System.EventHandler(this.btnFixLength_Click);
            // 
            // btn4to20Char
            // 
            this.btn4to20Char.Location = new System.Drawing.Point(48, 34);
            this.btn4to20Char.Name = "btn4to20Char";
            this.btn4to20Char.Size = new System.Drawing.Size(81, 21);
            this.btn4to20Char.TabIndex = 0;
            this.btn4to20Char.Text = "Random I";
            this.btn4to20Char.UseVisualStyleBackColor = true;
            this.btn4to20Char.Click += new System.EventHandler(this.btn4to20Char_Click);
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Location = new System.Drawing.Point(46, 129);
            this.textBoxRandom.Multiline = true;
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRandom.Size = new System.Drawing.Size(257, 126);
            this.textBoxRandom.TabIndex = 9;
            this.textBoxRandom.Text = "Result string for Randome II";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Shihuan Shao\'s Browser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEncrypt;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDecrypt;
        private System.Windows.Forms.Button btn4to20Char;
        private System.Windows.Forms.Button btnFixLength;
        private System.Windows.Forms.Label random1Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRandom;

    }
}

