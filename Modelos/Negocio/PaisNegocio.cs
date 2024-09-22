using Modelos.Entidades;
using System.Data.SqlClient;

namespace Modelos.Negocio
{
    public class PaisNegocio(string connectionString)
    {
        private readonly string _connectionString = connectionString;


        public List<Pais> ObtenerPaises()
        {
            List<Pais> paises= new List<Pais>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT id, nombre FROM Paises";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Pais pais = new Pais
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1)
                    };
                    paises.Add(pais);
                }
            }

            return paises;
        }
    }
}
