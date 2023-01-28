using System.Data.SqlClient;
using WebApplication3.Business.Repository;
using WebApplication3.Business.Repository.Impl;
using WebApplication3.Business.Service;
using WebApplication3.Business.Service.Impl;

namespace WebApplication3.Business.Factory
{
    public class EjemploFactory
    {
        private readonly IEjemploRepository _ejemploRepository;

        public EjemploFactory(SqlConnection connection)
        {
            _ejemploRepository = new EjemploRepository(connection);
        }

        public IEjemploService GetImplementation()
        {
            var service = new EjemploService(_ejemploRepository);
            return service;
        }
    }
}
