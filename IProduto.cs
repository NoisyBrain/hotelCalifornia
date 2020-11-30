public interface IProduto
{
    IProduto Nome(string nome);
    IProduto Cod(string cod);
    IProduto Descricao(string des);
    IProduto Valor(float valor);
    IProduto Data(string data);
    IProduto Checking(string checking);
    IProduto Checkout(string checkout);
    IProduto NumQuarto(string numQuarto);
    IProduto Andar(string andar);
    IProduto Estado(string estado);
    IProduto Tipo(string tipo);
    Produto Build();
    
}