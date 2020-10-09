using System;
using System.Collections.Generic;
using System.Text;

namespace marraia.SOLID._4___ISP.Problema.Interfaces
{
    public interface ICadastro
    {
        void ValidarDados();
        void Salvar();
        void EnviarEmail();
    }
}
