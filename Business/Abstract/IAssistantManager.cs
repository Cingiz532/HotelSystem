using Core.Helpers.Results.Abstract;
using Entitties.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAssistantManager
    {
        IResult Add(Assistant assistant);
        IResult Delete(int id);
        void Update(Assistant assistant);
        IDataResult<List<Assistant>> GetAll();
        IDataResult<Assistant> GetById(int id);
    }
}
