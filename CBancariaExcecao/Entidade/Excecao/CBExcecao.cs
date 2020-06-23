using System;

namespace CBancariaExcecao.Entidade.Excecao
{
    class CBExcecao : ApplicationException
    {
        //construtor
        public CBExcecao(string message): base(message)
        {
        }
    }
}
