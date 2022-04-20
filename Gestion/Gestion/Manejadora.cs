using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    class Manejadora
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static SqlDataReader reader;

        public static void inicializar(string conexion)
        {
            try
            {
                connection = new SqlConnection(conexion);
                command = new SqlCommand("", connection);
                // MessageBox.Show(conexion, "Se Conecto Correctamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static SqlConnection Connection
        {
            get
            {
                return connection;
            }
        }
        public static SqlCommand Command
        {
            get
            {
                return command;
            }
        }
        public static void setCommand(string comando)
        {
            command.CommandText = comando;
        }

        public static bool executeCommand(string comando)
        {
            bool respuesta = false;
            try
            {
                command.CommandText = comando;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                respuesta = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Errors[0].Message);
                connection.Close();
            }
            return respuesta;
        }
        public static bool existe(string comando)
        {
            bool respuesta = false;
            try
            {
                command.CommandText = comando;
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    respuesta = true;
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            return respuesta;
        }
        public static bool AbrirConexion()
        {
            bool conexionAbierta = true;
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo abrir la conexión.");
                foreach (SqlError error in ex.Errors)
                    MessageBox.Show(error.Message);
                conexionAbierta = false;
            }
            return conexionAbierta;

        }

    }
}

