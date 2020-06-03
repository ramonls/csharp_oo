using System;
using System.Collections.Generic;
using System.Text;

namespace TipoValorStruct
{
    /*
    Criação de uma struct para a definiçao de um ponto em um plano cartesiano 2D 
    */
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "("+X+","+Y+")";
        }
    }
}
