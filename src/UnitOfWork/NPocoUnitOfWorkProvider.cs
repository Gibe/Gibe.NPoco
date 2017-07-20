namespace Gibe.NPoco.UnitOfWork
{
  public class NPocoUnitOfWorkProvider : IUnitOfWorkProvider
  {
	  private readonly IDatabaseProvider _databaseProvider;

		public NPocoUnitOfWorkProvider(IDatabaseProvider databaseProvider)
		{
			_databaseProvider = databaseProvider;
		}

    public IUnitOfWork GetUnitOfWork()
    {
			return new NPocoUnitOfWork(_databaseProvider);
    }
  }
}
