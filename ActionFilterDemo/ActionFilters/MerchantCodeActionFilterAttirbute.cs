using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterDemo.ActionFilters
{
    public class MerchantCodeActionFilterAttirbute:ActionFilterAttribute
    {
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            return base.OnActionExecutionAsync(context, next);
        }
    }
}
