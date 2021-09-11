
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
            this.campusDataSet = new Curriculam.campusDataSet();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.studentTableAdapter = new Curriculam.campusDataSetTableAdapters.StudentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseTableAdapter1 = new Curriculam.campusDataSetTableAdapters.CourseTableAdapter();
            this.gridCourse = new System.Windows.Forms.DataGridView();
            this.campusDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.课程号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridCourse);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "可选开课列表";
            // 
            // campusDataSet
            // 
            this.campusDataSet.DataSetName = "campusDataSet";
            this.campusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(71, 19);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(125, 25);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.TextChanged += new System.EventHandler(this.studentIDTextBox_TextChanged);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
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
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // gridCourse
            // 
            this.gridCourse.AllowUserToAddRows = false;
            this.gridCourse.AllowUserToDeleteRows = false;
            this.gridCourse.AutoGenerateColumns = false;
            this.gridCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.课程号DataGridViewTextBoxColumn,
            this.课程名DataGridViewTextBoxColumn});
            this.gridCourse.DataMember = "Course";
            this.gridCourse.DataSource = this.campusDataSetBindingSource;
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
            this.gridCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCourse_CellContentClick);
            // 
            // campusDataSetBindingSource
            // 
            this.campusDataSetBindingSource.DataSource = this.campusDataSet;
            this.campusDataSetBindingSource.Position = 0;
            // 
            // 课程号DataGridViewTextBoxColumn
            // 
            this.课程号DataGridViewTextBoxColumn.DataPropertyName = "课程号";
            this.课程号DataGridViewTextBoxColumn.HeaderText = "课程号";
            this.课程号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.课程号DataGridViewTextBoxColumn.Name = "课程号DataGridViewTextBoxColumn";
            this.课程号DataGridViewTextBoxColumn.ReadOnly = true;
            this.课程号DataGridViewTextBoxColumn.Width = 80;
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
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStudentID;
        private campusDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private campusDataSet campusDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtStudentName;
        private System.Windows.Forms.Label label2;
        private campusDataSetTableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.DataGridView gridCourse;
        private System.Windows.Forms.BindingSource campusDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名DataGridViewTextBoxColumn;
    }
}

