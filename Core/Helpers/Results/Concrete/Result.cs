using Core.Helpers.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool issucces , string message) : this(issucces)
        {
            Message = message ;
        }
        public Result(bool issuccess )
        {
            IsSuccess=issuccess ;
        }
        public bool IsSuccess { get; }
        public string  Message { get; }
    }
}
