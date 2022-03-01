using System;
using System.Windows.Forms;

namespace StudentRegDatabase
{
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            lblStuName.Text = "";
            lblStudeAge.Text = "";
            lblStuGpa.Text = "";
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            string studentid = txtStuid.Text.Trim();

            StudentDBOper sdbo = new StudentDBOper();
            Student student = sdbo.findstudent(studentid);

            lblStuName.Text = student.getstudentName();
            lblStudeAge.Text = student.getstudentAge().ToString();
            lblStuGpa.Text = student.getstudentgpa().ToString();

        }
    }
}
