using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfiguringApps.Infranstructure
{
    public class BrowserTypeMiddleware
    {
        private RequestDelegate nextDelegate;
        public BrowserTypeMiddleware(RequestDelegate next)
        {
            nextDelegate = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Items["IEBrowser"] = httpContext.Request.Headers["User-Agent"].Any(v => v.ToLower().Contains("trident")||v.ToLower().Contains("edge"));
            await nextDelegate.Invoke(httpContext);
        }
    }
}
