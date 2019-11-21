using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class UpdateStudentForm : Form
    {
        private StudentManagement Business;
        private int StudentId;
        public UpdateStudentForm(int id)
        {
            this.Business = new StudentManagement();
            this.StudentId = id;
            InitializeComponent();
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
            this.Load += UpdateStudentForm_Load;
        }

        void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            var @student = this.Business.GetStudent(this.StudentId);
            this.txtName.Text = @student.Name;
            this.txtCode.Text = @student.Code;
            this.rdbFemale.Checked = true;
            if (student.Gender == true)
            {
                this.rdbMale.Checked = true;
            }
            this.rtbHomeTown.Text = @student.Hometown;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var code = this.txtCode.Text;
            var hometown = this.rtbHomeTown.Text;
            var gender = true;
            if (rdbFemale.Checked == true)
            {
                gender = false;
            }
            this.Business.UpdateStudent(this.StudentId,name,hometown,code,gender);
            MessageBox.Show("Update student successfuly");
            this.Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
