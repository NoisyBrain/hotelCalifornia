public class GerenteFacade : AtendenteFacade
{
    private ProdutoBuilder _produtoBuilder;
    private DirectorProduto _DirectorProduto;
    public GerenteFacade()
    {
        _produtoBuilder = new ProdutoBuilder();
        _DirectorProduto = new DirectorProduto();
    }
    public void CadastrarQuarto(string cod, string numQuarto, string andar, string tipo, float valor)
    {
        _DirectorProduto. BuilderRoom(cod, numQuarto, andar, tipo, valor);
    }
    public void CadastrarConsumivel(string nome, string cod, float valor)
    {
        _DirectorProduto.BuilderProduct(nome, cod, valor);
    }
    public void CadastrarServico(string nome, string cod, string descricao, string data)
    {
        _DirectorProduto.BuilderService(nome, cod, descricao, data);
    }

}