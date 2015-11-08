using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TgdNet.Binders
{
    using Microsoft.AspNet.Mvc.ModelBinding;

    public class IPrincipalBinder : IModelBinder
    {
        public Task<ModelBindingResult> BindModelAsync(ModelBindingContext bindingContext)
        {
            var context = bindingContext.OperationBindingContext.HttpContext.User.Identity;
            var modelBindingResult = new ModelBindingResult(context,"Principal",true);
            return Task.FromResult(modelBindingResult);
        }
    }
}
