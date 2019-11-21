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
    public partial class CreateStudentForm : Form
    {
        private StudentManagement Business;
        public CreateStudentForm()
        {
            InitializeComponent();
            this.Business = new StudentManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.Business.CreateStudent(code,name,hometown,gender);
            MessageBox.Show("Create student successfuly");
            this.Close();
        }
    }
}
