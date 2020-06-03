
namespace Enums.Entidades.Enums
{
    //Criando o StatusDoPedido derivado do int (herança)
    enum StatusDoPedido : int
    {
        PagamentoPendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
