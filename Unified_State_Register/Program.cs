using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Unified_State_Register
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database DB;
            try
            {
                DB = new Database(DBUtils.GetDBConnection());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(DB));
        }
    }
}
