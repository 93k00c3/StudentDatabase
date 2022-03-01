using System;
using System.Windows.Forms;

namespace StudentRegDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            StudentDBOper sdbo = new StudentDBOper();
            string studentid = txtStuid.Text.Trim();
            string studentname = txtStuname.Text.Trim();
            int studentage = int.Parse(txtStuAge.Text.Trim());
            float studentgpa = float.Parse(txtStugpa.Text.Trim());

            Student student = new Student(studentid, studentname, studentage, studentgpa);

            sdbo.registerStudent(student);

            MessageBox.Show("Rejestracja studenta wykonana pomyślnie.");

        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            txtStuid.Text = "";
            txtStuname.Text = "";
            txtStuAge.Text = "";
            txtStugpa.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStugpa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStuAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStuid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
