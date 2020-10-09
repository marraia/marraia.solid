using System;

namespace marraia.SOLID._2___OCP.Solucao.Dominio
{
    public abstract class Pagamento
    {
        public Pagamento(double valor, int parcelamento)
        {
            Id = Guid.NewGuid();
            Valor = valor;
            Parcelamento = parcelamento;
            Confirmacao = false;
        }

        public Pagamento(double valor)
        {
            Id = Guid.NewGuid();
            Valor = valor;
        }

        public Guid Id { get; private set; }
        public double Valor { get; private set; }
        public int Parcelamento { get; private set; }
        public double ValorParcela { get; private set; }
        public DateTime Data { get; private set; }
        public bool Confirmacao { get; private set; }

        public virtual void Pagar()
        {
            DataPagamento();
            if (Parcelamento > 0)
            {
                ValorParcela = Valor / Parcelamento;
            }
        }

        public void ConfirmarPagamento()
        {
            Confirmacao = true;
        }

        public void DataPagamento()
        {
            Data = DateTime.Now;
        }

        public void SetarValor(double valor)
        {
            Valor = valor;
        }
    }
}
