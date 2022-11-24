using ActionFilterDemo.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterDemo.ActionFilters
{
    public class MerchantCodeActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var key = "merchantCode";

            //get data
            var routeData = context.RouteData.Values[key];


            //set data
            var baseRequest = context.ActionArguments.
                FirstOrDefault(i => i.Value != null && typeof(MerchantBaseRequest)
                                                        .IsAssignableFrom(i.Value.GetType()));

            if(baseRequest.Value is not null)
            {
                var req = (MerchantBaseRequest)baseRequest.Value;
                req.MerchantCode = routeData.ToString();
            }
            else
            {
                if (!context.ActionArguments.ContainsKey(key))
                {
                    context.ActionArguments.Add(key, routeData);
                }
                else
                    context.ActionArguments[key] = routeData;
            }


            await next();
        }
    }
}
