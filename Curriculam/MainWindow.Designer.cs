
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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.campusDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campusDataSet1 = new Curriculam.campusDataSet();
            this.courseTableAdapter1 = new Curriculam.campusDataSetTableAdapters.CourseTableAdapter();
            this.courseListTableAdapter1 = new Curriculam.campusDataSetTableAdapters.CourseListTableAdapter();
            this.studentTableAdapter1 = new Curriculam.campusDataSetTableAdapters.StudentTableAdapter();
            this.timePeriodTableAdapter1 = new Curriculam.campusDataSetTableAdapters.TimePeriodTableAdapter();
            this.grpStatistic = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridCourseList = new System.Windows.Forms.DataGridView();
            this.lectureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLecture = new System.Windows.Forms.DataGridView();
            this.上课地点DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开始周DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束周DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.星期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开始节DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束节DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开课号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCourse = new System.Windows.Forms.DataGridView();
            this.课程号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学分DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAddCourseSelect = new System.Windows.Forms.Button();
            this.btnDeleteCourseSelect = new System.Windows.Forms.Button();
            this.btnClearCourseSelect = new System.Windows.Forms.Button();
            this.btnSubmitCourseSelect = new System.Windows.Forms.Button();
            this.label_CanSubmit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSet1)).BeginInit();
            this.grpStatistic.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLecture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            this.grpSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            // timePeriodTableAdapter1
            // 
            this.timePeriodTableAdapter1.ClearBeforeFill = true;
            // 
            // grpStatistic
            // 
            this.grpStatistic.Controls.Add(this.label_CanSubmit);
            this.grpStatistic.Controls.Add(this.label17);
            this.grpStatistic.Controls.Add(this.label9);
            this.grpStatistic.Controls.Add(this.label16);
            this.grpStatistic.Controls.Add(this.label8);
            this.grpStatistic.Controls.Add(this.label13);
            this.grpStatistic.Controls.Add(this.label12);
            this.grpStatistic.Controls.Add(this.label15);
            this.grpStatistic.Controls.Add(this.label11);
            this.grpStatistic.Controls.Add(this.label14);
            this.grpStatistic.Controls.Add(this.label10);
            this.grpStatistic.Controls.Add(this.label7);
            this.grpStatistic.Controls.Add(this.label6);
            this.grpStatistic.Enabled = false;
            this.grpStatistic.Location = new System.Drawing.Point(822, 67);
            this.grpStatistic.Name = "grpStatistic";
            this.grpStatistic.Size = new System.Drawing.Size(284, 400);
            this.grpStatistic.TabIndex = 9;
            this.grpStatistic.TabStop = false;
            this.grpStatistic.Text = "已选课程统计信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "要求最小学分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "要求最大学分";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "12";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "要求最小课程数";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "要求最大课程数";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(196, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.gridCourseList);
            this.groupBox2.Controls.Add(this.gridLecture);
            this.groupBox2.Controls.Add(this.gridCourse);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 400);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "全校课程查询";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "课程详情";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "开放选课课程";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "开课列表";
            // 
            // gridCourseList
            // 
            this.gridCourseList.AllowUserToAddRows = false;
            this.gridCourseList.AllowUserToDeleteRows = false;
            this.gridCourseList.AllowUserToResizeRows = false;
            this.gridCourseList.AutoGenerateColumns = false;
            this.gridCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lectureIDDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn});
            this.gridCourseList.DataMember = "CourseList";
            this.gridCourseList.DataSource = this.campusDataSet1BindingSource;
            this.gridCourseList.Location = new System.Drawing.Point(303, 42);
            this.gridCourseList.MultiSelect = false;
            this.gridCourseList.Name = "gridCourseList";
            this.gridCourseList.ReadOnly = true;
            this.gridCourseList.RowHeadersVisible = false;
            this.gridCourseList.RowHeadersWidth = 51;
            this.gridCourseList.RowTemplate.Height = 27;
            this.gridCourseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourseList.Size = new System.Drawing.Size(478, 152);
            this.gridCourseList.TabIndex = 10;
            this.gridCourseList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCourseList_CellMouseClick);
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
            // gridLecture
            // 
            this.gridLecture.AllowUserToAddRows = false;
            this.gridLecture.AllowUserToDeleteRows = false;
            this.gridLecture.AllowUserToResizeRows = false;
            this.gridLecture.AutoGenerateColumns = false;
            this.gridLecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLecture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.上课地点DataGridViewTextBoxColumn,
            this.开始周DataGridViewTextBoxColumn,
            this.结束周DataGridViewTextBoxColumn,
            this.星期DataGridViewTextBoxColumn,
            this.开始节DataGridViewTextBoxColumn,
            this.结束节DataGridViewTextBoxColumn,
            this.开课号DataGridViewTextBoxColumn});
            this.gridLecture.DataMember = "TimePeriod";
            this.gridLecture.DataSource = this.campusDataSet1BindingSource;
            this.gridLecture.Location = new System.Drawing.Point(303, 222);
            this.gridLecture.MultiSelect = false;
            this.gridLecture.Name = "gridLecture";
            this.gridLecture.ReadOnly = true;
            this.gridLecture.RowHeadersVisible = false;
            this.gridLecture.RowHeadersWidth = 51;
            this.gridLecture.RowTemplate.Height = 27;
            this.gridLecture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLecture.Size = new System.Drawing.Size(478, 162);
            this.gridLecture.TabIndex = 11;
            // 
            // 上课地点DataGridViewTextBoxColumn
            // 
            this.上课地点DataGridViewTextBoxColumn.DataPropertyName = "上课地点";
            this.上课地点DataGridViewTextBoxColumn.HeaderText = "上课地点";
            this.上课地点DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.上课地点DataGridViewTextBoxColumn.Name = "上课地点DataGridViewTextBoxColumn";
            this.上课地点DataGridViewTextBoxColumn.ReadOnly = true;
            this.上课地点DataGridViewTextBoxColumn.Width = 80;
            // 
            // 开始周DataGridViewTextBoxColumn
            // 
            this.开始周DataGridViewTextBoxColumn.DataPropertyName = "开始周";
            this.开始周DataGridViewTextBoxColumn.HeaderText = "开始周";
            this.开始周DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.开始周DataGridViewTextBoxColumn.Name = "开始周DataGridViewTextBoxColumn";
            this.开始周DataGridViewTextBoxColumn.ReadOnly = true;
            this.开始周DataGridViewTextBoxColumn.Width = 60;
            // 
            // 结束周DataGridViewTextBoxColumn
            // 
            this.结束周DataGridViewTextBoxColumn.DataPropertyName = "结束周";
            this.结束周DataGridViewTextBoxColumn.HeaderText = "结束周";
            this.结束周DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.结束周DataGridViewTextBoxColumn.Name = "结束周DataGridViewTextBoxColumn";
            this.结束周DataGridViewTextBoxColumn.ReadOnly = true;
            this.结束周DataGridViewTextBoxColumn.Width = 60;
            // 
            // 星期DataGridViewTextBoxColumn
            // 
            this.星期DataGridViewTextBoxColumn.DataPropertyName = "星期";
            this.星期DataGridViewTextBoxColumn.HeaderText = "星期";
            this.星期DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.星期DataGridViewTextBoxColumn.Name = "星期DataGridViewTextBoxColumn";
            this.星期DataGridViewTextBoxColumn.ReadOnly = true;
            this.星期DataGridViewTextBoxColumn.Width = 60;
            // 
            // 开始节DataGridViewTextBoxColumn
            // 
            this.开始节DataGridViewTextBoxColumn.DataPropertyName = "开始节";
            this.开始节DataGridViewTextBoxColumn.HeaderText = "开始节";
            this.开始节DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.开始节DataGridViewTextBoxColumn.Name = "开始节DataGridViewTextBoxColumn";
            this.开始节DataGridViewTextBoxColumn.ReadOnly = true;
            this.开始节DataGridViewTextBoxColumn.Width = 60;
            // 
            // 结束节DataGridViewTextBoxColumn
            // 
            this.结束节DataGridViewTextBoxColumn.DataPropertyName = "结束节";
            this.结束节DataGridViewTextBoxColumn.HeaderText = "结束节";
            this.结束节DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.结束节DataGridViewTextBoxColumn.Name = "结束节DataGridViewTextBoxColumn";
            this.结束节DataGridViewTextBoxColumn.ReadOnly = true;
            this.结束节DataGridViewTextBoxColumn.Width = 60;
            // 
            // 开课号DataGridViewTextBoxColumn
            // 
            this.开课号DataGridViewTextBoxColumn.DataPropertyName = "开课号";
            this.开课号DataGridViewTextBoxColumn.HeaderText = "开课号";
            this.开课号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.开课号DataGridViewTextBoxColumn.Name = "开课号DataGridViewTextBoxColumn";
            this.开课号DataGridViewTextBoxColumn.ReadOnly = true;
            this.开课号DataGridViewTextBoxColumn.Width = 60;
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
            this.gridCourse.Location = new System.Drawing.Point(19, 42);
            this.gridCourse.MultiSelect = false;
            this.gridCourse.Name = "gridCourse";
            this.gridCourse.ReadOnly = true;
            this.gridCourse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCourse.RowHeadersVisible = false;
            this.gridCourse.RowHeadersWidth = 10;
            this.gridCourse.RowTemplate.Height = 27;
            this.gridCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourse.Size = new System.Drawing.Size(278, 342);
            this.gridCourse.TabIndex = 9;
            this.gridCourse.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCourse_CellMouseClick);
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
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.btnSubmitCourseSelect);
            this.grpSelect.Controls.Add(this.btnClearCourseSelect);
            this.grpSelect.Controls.Add(this.btnDeleteCourseSelect);
            this.grpSelect.Controls.Add(this.btnAddCourseSelect);
            this.grpSelect.Controls.Add(this.dataGridView2);
            this.grpSelect.Controls.Add(this.dataGridView1);
            this.grpSelect.Enabled = false;
            this.grpSelect.Location = new System.Drawing.Point(12, 473);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(1094, 329);
            this.grpSelect.TabIndex = 11;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "选课面板";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "已选课程数";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(196, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "已选学分";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(196, 253);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 15);
            this.label17.TabIndex = 3;
            this.label17.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(421, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(588, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(477, 264);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnAddCourseSelect
            // 
            this.btnAddCourseSelect.Enabled = false;
            this.btnAddCourseSelect.Location = new System.Drawing.Point(475, 41);
            this.btnAddCourseSelect.Name = "btnAddCourseSelect";
            this.btnAddCourseSelect.Size = new System.Drawing.Size(75, 42);
            this.btnAddCourseSelect.TabIndex = 2;
            this.btnAddCourseSelect.Text = "➕";
            this.btnAddCourseSelect.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCourseSelect
            // 
            this.btnDeleteCourseSelect.Enabled = false;
            this.btnDeleteCourseSelect.Location = new System.Drawing.Point(475, 119);
            this.btnDeleteCourseSelect.Name = "btnDeleteCourseSelect";
            this.btnDeleteCourseSelect.Size = new System.Drawing.Size(75, 42);
            this.btnDeleteCourseSelect.TabIndex = 2;
            this.btnDeleteCourseSelect.Text = "➖";
            this.btnDeleteCourseSelect.UseVisualStyleBackColor = true;
            // 
            // btnClearCourseSelect
            // 
            this.btnClearCourseSelect.Location = new System.Drawing.Point(475, 188);
            this.btnClearCourseSelect.Name = "btnClearCourseSelect";
            this.btnClearCourseSelect.Size = new System.Drawing.Size(75, 44);
            this.btnClearCourseSelect.TabIndex = 6;
            this.btnClearCourseSelect.Text = "🗑️";
            this.btnClearCourseSelect.UseVisualStyleBackColor = true;
            // 
            // btnSubmitCourseSelect
            // 
            this.btnSubmitCourseSelect.Enabled = false;
            this.btnSubmitCourseSelect.Location = new System.Drawing.Point(475, 262);
            this.btnSubmitCourseSelect.Name = "btnSubmitCourseSelect";
            this.btnSubmitCourseSelect.Size = new System.Drawing.Size(75, 44);
            this.btnSubmitCourseSelect.TabIndex = 6;
            this.btnSubmitCourseSelect.Text = "✔️";
            this.btnSubmitCourseSelect.UseVisualStyleBackColor = true;
            // 
            // label_CanSubmit
            // 
            this.label_CanSubmit.AutoSize = true;
            this.label_CanSubmit.ForeColor = System.Drawing.Color.Maroon;
            this.label_CanSubmit.Location = new System.Drawing.Point(69, 337);
            this.label_CanSubmit.Name = "label_CanSubmit";
            this.label_CanSubmit.Size = new System.Drawing.Size(142, 15);
            this.label_CanSubmit.TabIndex = 4;
            this.label_CanSubmit.Text = "当前不符合选课要求";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 814);
            this.Controls.Add(this.grpSelect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpStatistic);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentID);
            this.Name = "MainWindow";
            this.Text = "Curriculam 选课管理系统";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSet1)).EndInit();
            this.grpStatistic.ResumeLayout(false);
            this.grpStatistic.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLecture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            this.grpSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource campusDataSet1BindingSource;
        private campusDataSet campusDataSet1;
        private campusDataSetTableAdapters.CourseTableAdapter courseTableAdapter1;
        private campusDataSetTableAdapters.CourseListTableAdapter courseListTableAdapter1;
        private campusDataSetTableAdapters.StudentTableAdapter studentTableAdapter1;
        private campusDataSetTableAdapters.TimePeriodTableAdapter timePeriodTableAdapter1;
        private System.Windows.Forms.GroupBox grpStatistic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridCourseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gridLecture;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上课地点DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始周DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束周DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 星期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始节DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束节DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开课号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gridCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学分DataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSubmitCourseSelect;
        private System.Windows.Forms.Button btnClearCourseSelect;
        private System.Windows.Forms.Button btnDeleteCourseSelect;
        private System.Windows.Forms.Button btnAddCourseSelect;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_CanSubmit;
    }
}

