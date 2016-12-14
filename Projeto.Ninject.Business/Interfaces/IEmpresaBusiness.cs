using Projeto.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Ninject.Business.Interfaces
{
    public interface IEmpresaBusiness
    {
        EnterpriseContract GetInformations();
    }
}
