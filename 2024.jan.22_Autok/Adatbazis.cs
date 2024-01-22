using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _2024.jan._22_Autok
{
    internal class Adatbazis
    {
        MySqlConnection conn=null;
        MySqlCommand sql=null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "autok";
            builder.CharacterSet = "utf8";
            conn = new MySqlConnection(builder.ConnectionString);
            sql = conn.CreateCommand();
            try
            {
                kapcsolatNyit();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            finally
            {
                kapcsolatZar();
            }
        }

        private void kapcsolatZar()
        {
            if (conn.State != System.Data.ConnectionState.Closed) conn.Close();
        }

        private void kapcsolatNyit()
        {
            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
        }

        internal List<Autok> getAllAutok()
        {
            List<Autok> autoklista = new List<Autok>();
            sql.CommandText = "SELECT * FROM `auto` ORDER BY`marka`";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string rendszam = dr.GetString("rendszam");
                        string marka = dr.GetString("marka");
                        string modell = dr.GetString("modell");
                        DateTime gyartasiev;
                        DateTime forgalmiErvenyesseg;
                        int vetelar;
                        int kmallas;
                        int hengerurtartalom;
                        int tomeg;
                        int teljesitmeny;
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
            return autoklista;
        }
    }
}
