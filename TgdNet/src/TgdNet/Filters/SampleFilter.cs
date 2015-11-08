using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TgdNet.Filters
{
    using Microsoft.AspNet.Mvc;
    public class SampleFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            base.OnResultExecuted(context);
        }
    }
}
