using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	class EfProductDal : IProductDal
	{
		public void Add(Product entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Product entity)
		{
			throw new NotImplementedException();
		}

		public Product Get()
		{
			throw new NotImplementedException();
		}

		public IList<Product> GetList(Expression<Func<Product, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(Product entity)
		{
			throw new NotImplementedException();
		}
	}
}
