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

        private void studentChanged(bool isValid, int sid = 0)
        {
            
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
                    studentChanged(false);
                }
                txtStudentName.Text = name;
                studentChanged(true, id);
            }
            txtStudentName.Text = "Invalid";
            studentChanged(false);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“campusDataSet1.AvailableCourseList”中。您可以根据需要移动或删除它。
            this.courseTableAdapter1.Fill(this.campusDataSet.Course);
            this.courseListTableAdapter1.Fill(this.campusDataSet.CourseList);
        }

        private void gridCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int cid = int.Parse(gridCourse.Rows[index].Cells[0].Value.ToString());
            courseSelected(cid);
        }

        private void courseSelected(int cid)
        {
            this.courseListTableAdapter1.FillBy(this.campusDataSet.CourseList, cid);
        }
    }
}
