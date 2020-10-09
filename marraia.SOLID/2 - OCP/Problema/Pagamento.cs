
using System;
using System.Collections.Generic;
using System.Text;

namespace marraia.SOLID._2___OCP.Problema
{
    public class Pagamento
    {
        public void Pagar(decimal valor, TipoPagamento tipo)
        {
            if (tipo == TipoPagamento.Boleto)
            {
                var boleto = new Boleto();
            }

            if (tipo == TipoPagamento.Dinheiro)
            {
                var dinheiro = new Dinheiro();
            }

            if (tipo == TipoPagamento.Carne)
            {

            }
        }
    }
}
