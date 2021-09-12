
namespace Curriculam
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridCourseList = new System.Windows.Forms.DataGridView();
            this.gridLecture = new System.Windows.Forms.DataGridView();
            this.gridCourse = new System.Windows.Forms.DataGridView();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lectureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campusDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campusDataSet1 = new Curriculam.campusDataSet();
            this.课程号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学分DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTableAdapter1 = new Curriculam.campusDataSetTableAdapters.CourseTableAdapter();
            this.courseListTableAdapter1 = new Curriculam.campusDataSetTableAdapters.CourseListTableAdapter();
            this.studentTableAdapter1 = new Curriculam.campusDataSetTableAdapters.StudentTableAdapter();
            this.开课号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.星期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上课地点DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开始周DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束周DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开始节DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束节DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timePeriodTableAdapter1 = new Curriculam.campusDataSetTableAdapters.TimePeriodTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLecture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridCourseList);
            this.groupBox1.Controls.Add(this.gridLecture);
            this.groupBox1.Controls.Add(this.gridCourse);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "可选开课列表";
            // 
            // gridCourseList
            // 
            this.gridCourseList.AllowUserToAddRows = false;
            this.gridCourseList.AllowUserToDeleteRows = false;
            this.gridCourseList.AutoGenerateColumns = false;
            this.gridCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lectureIDDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn});
            this.gridCourseList.DataMember = "CourseList";
            this.gridCourseList.DataSource = this.campusDataSet1BindingSource;
            this.gridCourseList.Location = new System.Drawing.Point(300, 24);
            this.gridCourseList.MultiSelect = false;
            this.gridCourseList.Name = "gridCourseList";
            this.gridCourseList.ReadOnly = true;
            this.gridCourseList.RowHeadersVisible = false;
            this.gridCourseList.RowHeadersWidth = 51;
            this.gridCourseList.RowTemplate.Height = 27;
            this.gridCourseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourseList.Size = new System.Drawing.Size(478, 178);
            this.gridCourseList.TabIndex = 1;
            this.gridCourseList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCourseList_CellMouseClick);
            // 
            // gridLecture
            // 
            this.gridLecture.AllowUserToAddRows = false;
            this.gridLecture.AllowUserToDeleteRows = false;
            this.gridLecture.AutoGenerateColumns = false;
            this.gridLecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLecture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.开课号DataGridViewTextBoxColumn,
            this.星期DataGridViewTextBoxColumn,
            this.上课地点DataGridViewTextBoxColumn,
            this.开始周DataGridViewTextBoxColumn,
            this.结束周DataGridViewTextBoxColumn,
            this.开始节DataGridViewTextBoxColumn,
            this.结束节DataGridViewTextBoxColumn});
            this.gridLecture.DataMember = "TimePeriod";
            this.gridLecture.DataSource = this.campusDataSet1BindingSource;
            this.gridLecture.Location = new System.Drawing.Point(300, 208);
            this.gridLecture.MultiSelect = false;
            this.gridLecture.Name = "gridLecture";
            this.gridLecture.ReadOnly = true;
            this.gridLecture.RowHeadersVisible = false;
            this.gridLecture.RowHeadersWidth = 51;
            this.gridLecture.RowTemplate.Height = 27;
            this.gridLecture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLecture.Size = new System.Drawing.Size(478, 184);
            this.gridLecture.TabIndex = 1;
            // 
            // gridCourse
            // 
            this.gridCourse.AllowUserToAddRows = false;
            this.gridCourse.AllowUserToDeleteRows = false;
            this.gridCourse.AllowUserToOrderColumns = true;
            this.gridCourse.AllowUserToResizeRows = false;
            this.gridCourse.AutoGenerateColumns = false;
            this.gridCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.课程号DataGridViewTextBoxColumn,
            this.课程名DataGridViewTextBoxColumn,
            this.学分DataGridViewTextBoxColumn});
            this.gridCourse.DataMember = "Course";
            this.gridCourse.DataSource = this.campusDataSet1BindingSource;
            this.gridCourse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCourse.Location = new System.Drawing.Point(16, 24);
            this.gridCourse.MultiSelect = false;
            this.gridCourse.Name = "gridCourse";
            this.gridCourse.ReadOnly = true;
            this.gridCourse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCourse.RowHeadersVisible = false;
            this.gridCourse.RowHeadersWidth = 10;
            this.gridCourse.RowTemplate.Height = 27;
            this.gridCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourse.Size = new System.Drawing.Size(278, 368);
            this.gridCourse.TabIndex = 0;
            this.gridCourse.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCourse_CellMouseClick);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(71, 19);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(125, 25);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.TextChanged += new System.EventHandler(this.studentIDTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "学生ID";
            // 
            // txtStudentName
            // 
            this.txtStudentName.AutoSize = true;
            this.txtStudentName.Location = new System.Drawing.Point(294, 22);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(63, 15);
            this.txtStudentName.TabIndex = 2;
            this.txtStudentName.Text = "invalid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "学生姓名";
            // 
            // lectureIDDataGridViewTextBoxColumn
            // 
            this.lectureIDDataGridViewTextBoxColumn.DataPropertyName = "LectureID";
            this.lectureIDDataGridViewTextBoxColumn.HeaderText = "开课号";
            this.lectureIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lectureIDDataGridViewTextBoxColumn.Name = "lectureIDDataGridViewTextBoxColumn";
            this.lectureIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lectureIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "课程名";
            this.courseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "主讲教师";
            this.teacherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            this.teacherNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "课程号";
            this.courseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // campusDataSet1BindingSource
            // 
            this.campusDataSet1BindingSource.DataSource = this.campusDataSet1;
            this.campusDataSet1BindingSource.Position = 0;
            // 
            // campusDataSet1
            // 
            this.campusDataSet1.DataSetName = "campusDataSet";
            this.campusDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 课程号DataGridViewTextBoxColumn
            // 
            this.课程号DataGridViewTextBoxColumn.DataPropertyName = "课程号";
            this.课程号DataGridViewTextBoxColumn.HeaderText = "课程号";
            this.课程号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.课程号DataGridViewTextBoxColumn.Name = "课程号DataGridViewTextBoxColumn";
            this.课程号DataGridViewTextBoxColumn.ReadOnly = true;
            this.课程号DataGridViewTextBoxColumn.Width = 65;
            // 
            // 课程名DataGridViewTextBoxColumn
            // 
            this.课程名DataGridViewTextBoxColumn.DataPropertyName = "课程名";
            this.课程名DataGridViewTextBoxColumn.HeaderText = "课程名";
            this.课程名DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.课程名DataGridViewTextBoxColumn.Name = "课程名DataGridViewTextBoxColumn";
            this.课程名DataGridViewTextBoxColumn.ReadOnly = true;
            this.课程名DataGridViewTextBoxColumn.Width = 125;
            // 
            // 学分DataGridViewTextBoxColumn
            // 
            this.学分DataGridViewTextBoxColumn.DataPropertyName = "学分";
            this.学分DataGridViewTextBoxColumn.HeaderText = "学分";
            this.学分DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.学分DataGridViewTextBoxColumn.Name = "学分DataGridViewTextBoxColumn";
            this.学分DataGridViewTextBoxColumn.ReadOnly = true;
            this.学分DataGridViewTextBoxColumn.Width = 40;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // courseListTableAdapter1
            // 
            this.courseListTableAdapter1.ClearBeforeFill = true;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // 开课号DataGridViewTextBoxColumn
            // 
            this.开课号DataGridViewTextBoxColumn.DataPropertyName = "开课号";
            this.开课号DataGridViewTextBoxColumn.HeaderText = "开课号";
            this.开课号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.开课号DataGridViewTextBoxColumn.Name = "开课号DataGridViewTextBoxColumn";
            this.开课号DataGridViewTextBoxColumn.ReadOnly = true;
            this.开课号DataGridViewTextBoxColumn.Width = 125;
            // 
            // 星期DataGridViewTextBoxColumn
            // 
            this.星期DataGridViewTextBoxColumn.DataPropertyName = "星期";
            this.星期DataGridViewTextBoxColumn.HeaderText = "星期";
            this.星期DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.星期DataGridViewTextBoxColumn.Name = "星期DataGridViewTextBoxColumn";
            this.星期DataGridViewTextBoxColumn.ReadOnly = true;
            this.星期DataGridViewTextBoxColumn.Width = 125;
            // 
            // 上课地点DataGridViewTextBoxColumn
            // 
            this.上课地点DataGridViewTextBoxColumn.DataPropertyName = "上课地点";
            this.上课地点DataGridViewTextBoxColumn.HeaderText = "上课地点";
            this.上课地点DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.上课地点DataGridViewTextBoxColumn.Name = "上课地点DataGridViewTextBoxColumn";
            this.上课地点DataGridViewTextBoxColumn.ReadOnly = true;
            this.上课地点DataGridViewTextBoxColumn.Width = 125;
            // 
            // 开始周DataGridViewTextBoxColumn
            // 
            this.开始周DataGridViewTextBoxColumn.DataPropertyName = "开始周";
            this.开始周DataGridViewTextBoxColumn.HeaderText = "开始周";
            this.开始周DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.开始周DataGridViewTextBoxColumn.Name = "开始周DataGridViewTextBoxColumn";
            this.开始周DataGridViewTextBoxColumn.ReadOnly = true;
            this.开始周DataGridViewTextBoxColumn.Width = 125;
            // 
            // 结束周DataGridViewTextBoxColumn
            // 
            this.结束周DataGridViewTextBoxColumn.DataPropertyName = "结束周";
            this.结束周DataGridViewTextBoxColumn.HeaderText = "结束周";
            this.结束周DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.结束周DataGridViewTextBoxColumn.Name = "结束周DataGridViewTextBoxColumn";
            this.结束周DataGridViewTextBoxColumn.ReadOnly = true;
            this.结束周DataGridViewTextBoxColumn.Width = 125;
            // 
            // 开始节DataGridViewTextBoxColumn
            // 
            this.开始节DataGridViewTextBoxColumn.DataPropertyName = "开始节";
            this.开始节DataGridViewTextBoxColumn.HeaderText = "开始节";
            this.开始节DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.开始节DataGridViewTextBoxColumn.Name = "开始节DataGridViewTextBoxColumn";
            this.开始节DataGridViewTextBoxColumn.ReadOnly = true;
            this.开始节DataGridViewTextBoxColumn.Width = 125;
            // 
            // 结束节DataGridViewTextBoxColumn
            // 
            this.结束节DataGridViewTextBoxColumn.DataPropertyName = "结束节";
            this.结束节DataGridViewTextBoxColumn.HeaderText = "结束节";
            this.结束节DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.结束节DataGridViewTextBoxColumn.Name = "结束节DataGridViewTextBoxColumn";
            this.结束节DataGridViewTextBoxColumn.ReadOnly = true;
            this.结束节DataGridViewTextBoxColumn.Width = 125;
            // 
            // timePeriodTableAdapter1
            // 
            this.timePeriodTableAdapter1.ClearBeforeFill = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 682);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "Curriculam 选课管理系统";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLecture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridCourse;
        private System.Windows.Forms.DataGridView gridLecture;
        private System.Windows.Forms.DataGridView gridCourseList;
        private System.Windows.Forms.BindingSource campusDataSet1BindingSource;
        private campusDataSet campusDataSet1;
        private campusDataSetTableAdapters.CourseTableAdapter courseTableAdapter1;
        private campusDataSetTableAdapters.CourseListTableAdapter courseListTableAdapter1;
        private campusDataSetTableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学分DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开课号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 星期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上课地点DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始周DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束周DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始节DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束节DataGridViewTextBoxColumn;
        private campusDataSetTableAdapters.TimePeriodTableAdapter timePeriodTableAdapter1;
    }
}

