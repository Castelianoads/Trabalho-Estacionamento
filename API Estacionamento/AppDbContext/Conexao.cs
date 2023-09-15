using Dapper;
using Npgsql;
using System.Diagnostics;

namespace API_Estacionamento.AppDbContext
{
    public class Conexao
    {
        public int Id { get; set; }

        public string StringDeConexao()
        {
            try
            {
                NpgsqlConnectionStringBuilder stringBuilder = new NpgsqlConnectionStringBuilder
                {
                    Host = "",
                    Port = 5432,
                    Username = "",
                    Password = "",
                    Database = ""
                };
                return stringBuilder.ToString();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return "erro";
            }
        }

        public int IdIncrementado(string tabela)
        {
            using (var conexao = new NpgsqlConnection(StringDeConexao()))
            {
                int idBanco = conexao.ExecuteScalar<int>(@$"SELECT Max(""Id"") AS Maior From public.""{tabela}""");
                return idBanco + 1;
            }                
        }
    }
}
