using marraia.SOLID.SRP.Solucao.Dominio.ValueObjects;
using System;

namespace marraia.SOLID.SRP.Solucao.Dominio
{
    public class Item
    {
        public Item(string nome, 
                    string descricao, 
                    decimal valor, 
                    string sku)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Sku = sku;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public Fornecedor Fornecedor { get; private set; }
        public string Sku { get; private set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nome) ||
                string.IsNullOrEmpty(Descricao) ||
                Valor <= 0)
                throw new ArgumentException("Dados obrigatórios não preenchidos");

            if (string.IsNullOrEmpty(Fornecedor.Nome) ||
                string.IsNullOrEmpty(Fornecedor.Email) ||
                string.IsNullOrEmpty(Fornecedor.Cnpj))
                throw new ArgumentException("Dados do fornecedor não preenchidos");
        }
    }
}
