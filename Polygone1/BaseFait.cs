using MySql.Data.MySqlClient;
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

        //public void AddShape(String libelle)
        //{
        //    InitConnect();
        //    this.connection.Open();
        //    // Création d'une commande SQL en fonction de l'objet connection
        //     cmd = this.connection.CreateCommand();
        //    cmd.CommandText = "INSERT INTO caracteristiques(libelle_polygone,nbr_cote,nbr_angledroit,nbr_parallele,nbr_memelongueur) VALUES()";
        //    cmd.Parameters.AddWithValue("@libelle", libelle);
        //    cmd.Parameters.AddWithValue("@cote", inference.Cote);
        //    cmd.Parameters.AddWithValue("@angle", inference.Angle);
        //    cmd.Parameters.AddWithValue("@para", inference.Para);
        //    cmd.Parameters.AddWithValue("@long", inference.Longueur);
        //    cmd.ExecuteNonQuery();
        //    this.connection.Close();
        //}

        public void getShape()
        {
            InitConnect();
            this.connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM caracteristiques ", this.connection);
            
            using (MySqlDataReader reader = command.ExecuteReader())
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
