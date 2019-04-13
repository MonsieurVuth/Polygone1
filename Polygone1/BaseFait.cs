using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Polygone1
{
    class BaseFait
    {
        Inference inference;
        private SqlConnection connection;

        public BaseFait(Inference inf)
        {
            this.inference = inf;
        }

        private void InitConnect()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=localhost; DATABASE=Polygone; UID=root; PASSWORD=password";
            this.connection = new SqlConnection(connectionString);
        }

        public void AddShape(String libelle)
        {
            InitConnect();
            this.connection.Open();
            // Création d'une commande SQL en fonction de l'objet connection
            SqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "INSERT INTO caracteristiques(libelle_polygone,nbr_cote,nbr_angledroit,nbr_parallele,nbr_memelongueur) VALUES()";
            cmd.Parameters.AddWithValue("@libelle", libelle);
            cmd.Parameters.AddWithValue("@cote", inference.Cote);
            cmd.Parameters.AddWithValue("@angle", inference.Angle);
            cmd.Parameters.AddWithValue("@para", inference.Para);
            cmd.Parameters.AddWithValue("@long", inference.Longueur);
            cmd.ExecuteNonQuery();
            this.connection.Close();
        }

        public void getShape()
        {
            InitConnect();
            this.connection.Open();
            SqlCommand command = this.connection.CreateCommand();
            command.CommandText = "SELECT * FROM caracteristiques WHERE nbr_cote = @cote; AND nbr_angledroit = @angle; AND nbr_parallele = @para; AND nbr_memelongueur = @long;";
            command.Parameters["@cote"].Value = this.inference.Cote;
            command.Parameters["@angle"].Value = this.inference.Angle;
            command.Parameters["@para"].Value = this.inference.Para;
            command.Parameters["@long"].Value = this.inference.Longueur;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine(reader.GetValue(i));
                    }
                    Console.WriteLine();
                }
            }
            this.connection.Close();

        }
    }
}
