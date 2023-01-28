using System.Data.SqlClient;

namespace WebApplication3.Business.Repository.Impl
{
    public class EjemploRepository : IEjemploRepository
    {
        private readonly SqlConnection _sqlConnection;

        public EjemploRepository(SqlConnection connection)
        {
            _sqlConnection = connection;
        }

        public Models.TypeAttributes EjemploTest(Models.ExampleSNS ejemplo)
        {
            return ejemplo.MessageAttributes.InstanceId;
        }
    }
}