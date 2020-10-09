using marraia.SOLID.SRP.Solucao.Dominio;
using System.Data;
using System.Data.SqlClient;

namespace marraia.SOLID.SRP.Solucao.Repositorio
{
    public class UsuarioRepositorio
    {
        public void AdicionarUsuario(Item item)
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
