using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPoco;

namespace Gibe.NPoco
{
	public class DefaultDatabaseProvider : IDatabaseProvider
	{
		private readonly string _connectionString;

		public DefaultDatabaseProvider(string connectionString)
		{
			_connectionString = connectionString;
		}

		public IDatabase GetDatabase()
		{
			return new Database(_connectionString);
		}
	}
}
