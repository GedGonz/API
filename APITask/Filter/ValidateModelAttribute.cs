using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.ModelBinding;


namespace APITask.Filter
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.ModelState.IsValid == false)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(
                    HttpStatusCode.BadRequest, actionContext.ModelState);
                //actionContext.Response = actionContext.Request.CreateErrorResponse(
                //      HttpStatusCode.BadRequest, "An error occurred, please try again or contact the administrator.");
            }
        }
       
    }

    public class ExcepciontAttribute : ExceptionFilterAttribute
    {
        
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is Exception)
            {
                actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(
                    HttpStatusCode.BadRequest, actionExecutedContext.Exception.Message);
            }
     
        }

    }
}