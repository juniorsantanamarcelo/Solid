using System.Data.SqlClient;
using Solid.Dip.Certo.Interfaces;

namespace Solid.Dip.Certo

{
    public class ProdutoRepository : IProdutoRepository
    {
        public void Add(Produto produto)
        {

            using (var conn = new SqlConnection())
            {
                var command = new SqlCommand
                {
                    CommandText = "INSERT INTO PRODUTO(Nome,Descricao) values (@nome,@descricao)"
                };
                command.Parameters.AddWithValue("nome", produto.Nome);
                command.Parameters.AddWithValue("descricao", produto.Descricao);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }



        }
    }
}