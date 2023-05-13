using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace GestionDAL
{
    // Classe de gestion de la connexion à la BD
    public class ConnexionBD
    {
        private SqlConnection connection;
        private static ConnexionBD connectionDB; // instance d'une connexion
        private string chaineConnexion; // chaîne de connexion à la BD

        // Accesseur en lecture de la chaîne de connexion
        public string GetchaineConnexion()
        {
            return chaineConnexion;
        }

        // Accesseur en écriture de la chaîne de connexion
        public void SetchaineConnexion(string ch)
        {
            chaineConnexion = ch;
        }

        // Accesseur en lecture, renvoi une instance de connexion
        public static ConnexionBD GetConnexionBD()
        {
            if (connectionDB == null)
            {
                connectionDB = new ConnexionBD();
            }
            return connectionDB;
        }

        // Constructeur privé
        private ConnexionBD()
        {

        }

        public SqlConnection GetSqlConnexion()
        {
            if (connection == null)
            {
                connection = new SqlConnection();
                connection.ConnectionString = chaineConnexion;

            }

            // Si la connexion est fermée, on l’ouvre
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnexion()
        {
            // Si la connexion est ouverte, on la ferme
            if (this.connection != null && this.connection.State != System.Data.ConnectionState.Closed)
            {
                this.connection.Close();
            }
        }
    }
}