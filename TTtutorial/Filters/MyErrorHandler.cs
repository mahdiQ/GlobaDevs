using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TTtutorial.Filters
{
    class MyErrorHandler : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Log(filterContext.Exception);

            base.OnException(filterContext);
        }

        private void Log(Exception exception)
        {
            //log exception here..

        }
    }
}