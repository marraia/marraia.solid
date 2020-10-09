using marraia.SOLID._5___DSP.Solucao.Dominio;
using marraia.SOLID._5___DSP.Solucao.Repositorio.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace marraia.SOLID._5___DSP.Solucao.Repositorio
{
    public class ItemRepositorio : IItemRepositorio
    {
        public void Add(Item item)
        {
            using (var con = new SqlConnection("StringConexao"))
            {
                using (SqlCommand cmd = new SqlCommand("InserirItemFornecedor", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = item.Nome;
                    cmd.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = item.Descricao;
                    cmd.Parameters.Add("@Valor", SqlDbType.Decimal).Value = item.Valor;
                    cmd.Parameters.Add("@Sku", SqlDbType.VarChar).Value = item.Sku;
                    cmd.Parameters.Add("@NomeFornecedor", SqlDbType.VarChar).Value = item.Fornecedor.Nome;
                    cmd.Parameters.Add("@EmailFornecedor", SqlDbType.VarChar).Value = item.Fornecedor.Email;
                    cmd.Parameters.Add("@CnpjFornecedor", SqlDbType.VarChar).Value = item.Fornecedor.Cnpj;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
