using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using MySql.Data.MySqlClient;

namespace EntityFrameworkTest
{
    internal class Program : DbContext
    {
        public static void Main(string[] args)
        {
            DbConnection db = new MySqlConnection();
        }
    }
}