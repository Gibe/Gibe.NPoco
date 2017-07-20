using System.Data;
using NPoco;

namespace Gibe.NPoco.UnitOfWork
{
  public class NPocoUnitOfWork : IUnitOfWork
  {
    private readonly ITransaction _petaTransaction;
    private readonly IDatabase _database;
	  
		public NPocoUnitOfWork(IDatabaseProvider databaseProvider)
    {
      _database = databaseProvider.GetDatabase();
      _petaTransaction = _database.GetTransaction(IsolationLevel.ReadUncommitted);
    }

    public void Dispose()
    {
      _petaTransaction.Dispose();
    }

    public IDatabase Database
    {
      get { return _database; }
    }

    public void Commit()
    {
      _petaTransaction.Complete();
    }
  }
}
