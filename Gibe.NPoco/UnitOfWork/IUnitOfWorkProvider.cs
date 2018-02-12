using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gibe.NPoco.UnitOfWork
{
  public interface IUnitOfWorkProvider
  {
    IUnitOfWork GetUnitOfWork();
  }

	public class FakeUnitOfWorkProvider : IUnitOfWorkProvider
	{
		private readonly Func<IUnitOfWork> _uowProvider;

		public FakeUnitOfWorkProvider(Func<IUnitOfWork> uowProvider)
		{
			_uowProvider = uowProvider;
		}

		public IUnitOfWork GetUnitOfWork() => _uowProvider();
	}
}
