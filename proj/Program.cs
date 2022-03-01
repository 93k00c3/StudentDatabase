using System.Windows.Forms;

namespace StudentRegDatabase
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dashboard());
        }
    }
}
