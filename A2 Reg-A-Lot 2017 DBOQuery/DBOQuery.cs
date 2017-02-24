// Axl McCracken
// COSC-2330-001, Group A2
// DBOQuery.cs
//
// This class is an abstraction of the C# functions for database interaction
// that will relieve the user of the need to write SQL statements, and allow
// them to focus on making their code work.
//
// Work In Progress. Look for posts on Trello board for updates on this project.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace A2_Reg_A_Lot_2017
{
    /// <summary>
    /// Axl's Class. Abstracts away the process of opening and querying the database. This class cannot be inherited.
    /// </summary>
    /// <remarks></remarks>
    public sealed class DBOQuery
    {
        private SqlConnection Connection;

        /// <summary>
        /// The Default Constructor. Automatically sets the ConnectionString to the project database.
        /// <para>TODO: Update his once we receive the login details.</para>
        /// </summary>
        public DBOQuery()
        {
            Connection = new SqlConnection();
            Connection.ConnectionString = "Server=cis1.actx.edu;Database=project;User Id=db2;Password=db20;";
        }
        
        /// <summary>
        /// <para>An overloaded Constructor which allows you to specify the login credentials.</para>
        /// <para>Useful for testing specifying connection information if we get an Azure Cloud
        /// server set up before the project is due.</para>
        /// </summary>
        public DBOQuery(string server, string databaseName, string userID, string password)
        {
            Connection = new SqlConnection();
            Connection.ConnectionString = string.Format("Server={0};Database={1};User ID={2};Password={3}", server, databaseName, userID, password);
        }

        //TODO: Add functions to handle opening and closing the connection.
    }
}
