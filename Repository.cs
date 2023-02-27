using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban
{
    public class Repository : DbContext
    {
        private static MySqlConnection _databaseConnection;
        public DbSet<Task> Tasks { get; set; }
        public Repository() : base(GetDbConnection(), false)
        {
            Database.CreateIfNotExists();
        }
        // Singleton for DB
        public static MySqlConnection GetDbConnection()
        {
            if (_databaseConnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ProgVisConnectionString"].ConnectionString;
                _databaseConnection = new MySqlConnection(connectionString);
            }
            return _databaseConnection;
        }
    }
}
