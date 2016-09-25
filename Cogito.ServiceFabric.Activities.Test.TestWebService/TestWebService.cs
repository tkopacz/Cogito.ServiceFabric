﻿using System;
using System.Fabric;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;

namespace Cogito.ServiceFabric.Activities.Test.TestWebService
{

    sealed class TestWebService :
        Cogito.ServiceFabric.Http.OwinStatelessService
    {

        public TestWebService(StatelessServiceContext context)
            : base(context, "cogito-activities-test")
        {

        }

        //protected override void Configure(global::Owin.IAppBuilder appBuilder)
        //{
        //    var http = new HttpConfiguration();
        //    http.MapHttpAttributeRoutes();
        //    appBuilder.UseWebApi(http);
        //}

        protected override Task OnRequest(IOwinContext context, Func<Task> next)
        {
            return base.OnRequest(context, next);
        }

    }

}
