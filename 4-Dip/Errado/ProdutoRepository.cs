using System.Data.SqlClient;

namespace Solid.Dip.Errado
{
    public class ProdutoRepository 
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