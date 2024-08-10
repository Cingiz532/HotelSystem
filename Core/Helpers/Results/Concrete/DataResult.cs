using Core.Helpers.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Results.Concrete
{
    public class DataResult<T> : Result , IDataResult<T>
    {
        public DataResult(bool issuccess, string message, T data  ) : base(issuccess,message)
        {
            Data = data;
        }
        public DataResult(bool issucces , T data) : base(issucces)
        {
            Data=data;
        }
        public T Data { get; }
    }
}
