using System;

namespace marraia.SOLID._2___OCP.Solucao.Dominio
{
    public class Boleto : Pagamento
    {
        public Boleto(double valor, int parcelamento)
            : base(valor, parcelamento)
        {

        }

        public Guid Numero { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public string Banco { get; private set; }
        public decimal Juros { get; private set; }

        public void GerarBoleto()
        {
            Numero = Guid.NewGuid();
            DataVencimento = DateTime.Now.AddDays(-1);
        }

        public void CalcularJurosVencimento()
        {
            var taxa = Valor * 0.05;
            SetarValor(Valor + taxa);
        }
    }
}
