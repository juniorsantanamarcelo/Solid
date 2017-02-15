namespace Solid.Dip.Errado
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool IsValid => !(string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(Descricao));

        
    }
}