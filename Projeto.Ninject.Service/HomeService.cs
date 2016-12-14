using Projeto.Contratos;
using Projeto.Ninject.Business;
using Projeto.Ninject.Business.Interfaces;
using Projeto.Ninject.Service.Interfaces;

namespace Projeto.Ninject.Service
{
    public class HomeService:IHomeService
    {
        private readonly IHomeBusiness _homeBusiness; 

        public HomeService(IHomeBusiness homeBusiness)
        {
            _homeBusiness = homeBusiness;
        }
        
        public HomeContract GetInformations()
        {
            return _homeBusiness.GetInformations();
        }
    }
}
