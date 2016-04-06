using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContenedorDependenciasEj
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var service = new Service(new Repository());
            service.Add();
            */

            
            var serviceType = Type.GetType("ContenedorDependenciasEj.Service");
            var repositoryType = Type.GetType("ContenedorDependenciasEj.Repository");

            var IRepository = repositoryType.GetConstructors()[0].Invoke(new object[] { });
            var IService = serviceType.GetConstructors()[0].Invoke(new object[] { IRepository });
            serviceType.GetMethod("Add").Invoke(IService, new object[]{});

            Console.ReadLine();

        }
    }
}
