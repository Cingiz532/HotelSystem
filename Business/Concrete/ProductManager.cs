using Business.Abstract;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using DataAccess.Abstract;
using Entitties.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Update
namespace Business.Concrete
{
    public class ProductManager(IProductDal productDal) : IProductManager
    {
        private readonly IProductDal _productDal=productDal;
        public IResult Add(Product product)
        {
             if(product.PrName.Length>5 && product.PrPrice>100)
            {
                _productDal.Add(product);
                return new SuccessResult("Mehsul ugurla elave olundu...");
            }
             else
            {
                return new ErrorResult("Ad uzunlugu 5-den cox olmalidir");
            }
        }

        public IResult Delete(int id)
        {
            var products = _productDal.GetById(p => p.Id == id && p.IsActive==true);
            if (products != null)
            { 
                _productDal.Delete(products);
                return new SuccessResult("Mehsul ugurla silindi...");
            }
            else
            {
                return new ErrorResult("Mehsul tapilmadi...");
            }
          
        }
        public IDataResult<List<Product>> GetAll()
        {
            List<Product> products = _productDal.GetAll(p=>p.IsActive==true);
            if(products.Count>0)
            {
                return new SuccessDataResult<List<Product>>("Mehsullarin siyahisi ugurla hazirlandi...",products);
            }
            else
            {
                return new ErrorDataResult<List<Product>>("Xeta bash verdi",products);
            }
        }

        public IDataResult<Product> GetById(int id)
        {
            var result = _productDal.GetById(p => p.Id == id && p.IsActive==true);
            if(result != null)
            {
                return new SuccessDataResult<Product>("Mehsul tapildi...",result);
            }
            else
            {
                return new ErrorDataResult<Product>("Mehsul tapilmadi...",result);
            }
        }

        public void Update(Product product)
        {
            var exist = _productDal.GetById(p=>p.Id==product.Id);
            if(exist != null)
            {
                _productDal.Update(exist);
            }
            else
            {
                throw new Exception("P.Invalid Operation...");
            }
        }
    }
}
