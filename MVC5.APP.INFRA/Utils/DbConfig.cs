using System.Data.Entity;

namespace MVC5.APP.INFRA.Utils
{
    public class DbConfig : DbConfiguration
    {
        public DbConfig()
        {
            SetDatabaseLogFormatter(
                (context, writeAction) => new LogFormatter(context, writeAction));
        }
    }
}
