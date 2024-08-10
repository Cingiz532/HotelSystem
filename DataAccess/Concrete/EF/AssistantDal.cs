using DataAccess.Abstract;
using Entitties.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class AssistantDal : BaseRepository<Assistant , ContextDB> , IAssistantDal
    {
    }
}
