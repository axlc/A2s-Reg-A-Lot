// Axl McCracken
// COSC-2330-001, Group A2
// DBOQuery.cs
// This class is an abstraction of the C# functions for database interaction
// that will relieve the user of the need to write SQL statements, and allow
// them to focus on making their code work.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace A2_Reg_A_Lot_2017
{
    /// DBOQuery - Work In Progress. I had to leave work early since I got too many hours.
    public sealed class DBOQuery
    {
        private SqlConnection connection;

        protected string Server { get;  private set; }
        protected string DatabaseName { get; set; }
        private string UserID { get; set; }
        private string Password { get; set; }

        public DBOQuery()
        {
            
        } 

    }
}
