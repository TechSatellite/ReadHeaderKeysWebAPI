using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace ReadHeaderWebAPI
{
    public class HeaderFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            string tokenKey = "Token-X-Key";
            string tokenVal = string.Empty;
            IEnumerable<string> keys = null;
            if (actionContext.Request.Headers.TryGetValues(tokenKey, out keys))
            {
                tokenVal = keys.First();
            }
            else
            {
                tokenVal = "";
            }
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
           
        }
    }
}