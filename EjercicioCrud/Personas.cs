using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCrud
{
    public class Personas
    {
        private string conexionString = "Data Source=LAPTOP-NICO\\SQLEXPRESS; Initial Catalog=CrudWindowsForm;Integrated Security=True ;Encrypt=False; TrustServerCertificate=True; ";

        public bool AgregarBaseDatos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();
                    conexion.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }

        public List<ListaPersonas> ObtenerPersonas()
        {
            List<ListaPersonas> lista = new List<ListaPersonas>();
           
            string query = "SELECT * FROM Personas";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {   
                
                SqlCommand comando = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        ListaPersonas persona = new ListaPersonas();

                        persona.Id = reader.GetInt32(0);
                        persona.Nombre = reader.GetString(1);
                        persona.NumTelefono = reader.GetInt32(2);
                        persona.Mail = reader.GetString(3);
                        
                        lista.Add(persona);
                    }
                    reader.Close();
                    conexion.Close();
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un error en la Base de Datos: " + ex.Message);
                }
                   
            }
          
            return lista;
        }

        public ListaPersonas ObtenerPersonasPorId(int? Id)
        {
            string query = "SELECT id, nombre, numtelefono, mail from Personas where Id = @id";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", Id);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        ListaPersonas persona = new ListaPersonas
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            NumTelefono = reader.GetInt32(2),
                            Mail = reader.GetString(3)
                        };
                        reader.Close();
                        conexion.Close();
                        return persona;
                    }
                    reader.Close();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un error en la Base de Datos: " + ex.Message);
                }
            }
            return null;
        }

        public void Agregar(string Nombre, int NumTelefono, string Mail)
        {
            string query = "insert into Personas(nombre, numtelefono, mail) values" +
                "(@nombre, @numtelefono, @mail)";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@numtelefono", NumTelefono);
                comando.Parameters.AddWithValue("@mail", Mail);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un error en la Base de Datos: " + ex.Message);
                }

            }
        }

        public void Editar(string Nombre, int NumTelefono, string Mail,int Id)
        {
            string query = "update Personas set Nombre = @nombre, NumTelefono = @numtelefono, Mail = @mail" +
                " where Id = @id";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@numtelefono", NumTelefono);
                comando.Parameters.AddWithValue("@mail", Mail);
                comando.Parameters.AddWithValue("@id", Id);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un error en la Base de Datos: " + ex.Message);
                }

            }
        }

        public void Eliminar(int Id)
        {
            string query = "Delete from Personas" +
                " where Id = @id";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", Id);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un error en la Base de Datos: " + ex.Message);
                }

            }
        }
    }

    public class ListaPersonas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NumTelefono { get; set; }
        public string Mail { get; set; }
    }
}
