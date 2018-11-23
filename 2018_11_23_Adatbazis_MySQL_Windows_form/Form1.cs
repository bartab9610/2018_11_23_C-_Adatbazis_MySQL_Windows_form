using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _2018_11_23_Adatbazis_MySQL_Windows_form
{
    public partial class Form_adatbazis : Form
    {
        public Form_adatbazis()
        {
            InitializeComponent();
        }

        private void Button_regisztralas_Click(object sender, EventArgs e)
        {
            // Solution -> project(jobb klik) -> Manage NuGET Packages -> Browse -> Installed
            string nev = TextBox_nev.Text;
            string jelszo = TextBox_jelszo.Text;
            DateTime szuletesi_datum = DateTimePicker_szul_ido.Value;
            // https://www.connectionstrings.com/mysql/
            using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;")) // Ezzel működik -> using MySql.Data.MySqlClient;
            {
                conn.Open();
                // HIBAKEZELÉS -------
                var ellenorzes = conn.CreateCommand();
                ellenorzes.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE felhasznalo_nev = @nev";
                ellenorzes.Parameters.AddWithValue("@nev", nev);
                var darab = (long)ellenorzes.ExecuteScalar();
                if (darab != 0)
                {
                    MessageBox.Show("Ez a felhasználó már létezik");
                    return;
                }
                // -------------------
                var command = conn.CreateCommand();
                // CommandText -> ez tartalmazza az SQL utasítás
                command.CommandText = "INSERT INTO felhasznalo (felhasznalo_nev,felhasznalo_jelszo,felhasznalo_reg_datum) VALUES (@nev, @jelszo, @regdatum)";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@jelszo", jelszo);
                command.Parameters.AddWithValue("@regdatum", szuletesi_datum);
                int erintettSorok = command.ExecuteNonQuery();
            }
        }
    }
}