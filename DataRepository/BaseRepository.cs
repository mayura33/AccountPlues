using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
	public class BaseRepository
	{
		protected SqlConnection con;

		public BaseRepository()
		{
			con = new SqlConnection(ConfigurationManager.ConnectionStrings["localDbConnectionString"].ConnectionString);
		}

		public SqlCommand GetCommand(string commandName)
		{
			SqlCommand cmd = new SqlCommand(commandName, con);
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			cmd.Connection.Open();
			return cmd;
		}

		public DataTable GetCommandDataTable(SqlCommand cmd)
		{
			
			SqlDataReader rdr = cmd.ExecuteReader();
			DataTable dataTable = new DataTable();
			dataTable.Load(rdr);
			con.Close();
			return dataTable;
		}
		
	}
}
