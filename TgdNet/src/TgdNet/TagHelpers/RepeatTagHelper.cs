using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TgdNet.TagHelpers
{
    using Microsoft.AspNet.Razor.Runtime.TagHelpers;

    public class RepeatTagHelper : TagHelper
    {
        public int Count { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            for (var i = 0; i < this.Count; i++)
            {
                var html = await context.GetChildContentAsync(false);
                output.Content.Append(html);
            }

        }
    }
}
