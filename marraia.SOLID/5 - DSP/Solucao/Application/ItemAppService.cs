using marraia.SOLID._5___DSP.Solucao.Dominio;
using marraia.SOLID._5___DSP.Solucao.Repositorio.Gateway.Interfaces;
using marraia.SOLID._5___DSP.Solucao.Repositorio.Interfaces;

namespace marraia.SOLID._5___DSP.Solucao.Application
{
    public class ItemAppService : IItemAppService
    {
        private readonly IItemRepositorio _itemRepositorio;
        private readonly IEmailGateway _emailGateway;

        public ItemAppService(IItemRepositorio itemRepositorio,
                                IEmailGateway emailGateway)
        {
            _itemRepositorio = itemRepositorio;
            _emailGateway = emailGateway;
        }
        public void Add(Item item)
        {
            _itemRepositorio.Add(item);
            _emailGateway.EnvioEmail("", "", "", "");
        }
    }
}
