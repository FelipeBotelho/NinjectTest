using Projeto.Contratos;

namespace Projeto_Ninject.Models
{

    public class HomeModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EnterpriseName { get; set; }

        public HomeModel(HomeContract contract, EnterpriseContract empresa)
        {
            this.Name = contract.Name;
            this.Age = contract.Age;
            this.EnterpriseName = empresa.Name;
        }
    }
}