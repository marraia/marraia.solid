using System;
using System.Data;
using System.Data.SqlClient;

namespace marraia.SOLID.SRP.Problema
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string NomeFornecedor { get; set; }
        public string EmailFornecedor { get; set; }
        public string CNPJForncedor { get; set; }
        public string Sku { get; set; }

        public string AdicionarFornecedor()
        {
            if (!EmailFornecedor.Contains("@"))
                return "E-mail inválido";

            if (CNPJForncedor.Length != 14)
                return "CNPJ inválido";


            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "StringConexao";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO 
                                            FORNECEDOR (NOME, 
                                                        DESCRICAO, 
                                                        VALOR, 
                                                        NOMEFORNECEDOR, 
                                                        EMAILFORNECEDOR, 
                                                        CNPJFORNECEDOR, 
                                                        SKU) 
                                    VALUES (@nome, 
                                            @descricao,
                                            @valor, 
                                            @nomeFornecedor,
                                            @emailFornecedor,
                                            @cnpjFornecedor,
                                            @sku)";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("descricao", Descricao);
                cmd.Parameters.AddWithValue("valor", Valor);
                cmd.Parameters.AddWithValue("nomeFornecedor", NomeFornecedor);
                cmd.Parameters.AddWithValue("emailFornecedor", EmailFornecedor);
                cmd.Parameters.AddWithValue("cnpjFornecedor", CNPJForncedor);
                cmd.Parameters.AddWithValue("sku", Sku);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            return "Fornecedor inserido com sucesso";
        }
    }
}
