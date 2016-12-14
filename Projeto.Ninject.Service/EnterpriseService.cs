using Projeto.Contratos;
using Projeto.Ninject.Business.Interfaces;
using Projeto.Ninject.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Ninject.Service
{
    public class EnterpriseService: IEnterpriseService
    {
        private readonly IEmpresaBusiness _empresaBusiness;

        public EnterpriseService(IEmpresaBusiness empresaBusiness)
        {
            _empresaBusiness = empresaBusiness;
        }

        public EnterpriseContract GetInformations()
        {
            return _empresaBusiness.GetInformations();
        }
    }
}
