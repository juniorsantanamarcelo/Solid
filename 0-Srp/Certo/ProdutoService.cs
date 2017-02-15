namespace Solid.Spr.Certo
{
    public class ProdutoService
    {
        private ProdutoRepository _produtoRepository;
   
        public ProdutoService()
        {
            _produtoRepository = new ProdutoRepository();
         
            
        }
        public string Add(Produto produto)
        {

            try
            {
                if (!produto.IsValid) return "Produto Inválido";

                _produtoRepository.Add(produto);
            }
            catch (System.Exception ex)
            {
                FileLogger.Handle(ex.Message);
                return ex.Message;
            }

            return "Sucesso !!!";
        }
    }
}