using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Deel1Oefening5
{
    public partial class UserControlSpeler : UserControl
    {
        public UserControlSpeler()
        {
            InitializeComponent();
        }

        private void buttonZoek_Click(object sender, EventArgs e)
        {
            Zoek();
        }

        private void textBoxZoek_TextChanged(object sender, EventArgs e)
        {
            Zoek();
        }

        private void Zoek()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ZoekSpeler", conn) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("Naam", $"%{textBoxZoek.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();
                List<Speler> spelers = new List<Speler>();
                while (reader.Read())
                {
                    spelers.Add(new Speler { Naam = reader["Naam"].ToString(), Spelersnr = int.Parse(reader["Spelersnr"].ToString()) });
                }
                dataGridView1.DataSource = spelers;
            }
        }

        private void buttonVoegToe_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Spelers (Spelersnr, Naam, Voorletters, Geslacht, Jaartoe, Straat, Huisnr, Postcode, Plaats, Telefoon, Bondsnr) VALUES(@Spelersnr, @Naam, 'M', 'M', '2000', '20', 'a', '2860', 'Sint-Katelijne-Waver', '11', '10')", conn);
                cmd.Parameters.AddWithValue("Naam", textBoxNaam.Text);
                cmd.Parameters.AddWithValue("Spelersnr", textBoxSpelersnr.Text);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
