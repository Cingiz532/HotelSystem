using Core.Helpers.Results.Abstract;
using Entitties.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductManager
    {
        IResult Add(Product product );
        IResult Delete(int id);
        void Update(Product product);
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int id);
    }
}
