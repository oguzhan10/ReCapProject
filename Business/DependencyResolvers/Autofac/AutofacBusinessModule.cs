using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {

        //proje ilk çalıştığında burası çalışıyor 
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance(); //services.AddSingleton<ICarService, CarManager>(); aynısı
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();
        }
    }
}
