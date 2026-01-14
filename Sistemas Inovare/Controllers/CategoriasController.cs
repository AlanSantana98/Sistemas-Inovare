using Sistemas_Inovare.Models;
using MySql.Data.MySqlClient;
using MySqlConnector;
using System.Data;

namespace Alan_Veiculos.Data
{
    public class ClienteRepository
    {
        private readonly string _connectionString;

        public ClienteRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public List<Cliente> ListarClientes()
        {
            var lista = new List<Cliente>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                using (var cmd = new MySqlCommand("sp_ListarClientes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cliente
                            {
                                Id = reader.GetInt32("Id"),
                                Nome = reader.GetString("Nome"),
                                Telefone = reader.GetString("Telefone"),
                                Email = reader.GetString("Email")
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}
