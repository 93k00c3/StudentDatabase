using MySql.Data.MySqlClient;

namespace StudentRegDatabase
{
    class StudentDBOper
    {
        MySqlConnection conn = null;

        public StudentDBOper()
        {
            conn = DBConnection.getConnection();
        }

        public void registerStudent(Student student)
        {
            string sid = student.getstudentID();
            string sname = student.getstudentName();
            int sage = student.getstudentAge();
            float sgpa = student.getstudentgpa();

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into Student values ('" + sid + "', '" + sname + "','" + sage + "','" + sgpa + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Student findstudent(string studentid)
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from Student where sid = '" + studentid + "'", conn);

            MySqlDataReader rd = cmd.ExecuteReader();

            Student student = null;

            while (rd.Read())
            {
                string stuid = rd[0].ToString();
                string stuname = rd[1].ToString();
                int stuage = int.Parse(rd[2].ToString());
                float stugpa = float.Parse(rd[3].ToString());

                student = new Student(stuid, stuname, stuage, stugpa);
            }
            conn.Close();
            return student;

        }
        public void updatestudent(Student student)
        {
            string sid = student.getstudentID();
            string sname = student.getstudentName();
            int sage = student.getstudentAge();
            float sgpa = student.getstudentgpa();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE Student SET sid='" + sid + "', sname='" + sname + "', sage='" + sage + "',sgpa='" + sgpa + "' WHERE sid = '" + sid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }
        public void deletestudent(string studentid)
        {

            conn.Open();


            MySqlCommand cmd = new MySqlCommand("DELETE FROM Student WHERE sid = '" + studentid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }
        public void showallstudent()
        {

        }
    }
}
