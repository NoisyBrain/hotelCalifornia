public class DirectorProduto
{
    private IProduto _produto;
    
    public IProduto Produto {get;set;}
    public DirectorProduto(IProduto produto)
    {
        _produto = produto;
    }
    public DirectorProduto(){}
    public static DirectorProduto Create(IProduto produtoBuilder)
    {
        DirectorProduto d = new DirectorProduto(produtoBuilder);
        return d;
    }
    
    public void BuilderRoom(string cod, string numQuarto, string andar, string tipo, float valor)
    {
    Produto.Nome($"Quarto-{tipo}").Cod($"QUA{cod}").NumQuarto(numQuarto).Andar(andar).Valor(valor).Tipo(tipo).Estado("Livre").Build();
    }
    public void BuilderProduct(string nome, string cod, float valor)
    {
        Produto.Nome(nome).Cod($"PRO{cod}").Valor(valor).Build();
    }
    public void BuilderService(string nome, string cod, string descricao, string data)
    {
        Produto.Nome(nome).Cod($"SER{cod}").Descricao(descricao).Data(data).Build();
    }

}