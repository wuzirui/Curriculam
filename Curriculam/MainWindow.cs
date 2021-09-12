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
using System.Data.OleDb;

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
            grpSelect.Enabled = grpStatistic.Enabled = isValid;
            txtStudentID.Enabled = !isValid;
            if (isValid)
            {
                studentInit(sid);
            }
        }
        private void studentInit(int sid)
        {
            this.studentSelectedCourseListTableAdapter1.FillSelected(
                this.campusDataSet.StudentSelectedCourseList, sid.ToString());
            refreshAvailableCourse();
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

        private float minCredit = 8, maxCredit = 12;
        private int minCourse = 3, maxCourse = 5;
        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.courseTableAdapter1.Fill(this.campusDataSet.Course);
            courseUnselected();
            courseListUnselected();
            labelMinCredit.Text = minCredit.ToString();
            labelMaxCredit.Text = maxCredit.ToString();
            labelMinCourse.Text = minCourse.ToString();
            labelMaxCourse.Text = maxCourse.ToString();
        }

        private void courseSelected(int cid)
        {
            hasChosenCourse = true;
            chosenCID = cid;
            this.courseListTableAdapter1.FillBy(this.campusDataSet.CourseList, chosenCID);
            courseListUnselected();
        }

        private void courseUnselected()
        {
            hasChosenCourse = false;
            this.courseListTableAdapter1.Fill(this.campusDataSet.CourseList);
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
            this.timePeriodTableAdapter1.FillBy(this.campusDataSet.TimePeriod, 0);
            this.gridCourseList.ClearSelection();
        }

        private void courseListSelected(int clid)
        {
            hasChosenCourseList = true;
            chosenCLID = clid;
            this.timePeriodTableAdapter1.FillBy(this.campusDataSet.TimePeriod, chosenCLID);
        }

        private void btnDeleteCourseSelect_Click(object sender, EventArgs e)
        {
            if (gridSelected.SelectedRows.Count == 0)
            {
                MessageBox.Show("当前未选择课程", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 虽然使用循环来访问，但是其实限制了只能选中一个
            // 这样是为了避免选中的行中本身有冲突
            for (int i = 0; i < gridSelected.SelectedRows.Count; i++)
            {
                // 当前选中的行
                DataGridViewRow row = gridSelected.SelectedRows[i];
                int lid = int.Parse(row.Cells[0].Value.ToString());
                
                // 在Dataset中找到相应的位置
                var rrow = campusDataSet.StudentSelectedCourseList.FindByLectureID(lid);
                rrow.Delete();
            }
            refreshAvailableCourse();

        }

        private void btnAddCourseSelect_Click(object sender, EventArgs e)
        {
            if (gridAvailableCourseList.SelectedRows.Count == 0)
            {
                MessageBox.Show("当前未选择课程", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 虽然使用循环来访问，但是其实限制了只能选中一个
            // 这样是为了避免选中的行中本身有冲突
            for (int i = 0; i < gridAvailableCourseList.SelectedRows.Count; i++)
            {
                // 当前选中的行
                DataGridViewRow row = gridAvailableCourseList.SelectedRows[i];
                int lid = int.Parse(row.Cells[0].Value.ToString());
                
                // 在Dataset中找到相应的位置
                var rrow = campusDataSet.StudentAvailableCourseList.FindByLectureID(lid);

                // 添加到已选的课程中
                campusDataSet.StudentSelectedCourseList.AddStudentSelectedCourseListRow(rrow.LectureID, rrow.CourseName, 
                    rrow.Credit, rrow.TeacherName, campusDataSet.Course.FindBy课程号(rrow.CourseID), chosenSID);

            }
            refreshAvailableCourse();
        }

        private void btnSubmitCourseSelect_Click(object sender, EventArgs e)
        {
            this.studentSelectedCourseListTableAdapter1.Adapter
                .Update(campusDataSet);
        }

        private void refreshAvailableCourse()
        {
            int sid = chosenSID;
            this.studentAvailableCourseListTableAdapter1.FillAvailable(
                this.campusDataSet.StudentAvailableCourseList, sid.ToString());

            float totalCredit = 0;

            // 删去所有和现在课程冲突的课
            foreach (campusDataSet.StudentSelectedCourseListRow sel in campusDataSet.StudentSelectedCourseList.Rows)
            {
                if (sel.RowState == DataRowState.Deleted) continue;
                var cid = sel.CourseID;
                // 计算选中课程总学分
                totalCredit += sel.Credit;
                foreach(campusDataSet.StudentAvailableCourseListRow row in campusDataSet.StudentAvailableCourseList.Rows)
                {
                    if (row.RowState != DataRowState.Deleted && row.CourseID == cid)
                    {
                        row.Delete();
                    }
                }
            }

            int totalCourse = campusDataSet.StudentSelectedCourseList.Count;

            labelSelectedCredit.Text = totalCredit.ToString();
            labelSelectedCourse.Text = totalCourse.ToString();

            float epos = 0.0001f;
            if ( minCredit - epos <= totalCredit && totalCredit <= maxCredit + epos
                && minCourse <= totalCourse && totalCourse <= maxCourse)
            {
                label_CanSubmit.Text = "符合选课要求";
                label_CanSubmit.ForeColor = Color.YellowGreen;
                btnSubmitCourseSelect.Enabled = true;
            }
            else
            {
                label_CanSubmit.Text = "当前不符合选课要求";
                label_CanSubmit.ForeColor = Color.Maroon;
                btnSubmitCourseSelect.Enabled = false;
            }
        }

        private void btnClearCourseSelect_Click(object sender, EventArgs e)
        {
            campusDataSet.StudentSelectedCourseList.Clear();
            refreshAvailableCourse();
        }
    }
}
