using System.Data.Common;

namespace CRUDTRES.Data
{
    public interface ISqlConnectionFactory
    {
        DbConnection GetDBconnection();
    }
}