﻿namespace StudentGradesApp
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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.tb_identification = new System.Windows.Forms.TextBox();
            this.tb_pin = new System.Windows.Forms.TextBox();
            this.lbl_pin = new System.Windows.Forms.Label();
            this.bttn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(238, 148);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(278, 20);
            this.tb_user.TabIndex = 0;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(235, 132);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(55, 13);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "Username";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(235, 175);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(105, 13);
            this.lbl_number.TabIndex = 2;
            this.lbl_number.Text = "Identification number";
            // 
            // tb_identification
            // 
            this.tb_identification.Location = new System.Drawing.Point(238, 191);
            this.tb_identification.Name = "tb_identification";
            this.tb_identification.Size = new System.Drawing.Size(278, 20);
            this.tb_identification.TabIndex = 3;
            // 
            // tb_pin
            // 
            this.tb_pin.Location = new System.Drawing.Point(238, 232);
            this.tb_pin.Name = "tb_pin";
            this.tb_pin.Size = new System.Drawing.Size(278, 20);
            this.tb_pin.TabIndex = 5;
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.Location = new System.Drawing.Point(235, 216);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(22, 13);
            this.lbl_pin.TabIndex = 4;
            this.lbl_pin.Text = "Pin";
            // 
            // bttn_login
            // 
            this.bttn_login.Location = new System.Drawing.Point(238, 259);
            this.bttn_login.Name = "bttn_login";
            this.bttn_login.Size = new System.Drawing.Size(278, 23);
            this.bttn_login.TabIndex = 6;
            this.bttn_login.Text = "Check details and login";
            this.bttn_login.UseVisualStyleBackColor = true;
            this.bttn_login.Click += new System.EventHandler(this.bttn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Grades App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_login);
            this.Controls.Add(this.tb_pin);
            this.Controls.Add(this.lbl_pin);
            this.Controls.Add(this.tb_identification);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.tb_user);
            this.Name = "Form1";
            this.Text = "Student Grades App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.TextBox tb_identification;
        private System.Windows.Forms.TextBox tb_pin;
        private System.Windows.Forms.Label lbl_pin;
        private System.Windows.Forms.Button bttn_login;
        private System.Windows.Forms.Label label1;
    }
}

