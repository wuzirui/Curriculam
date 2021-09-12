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

        private bool hasChosenStudent = false;
        private int chosenSID = -1;
        private void studentChanged(bool isValid, int sid = 0)
        {
            hasChosenStudent = isValid;
            chosenSID = sid;
        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            int id = isValidIntegerStr(txtStudentID.Text) ? int.Parse(txtStudentID.Text) : 0;
            if (id != 0)
            {
                string name = this.studentTableAdapter1.QueryStudentName(id);
                if (name == null)
                {
                    name = "Not Found";
                    studentChanged(false);
                }
                else
                {
                    studentChanged(true, id);
                }
                txtStudentName.Text = name;
            }
            else
            {
                txtStudentName.Text = "Invalid";
                studentChanged(false);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.courseTableAdapter1.Fill(this.campusDataSet1.Course);
            courseUnselected();
            courseListUnselected();
        }

        private void courseSelected(int cid)
        {
            hasChosenCourse = true;
            chosenCID = cid;
            this.courseListTableAdapter1.FillBy(this.campusDataSet1.CourseList, chosenCID);
            courseListUnselected();
        }

        private void courseUnselected()
        {
            hasChosenCourse = false;
            this.courseListTableAdapter1.Fill(this.campusDataSet1.CourseList);
            this.gridCourse.ClearSelection();
            courseListUnselected();
        }

        private bool hasChosenCourse = false;
        private int  chosenCID = -1;
        private void gridCourse_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            int cid = int.Parse(gridCourse.Rows[index].Cells[0].Value.ToString());
            if (hasChosenCourse && chosenCID == cid)
            {
                courseUnselected();
            }
            else
            {
                courseSelected(cid);
            }
        }

        private bool hasChosenCourseList = false;
        private int chosenCLID = -1;
        private void gridCourseList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            int clid = int.Parse(gridCourseList.Rows[index].Cells[0].Value.ToString());
            if (hasChosenCourseList && chosenCLID == clid)
            {
                chosenCLID = -1;
                courseListUnselected();
            }
            else
            {
                courseListSelected(clid);
            }
        }

        private void courseListUnselected()
        {
            hasChosenCourseList = false;
            this.timePeriodTableAdapter1.FillBy(this.campusDataSet1.TimePeriod, 0);
            this.gridCourseList.ClearSelection();
        }

        private void courseListSelected(int clid)
        {
            hasChosenCourseList = true;
            chosenCLID = clid;
            this.timePeriodTableAdapter1.FillBy(this.campusDataSet1.TimePeriod, chosenCLID);
        }
    }
}
