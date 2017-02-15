using Solid.Dip.Certo.Interfaces;

namespace Solid.Dip.Certo
{
    public class ProdutoService :IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IFileLogger _logger;
        public ProdutoService(IProdutoRepository produtoRepository,IFileLogger logger)
        {
            _produtoRepository = produtoRepository;
            _logger = logger;
            
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
                _logger.Handle(ex.Message);
                return ex.Message;
            }

            return "Sucesso !!!";
        }
    }
}