using Projeto.Contratos;
using Projeto.Ninject.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Ninject.Business
{
    public class EmpresaBusiness: IEmpresaBusiness
    {
        public EnterpriseContract GetInformations()
        {
            var result = new EnterpriseContract();
            result.Name = "Programmers Beyond IT";
            return result;
        }

    }
}
