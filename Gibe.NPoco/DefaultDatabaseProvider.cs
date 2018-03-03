using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using NPoco;

namespace Gibe.NPoco
{
	public class DefaultDatabaseProvider : IDatabaseProvider
	{
#if NET45
		private readonly string _connectionStringName;

		public DefaultDatabaseProvider(string connectionStringName)
		{
			_connectionStringName = connectionStringName;
		}


		public IDatabase GetDatabase()
		{
			return new Database(_connectionStringName);
		}
#endif

#if NETCORE
		private readonly string _connectionString;
		private readonly DatabaseType _databaseType;

		public DefaultDatabaseProvider(string connectionString, DatabaseType databaseType)
		{
			_connectionString = connectionString;
			_databaseType = databaseType;
		}
		
		public IDatabase GetDatabase()
		{
			return new Database(_connectionString, _databaseType, SqlClientFactory.Instance);
		}
#endif
	}
}
