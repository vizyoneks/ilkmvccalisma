using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelper.TagHelpers
{
    [HtmlTargetElement("ul",Attributes ="items")]
    public class ListGroupTagHelper : TagHelper
    {
        public List<string> Items { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            foreach (var item in Items)
            {
                TagBuilder li = new TagBuilder("li");
                li.InnerHtml.Append(item);
                output.Content.AppendHtml(li);
            }
        }
    }
}
