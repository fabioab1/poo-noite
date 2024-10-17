using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class Teste
    {
        // Representação do relacionamento de dependência por meio de um parâmetro que é o
        // objeto de outra classe.
        public void AnalisarIdade(Cliente cliente)
        {
            cliente.VerificaIdade();
        }
    }
}