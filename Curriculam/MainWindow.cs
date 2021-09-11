using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Curriculam
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool isValidIntegerStr(string str)
        {
            return Regex.IsMatch(str, "^[0-9]+$");
        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            int id = isValidIntegerStr(txtStudentID.Text) ? int.Parse(txtStudentID.Text) : 0;
            if (id != 0)
            {
                string name = this.studentTableAdapter.QueryStudentName(id);
                if (name == null)
                {
                    name = "Not Found";
                }
                txtStudentName.Text = name;
            }
            else
            {
                txtStudentName.Text = "Invalid";
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.courseTableAdapter1.Fill(this.campusDataSet.Course);
            
        }
    }
}
