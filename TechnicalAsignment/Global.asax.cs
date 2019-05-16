using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using TechnicalAsignment.Data;
using TechnicalAsignment.Domain.DTO;

namespace TechnicalAsignment
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            InitializeAutoMapper();
        }

        private void InitializeAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Transaction, TransactionDTO>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });
        }
    }
}
