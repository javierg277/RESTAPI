using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using Sepalo.WebApi.Admin.Repository.Types;
using System;
using System.Data;
using System.Data.SqlClient;
using Npgsql;
namespace Sepalo.WebApi.Admin.Repository
{
    /// <summary>
    /// Base repository class for DB connection and its type
    /// </summary>
    public class BaseRepository : IDisposable
    {
        //Data base connection
        protected IDbConnection _dbConnection;
        //Data base connection type
        protected DBConnectionType _dbConnectionType;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repositoryName">Name of the entity repository using this base</param>
        /// <param name="configuration">Auto injected settigns configuration</param>
        public BaseRepository(string repositoryName, IConfiguration configuration)
        {
            string defaultConnectionId = configuration.GetValue($"Repositories:Default", "OracleCOROLA");
            string connectionId = configuration.GetValue($"Repositories:{repositoryName}:DBConnectionId", defaultConnectionId);
            string connectionString = configuration.GetValue<string>($"DBConnections:{connectionId}:ConnectionString");
            _dbConnectionType = configuration.GetValue<DBConnectionType>($"DBConnections:{connectionId}:Type");
            switch (_dbConnectionType)
            {
                case DBConnectionType.Oracle:
                    _dbConnection = new OracleConnection(connectionString);
                    break;
                case DBConnectionType.SqlServer:
                    _dbConnection = new SqlConnection(connectionString);
                    break;
                case DBConnectionType.Postgre:
                    _dbConnection = new NpgsqlConnection(connectionString);
                    break;
            }
        }
        void IDisposable.Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
