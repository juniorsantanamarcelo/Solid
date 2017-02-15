using System.Data.SqlClient;
namespace Solid.Spr.Errado
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public void Adicionar()
        {
            try
            {
                if (string.IsNullOrEmpty(Nome)) throw new System.ArgumentNullException(Nome);
                if (string.IsNullOrEmpty(Descricao)) throw new System.ArgumentNullException(Descricao);

                using (var conn = new SqlConnection())
                {
                    var command = new SqlCommand
                    {
                        CommandText = "INSERT INTO PRODUTO(Nome,Descricao) values (@nome,@descricao)"
                    };
                    command.Parameters.AddWithValue("nome", Nome);
                    command.Parameters.AddWithValue("descricao", Descricao);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (System.Exception ex)
            {

                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
                throw ex;
            }

        }
    }
}