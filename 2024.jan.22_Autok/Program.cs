using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024.jan._22_Autok
{
    internal static class Program
    {
       public static List<Autok> autoklista = new List<Autok>();
        public static Adatbazis db = null;

        public static void Main()

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            db = new Adatbazis();
            autoklista = db.getAllAutok();
            Application.Run(new Form_Nyito());
        }
    }
}
