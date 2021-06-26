using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpWebAPI.Repo
{
	public interface IDataRepository<TEntity>
	{
		IEnumerable<TEntity> GetAll();
		TEntity Get(int Id);
		TEntity Add(TEntity entity);
		TEntity Update(TEntity entity);
		TEntity Delete(int Id);
	}
}
