using EscuelaBOL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaDAL
{
    public class EscuelaDAL
    {

        private string connectionString = "NACHO-GAMER\\SQLEXPRESS02";

        public void InsertarAlumno(Alumnno alumnno)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Alumnos (AlumnoID, Nombre, ApellidoPAT, ApellidoMAT, Email, NumetroMatricula)" +
                               "VALUES (@Nombre, @ApellidoPAT,ApellidoMAT,@Email, @NumeroMatricula)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", alumnno.Nombre ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApellidoPAT", alumnno.ApellidoPAT ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApellidoMAT", alumnno.ApellidoMAT ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", alumnno.Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("NumeroMatricula", alumnno.NumeroMatricula ?? (object)DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
        }


        public void ModificarAlumno(Alumnno alumnno)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Alumnos SET " +
                        "Nombre = @Nombre, " +
                        "ApellidoPAT = @ApellidoPAT, " +
                        "ApellidoMAT = @ApellidoMAT, " +
                        "Email = @Email, " +
                        "NumeroMatricula = @NumeroMatricula " +
                        "WHERE Id = @IDAlumno";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDAlumno", alumnno.IDAlumno);
                    command.Parameters.AddWithValue("@Nombre", alumnno.Nombre ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApellidoPAT", alumnno.ApellidoPAT ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApellidoMAT", alumnno.ApellidoMAT ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", alumnno.Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NumeroMatricula", alumnno.NumeroMatricula ?? (object)DBNull.Value);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }



        public int EliminarAlumno(int id)
        {
            int res = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "delete from Alumnos where id=@id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }




        public List<Alumnno> SeleccionarTodos()
        {
            List<Alumnno> lista = new List<Alumnno>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select Id,Nombre, ApellidoPAT, ApellidoMAT, Email, NumeroMatricula from Alumnos";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Alumnno alumno = new Alumnno();
                        alumno.IDAlumno = dr.GetInt32(0);
                        alumno.Nombre = dr.GetString(1);
                        alumno.ApellidoPAT = dr.GetString(2);
                        alumno.ApellidoMAT = dr.GetString(3);
                        alumno.Email = dr.GetString(4);
                        alumno.NumeroMatricula= dr.GetString(5);
                        lista.Add(alumno);

                    }
                    connection.Close();
                }
            }
            return lista;
        }




        public Alumnno SeleccionarUno(int id)
        {
            Alumnno obj = new Alumnno();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select Id,Nombre, Poderes, Humano, Nacionalidad," +
                    " Edad from heroes where id=@id ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        obj.IDAlumno = dr.GetInt32(0);
                        obj.Nombre = dr.GetString(1);
                        obj.ApellidoPAT = dr.GetString(2);
                        obj.ApellidoMAT = dr.GetString(3);
                        obj.Email = dr.GetString(4);
                        obj.NumeroMatricula = dr.GetString(5);
                    }
                    connection.Close();
                }
            }
            return obj;
        }

    }
}