using NPoco;

namespace Gibe.NPoco
{
	public interface IDatabaseProvider
	{
		IDatabase GetDatabase();
	}

	public class FakeDatabaseProvider : IDatabaseProvider
	{
		private readonly IDatabase _database;

		public FakeDatabaseProvider(IDatabase database)
		{
			_database = database;
		}
		
		public IDatabase GetDatabase()
		{
			return _database;
		}
	}
}
