﻿namespace Sportivex
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(255, 42);
            panel1.MinimumSize = new Size(200, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 481);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(206, 399);
            button2.Name = "button2";
            button2.Size = new Size(73, 28);
            button2.TabIndex = 4;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(86, 330);
            button1.Name = "button1";
            button1.Size = new Size(178, 43);
            button1.TabIndex = 4;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.Location = new Point(46, 164);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 250);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 403);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 3;
            label1.Text = "Don't have an account?";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox2.Location = new Point(46, 271);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.PasswordChar = '*';
            maskedTextBox2.Size = new Size(262, 34);
            maskedTextBox2.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(46, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 34);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(86, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 95);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 589);
            Controls.Add(panel1);
            Name = "SignIn";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}