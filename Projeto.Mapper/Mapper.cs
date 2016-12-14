using Ninject;
using Ninject.Modules;
using Projeto.Ninject.Business;
using Projeto.Ninject.Business.Interfaces;

namespace Projeto.Mapper
{
    public class Mapper:NinjectModule
    {
        public override void Load()
        {
            var kernel = new StandardKernel();
            kernel.Bind<IHomeBusiness>().To<HomeBusiness>();
        }
    }
}
