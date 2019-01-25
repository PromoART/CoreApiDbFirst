using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Core;
using Core.Entities;

namespace Services
{
    public class DataProviderInterceptor:IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {

            var session = SessionFactory.OpenSession();
            try
            {
                invocation.Proceed();
            }
            finally
            {
                session.Close();
            }
        }
    }
}
