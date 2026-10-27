using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tb_paulo.Infraestrutura
{
    internal class EnfermReposita
    {
        {
            private const string MeuBanco = "Data Source = Hospital.db";
        public static void inicializar()
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();
            using var comando = conexao.CreateCommand();
            comando.CommandText = @"

         CREATE TABLE IF NOT EXISTS Dan(
          Id INTEGER PRIMARY KEY,
         nome TEXT NOT NULL,
         habilidades TEXT NOT NULL
        );
        ";
            comando.ExecuteNonQuery();
        }
        public static void Adicionar(Dan hab)
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();
            using var comando = conexao.CreateCommand();
            comando.CommandText = @"
                INSERT INTO Dan(nome, habilidades)
                VALUES ($nome, $habilidades)
             ";
            comando.Parameters.AddWithValue("$nome", hab.nome);
            comando.Parameters.AddWithValue("$habilidades", JsonSerializer.Serialize(hab.habilidades));
            comando.ExecuteNonQuery();
        }
        public static List<Dan> Listar()
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();
            using var comando = conexao.CreateCommand();
            comando.CommandText = @"
                SELECT Id, nome, habilidades FROM Dan ORDER BY Id;
             ";
            using var leitor = comando.ExecuteReader();
            List<Dan> habs = new List<Dan>();
            while (leitor.Read())
            {
                Dan d = new Dan();
                d.Id = leitor.GetInt32(0);
                d.nome = leitor.GetString(1);
                d.habilidades = JsonSerializer.Deserialize<List<string>>(leitor.GetString(2)) ?? new List<string>();

                habs.Add(d);
            }
            return habs;
        }
    }
}

}

