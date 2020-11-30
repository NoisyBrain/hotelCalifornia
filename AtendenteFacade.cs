public class AtendenteFacade
{
    private BancoDados banco = BancoDados.Create();

    public void RegistrarCliente(string nome, string cpf)
    {
        Cliente c = Cliente.Create(nome, cpf);
    }
    public void LancarCompra(string clienteId,int qntProd, string prodCod)
    {
        Cliente c = banco.SelectCliente(clienteId);
        Produto p = banco.SelectProduto(prodCod);
        ItemRelatorio ir = ItemRelatorio.Create();
        ir.AdicionarProduto(p, qntProd);
        c.Relatorio.AdicionarItemRelatorio(ir);
    }
    public void Checking(string cpf, int reserva, string tipoQuarto)
    {
        Cliente c = banco.SelectCliente(cpf);
        Relatorio r = Relatorio.Create();
        c.AdicionarRelatorio(r);
        Produto p = banco.SelectQuarto(tipoQuarto);
        LancarCompra(cpf, reserva, p.Cod);
    }
    public void Checkout(string clienteId)
    {
        Cliente c = banco.SelectCliente(clienteId);
        c.Relatorio.GetRelatorio();
    }
}