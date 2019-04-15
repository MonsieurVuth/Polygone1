using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Polygone1
{
    class BaseFait
    {
        Inference inference;
        private MySqlConnection connection;

        public BaseFait(Inference inf)
        {
            this.inference = inf;
        }

        private void InitConnect()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=localhost; DATABASE=polygone; UID=root; PASSWORD=password";
            this.connection = new MySqlConnection(connectionString);
        }

        public void AddShape(String libelle)
        {
            InitConnect();
            this.connection.Open();
            String query = "INSERT INTO caracteristiques(libelle_polygone,nbr_cote,nbr_angledroit,nbr_parallele,nbr_memelongueur) VALUES(@libelle,@cote,@angle,@para,@long)";
            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand command = new MySqlCommand(query, this.connection);
            command.Parameters.AddWithValue("@libelle", libelle);
            command.Parameters.AddWithValue("@cote", inference.Cote);
            command.Parameters.AddWithValue("@angle", inference.Angle);
            command.Parameters.AddWithValue("@para", inference.Para);
            command.Parameters.AddWithValue("@long", inference.Longueur);
            command.ExecuteNonQuery();
            this.connection.Close();
            MessageBox.Show("Forme" + libelle + " inserée");
        }

        public String getShape()
        {
            InitConnect();
            this.connection.Open();
            string lib = "";
            String query = "SELECT * FROM caracteristiques WHERE nbr_cote = @cote and nbr_angledroit = @angle and nbr_parallele = @para and nbr_memelongueur = @long";
            MySqlCommand command = new MySqlCommand(query, this.connection);
            command.Parameters.AddWithValue("@cote", inference.Cote);
            command.Parameters.AddWithValue("@angle", inference.Angle);
            command.Parameters.AddWithValue("@para", inference.Para);
            command.Parameters.AddWithValue("@long", inference.Longueur);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    lib = reader["libelle_polygone"].ToString();
                }
                reader.Close();
            }
            this.connection.Close();
            return lib;
        }
    }
}
