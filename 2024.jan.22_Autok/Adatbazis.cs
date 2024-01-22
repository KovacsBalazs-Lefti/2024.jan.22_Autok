using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                        DateTime gyartasiev = dr.GetDateTime("gyartasiev");
                        DateTime forgalmiErvenyesseg = dr.GetDateTime("forgalmiErvenyesseg");
                        int vetelar = dr.GetInt32("vetelar");
                        int kmallas = dr.GetInt32("kmallas"); ;
                        int hengerűrtartalom = dr.GetInt32("hengerűrtartalom"); ;
                        int tomeg = dr.GetInt32("tomeg"); ;
                        int teljesitmeny = dr.GetInt32("teljesitmeny");
                        autoklista.Add(new Autok(rendszam, marka, modell, gyartasiev, forgalmiErvenyesseg, vetelar, kmallas, hengerűrtartalom, tomeg, teljesitmeny));
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

        internal void updateAuto(Autok autok)
        {
            sql.CommandText = "UPDATE `auto` SET " +
                "`marka`='@marka," +
                "`modell`='@modell," +
                "`gyartasiev`=@gyartasiev," +
                "`forgalmiErvenyesseg`=@forgalmiErvenyesseg," +
                "`vetelar`=@vetelar," +
                "`kmallas`=@kmallas," +
                "`hengerűrtartalom`=@hengerűrtartalom," +
                "`tomeg`=@tomeg," +
                "`teljesitmeny`=@teljesitmeny" +
                "WHERE `rendszam`=@rendszam";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@marka", autok.Marka);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { kapcsolatZar(); }
        }
    }
}
