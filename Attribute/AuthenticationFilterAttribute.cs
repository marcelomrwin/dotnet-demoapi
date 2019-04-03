using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Filters;
using demoapi.Exceptions;
using System.Net;

namespace demoapi.Attribute{
    public class AuthenticationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext ctx)
        {
            string authKey = ctx.HttpContext.Request
                    .Headers["Authorization"].SingleOrDefault();
 
            if (string.IsNullOrWhiteSpace(authKey))
                throw new HttpException(HttpStatusCode.Unauthorized);
        }
    }
}