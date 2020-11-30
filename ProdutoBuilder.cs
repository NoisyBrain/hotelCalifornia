public class ProdutoBuilder : IProduto
{
    private Produto _produto;

    public ProdutoBuilder(){_produto = new Produto();}
    public static ProdutoBuilder Create(){ProdutoBuilder pb = new ProdutoBuilder(); return pb;}
    public IProduto Nome(string nome){_produto.Nome = nome; return this;}
    public IProduto Cod(string cod){_produto.Cod = cod; return this;}
    public IProduto Descricao(string des){_produto.Descricao = des; return this;}
    public IProduto Valor(float valor){_produto.Valor = valor; return this;}
    public IProduto Data(string data){_produto.Data = data; return this;}
    public IProduto Checking(string checking){_produto.Checking = checking; return this;}
    public IProduto Checkout(string checkout){_produto.Checkout = checkout; return this;}
    public IProduto NumQuarto(string numQuarto){_produto.NumQuarto = numQuarto; return this;}
    public IProduto Andar(string andar){_produto.Andar = andar; return this;}
    public IProduto Estado(string estado){_produto.Estado = estado; return this;}
    public IProduto Tipo(string tipo){_produto.Tipo = tipo; return this;}
    public Produto Build(){return _produto;}
}