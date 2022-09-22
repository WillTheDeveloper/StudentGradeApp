using StudentGradesApp.StudentGradesDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradesApp
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Overview_Load(object sender, EventArgs e)
        {
            // Add data from data source to the table
            StudentGradesDataSet.StudentsDataTable aaaaa = new StudentGradesDataSet.StudentsDataTable();
            StudentsTableAdapter bbbbb = new StudentsTableAdapter();
            bbbbb.Fill(aaaaa);

            // Add data from data source to the list view
            foreach (StudentGradesDataSet.StudentsRow row in aaaaa.Rows)
            {
                ListViewItem item = new ListViewItem(row.IdentificationNumber.ToString());
                item.SubItems.Add(row.Username.ToString());
                item.SubItems.Add(row.Pin.ToString());
               /* item.SubItems.Add(row.Grade.ToString());*/
                listView1.Items.Add(item);
            }
        }
    }
}
