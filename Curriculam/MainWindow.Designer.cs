
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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.studentTableAdapter = new Curriculam.campusDataSetTableAdapters.StudentTableAdapter();
            this.campusDataSet = new Curriculam.campusDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseTableAdapter1 = new Curriculam.campusDataSetTableAdapters.CourseTableAdapter();
            this.CourseGrid = new System.Windows.Forms.DataGrid();
            this.AvailableCourseGrid = new System.Windows.Forms.DataGrid();
            this.campusDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCourseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AvailableCourseGrid);
            this.groupBox1.Controls.Add(this.CourseGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "可选开课列表";
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
            // campusDataSet
            // 
            this.campusDataSet.DataSetName = "campusDataSet";
            this.campusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // CourseGrid
            // 
            this.CourseGrid.CaptionText = "课程列表";
            this.CourseGrid.DataMember = "";
            this.CourseGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.CourseGrid.Location = new System.Drawing.Point(15, 24);
            this.CourseGrid.Name = "CourseGrid";
            this.CourseGrid.ReadOnly = true;
            this.CourseGrid.RowHeadersVisible = false;
            this.CourseGrid.Size = new System.Drawing.Size(281, 375);
            this.CourseGrid.TabIndex = 0;
            // 
            // AvailableCourseGrid
            // 
            this.AvailableCourseGrid.CaptionText = "开课列表";
            this.AvailableCourseGrid.DataMember = "";
            this.AvailableCourseGrid.DataSource = this.campusDataSetBindingSource;
            this.AvailableCourseGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.AvailableCourseGrid.Location = new System.Drawing.Point(302, 24);
            this.AvailableCourseGrid.Name = "AvailableCourseGrid";
            this.AvailableCourseGrid.ReadOnly = true;
            this.AvailableCourseGrid.Size = new System.Drawing.Size(464, 375);
            this.AvailableCourseGrid.TabIndex = 1;
            // 
            // campusDataSetBindingSource
            // 
            this.campusDataSetBindingSource.DataSource = this.campusDataSet;
            this.campusDataSetBindingSource.Position = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.CourseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCourseGrid)).EndInit();
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
        private System.Windows.Forms.DataGrid CourseGrid;
        private System.Windows.Forms.DataGrid AvailableCourseGrid;
        private System.Windows.Forms.BindingSource campusDataSetBindingSource;
    }
}

