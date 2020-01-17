using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Utility
{
    public static class ConnectionString
    {
        private static string connectionName = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employee;Integrated Security=True";

        public static string ConnectionName { get => connectionName; set => connectionName = value; }

    }
}
