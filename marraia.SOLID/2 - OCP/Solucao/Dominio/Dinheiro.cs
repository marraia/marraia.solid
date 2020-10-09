using System;

namespace marraia.SOLID._2___OCP.Solucao.Dominio
{
    public class Dinheiro : Pagamento
    {
        public Dinheiro(double valor)
            : base(valor)
        {

        }

        public override void Pagar()
        {
            DataPagamento();
        }
    }
}

