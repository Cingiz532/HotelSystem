using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dependency.autofac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductManager>().SingleInstance();
            builder.RegisterType<ProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<AssistantManager>().As<IAssistantManager>().SingleInstance();
            builder.RegisterType<AssistantDal>().As<IAssistantDal>().SingleInstance();
        }
    }
}
