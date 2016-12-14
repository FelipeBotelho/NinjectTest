using Projeto.Contratos;
using Projeto.Ninject.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Ninject.Business
{
    public class HomeBusiness:IHomeBusiness
    {
        public HomeContract GetInformations()
        {
            var result = new HomeContract();
            result.Age = 19;
            result.Name = "Teste";
            return result;
        }
    }
}
