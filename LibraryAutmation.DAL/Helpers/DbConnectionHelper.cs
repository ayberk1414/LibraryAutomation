using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView.DAL.Helpers
{
    public class DbConnectionHelper
    {
        public SqlConnection Connection => GetConnection();
        private SqlConnection GetConnection()
        {
            return new SqlConnection("Server=(localdb)\\MSSQLLocalDb; Database=LibraryAutomationDb; integrated security=true;");
          
        }

    }
}
