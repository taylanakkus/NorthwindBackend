using Core.Utilities.Results;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IProductService
	{
		IDataResult<Product> GetById(int productId);
		IDataResult<List<Product>> GetList();
		IDataResult<List<Product>> GetListByCategory(int categoryById);
		IResult Add(Product product);
		IResult Delete(Product product);
		IResult Update(Product product);
	}
}
