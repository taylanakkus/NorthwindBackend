using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Business.Concrete
{
	public class ProductManager : IProductService
	{
		private IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}
		public IResult Add(Product product)
		{
			_productDal.Add(product);
			return new SuccessResult("The product has been added successfully.");
		}

		public IResult Delete(Product product)
		{
			_productDal.Delete(product);
			return new SuccessResult("The product has been deleted successfully.");
		}
		public IResult Update(Product product)
		{
			_productDal.Update(product);
			return new SuccessResult("The product has been updated successfully.");
		}
		public IDataResult<Product> GetById(int productId)
		{
			return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
		}

		public IDataResult<List<Product>> GetList()
		{
			return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
		}

		public IDataResult<List<Product>> GetListByCategory(int categoryById)
		{
			return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == categoryById).ToList());
		}

	}
}
