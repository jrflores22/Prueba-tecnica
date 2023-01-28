using WebApplication3.Business.Repository;

namespace WebApplication3.Business.Service.Impl
{
    public class EjemploService : IEjemploService
    {
        private readonly IEjemploRepository _ejemploRepository;

        public EjemploService(IEjemploRepository ejemploRepository)
        {
            _ejemploRepository = ejemploRepository;
        }

        public Models.ExampleResponse PostEjemploService(Models.ExampleSNS ejemplo)
        {
            var instance = _ejemploRepository.EjemploTest(ejemplo);
            var response = new Models.ExampleResponse
            {
                InstanceId = instance
            };

            return response;
        }


    }
}