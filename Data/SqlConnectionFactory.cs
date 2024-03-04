using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTRES.Data
{
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public SqlConnectionFactory(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public DbConnection GetDBconnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("NorthwindConnectionString"));
        }
    }
}
