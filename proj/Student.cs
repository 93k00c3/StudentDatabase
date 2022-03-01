namespace StudentRegDatabase
{
    class Student
    {
        private string studentID;
        private string studentName;
        private int studentAge;
        private float studentGpa;

        public Student()
        {
            this.studentID = null;
            this.studentName = null;
            this.studentAge = 0;
            this.studentGpa = 0.0f;
        }

        public Student(string sid, string stuname, int stuage, float stugpa)
        {
            this.studentID = sid;
            this.studentName = stuname;
            this.studentAge = stuage;
            this.studentGpa = stugpa;
        }
        public string getstudentID()
        {
            return this.studentID;
        }
        public string getstudentName()
        {
            return this.studentName;
        }
        public int getstudentAge()
        {
            return this.studentAge;
        }
        public float getstudentgpa()
        {
            return this.studentGpa;
        }
    }
}
