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
        const string Adatbazis_letrehozas_SQL = @"CREATE TABLE IF NOT EXISTS felhasznalo 
                                                    (
                                                        felhasznalo_id INTEGER AUTO_INCREMENT PRIMARY KEY,
                                                        felhasznalo_nev VARCHAR(80) NOT NULL UNIQUE,
                                                        felhasznalo_jelszo VARCHAR(100) NOT NULL,
                                                        felhasznalo_reg_datum DATE NOT NULL
                                                    )";
        MySqlConnection conn;

        public Form_adatbazis()
        {
            InitializeComponent();
            try
            {
                conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;");
                conn.Open();
                // TÁBLA ELLENŐRZÉSE HOGY LÉTRE VAN-E HOZVA
                var letrehozas = conn.CreateCommand();
                letrehozas.CommandText = Adatbazis_letrehozas_SQL;
                letrehozas.ExecuteNonQuery();
                // --------------------

                Update_reg_userek();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Adatbázis hiba: " + ex.Message);
                this.Close();
            }
        }
        private void Update_reg_userek()
        {
            string Kiirando_Szoveg = "Regisztrált {0} db felhasználó";
            var c = conn.CreateCommand();
            // CommandText -> ebbe kell beleírni az SQL utasítást!!!!
            c.CommandText = "SELECT COUNT(*) FROM felhasznalo";
            long db = (long)c.ExecuteScalar();
            Label_Reg_userek.Text = String.Format(Kiirando_Szoveg, db); // String.format --> 1. a szöveg 2. a paraméter({} ebbe fűzöm bele a változót)!

            // LISTÁZÁS
            var felhasznalok = conn.CreateCommand();
            felhasznalok.CommandText = "SELECT felhasznalo_nev, felhasznalo_reg_datum FROM felhasznalo ORDER BY felhasznalo_nev";
            using (var reader = felhasznalok.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nev = reader.GetString("felhasznalo_nev");
                    var datum = reader.GetDateTime("felhasznalo_reg_datum");
                    ListBox_felhasznalok.Items.Add(String.Format("{0} - {1:yyyy. MM. dd.}", nev, datum));
                }
            }
            // -----------------------------
        }
        private void Button_regisztralas_Click(object sender, EventArgs e)
        {
            // Solution -> project(jobb klik) -> Manage NuGET Packages -> Browse -> Installed
            string nev = TextBox_nev.Text;
            string jelszo = TextBox_jelszo.Text;
            DateTime szuletesi_datum = DateTimePicker_szul_ido.Value;
            // https://www.connectionstrings.com/mysql/
            // using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;")) // Ezzel működik -> using MySql.Data.MySqlClient;
            {
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

                Update_reg_userek();
                // -------------------------------
            }
        }
        private void Button_torles_Click(object sender, EventArgs e)
        {
            string nev = TextBox_nev.Text;
            using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;"))
            {
                conn.Open();
                // TÖRLÉS - HIBAKEZELÉS
                var Van_e_felhasznalo = conn.CreateCommand();
                Van_e_felhasznalo.CommandText = "SELECT COUNT(*) FROM felhasznalo WHERE felhasznalo_nev = @nev";
                Van_e_felhasznalo.Parameters.AddWithValue("@nev", nev);
                var darab = (long)Van_e_felhasznalo.ExecuteScalar();
                if (darab == 0)
                {
                    MessageBox.Show("A felhasználó nem létezik! Nem tudok törölni!");
                    return;
                }
                else
                {
                    var torles = conn.CreateCommand();
                    torles.CommandText = "DELETE FROM felhasznalo WHERE felhasznalo_nev = @nev";
                    torles.Parameters.AddWithValue("@nev", nev);
                    int erintettSorok = torles.ExecuteNonQuery();
                    MessageBox.Show("Felhasználó törlésre került!");

                    Update_reg_userek();
                    return;

                }
                // --------------------
            }
        }
        private void Button_update_Click(object sender, EventArgs e)
        {
            string nev = TextBox_nev.Text;
            DateTime szuldatum = DateTimePicker_szul_ido.Value;
            using (var conn = new MySqlConnection("Server=localhost;Database=regisztracio;Uid=root;Pwd=;"))
            {
                conn.Open();
                // UPDATE
                var Update = conn.CreateCommand();
                Update.CommandText = "UPDATE felhasznalo SET felhasznalo_reg_datum = @regdatum WHERE felhasznalo_nev = @nev";
                Update.Parameters.AddWithValue("@regdatum", szuldatum);
                Update.Parameters.AddWithValue("@nev", nev);
                int erintettSorok = Update.ExecuteNonQuery();

                Update_reg_userek();
                // ------------------
            }
        }
    }
}