using marraia.SOLID.SRP.Solucao.Dominio;
using marraia.SOLID.SRP.Solucao.Repositorio;
using System;

namespace marraia.SOLID.SRP.Solucao.Application
{
    public class UsuarioApplication
    {
        public string AdicionarUsuario(Item item)
        {
            try
            {
                item.Validar();

                var repositorio = new UsuarioRepositorio();
                repositorio.AdicionarUsuario(item);

                return "Item cadastrado com sucesso";
            }
            catch(ArgumentException ex)
            {
                return ex.Message;
            }
        }
    }
}
