using StudentGradesApp.StudentGradesDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            string username = tb_user.Text;
            string number = tb_identification.Text;
            string pin = tb_pin.Text;


            StudentGradesDataSet.StudentsDataTable aaaaa = new StudentGradesDataSet.StudentsDataTable();
            StudentsTableAdapter bbbbb = new StudentsTableAdapter();
            bbbbb.Fill(aaaaa);

            foreach (StudentGradesDataSet.StudentsRow row in aaaaa.Rows)
            {
                if (row.IdentificationNumber.ToString() == number && row.Pin.ToString() == pin && row.Username.ToString() == username)
                {
                    MessageBox.Show("Login Successful");
                    Form form = new Overview();
                    /*Form1.ActiveForm.Close();*/
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    tb_identification.Clear();
                    tb_pin.Clear();
                    break;
                }
            }
        }
    }
}
