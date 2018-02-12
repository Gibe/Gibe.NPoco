using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPoco;

namespace Gibe.NPoco.UnitOfWork
{
  public interface IUnitOfWork : IDisposable
  {
    void Commit();
    IDatabase Database { get; }
  }

	public class FakeUnitOfWork : IUnitOfWork
	{
		private readonly Func<IDatabase> _dbProvider;
		private readonly Action _onDispose;
		private readonly Action _onCommit;

		public FakeUnitOfWork(Func<IDatabase> dbProvider, Action onDispose, Action onCommit)
		{
			_dbProvider = dbProvider;
			_onDispose = onDispose;
			_onCommit = onCommit;
		}

		public void Dispose() => _onDispose();
		public void Commit() => _onCommit();

		public IDatabase Database => _dbProvider();
	}
}
