using System;
using System.Windows.Forms;

namespace StudentRegDatabase
{
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void ShowAllStudents_Load(object sender, EventArgs e)
        {
            /*this.studentTableAdapter.Fill(this.studentManSystemDataSet.Student);*/
        }
    }
}
