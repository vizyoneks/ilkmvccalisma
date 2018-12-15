using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelper.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string MailTo { get; set; }
        public string ImagePath { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            var emailAdress = MailTo;

            output.Attributes.SetAttribute("href", $"mailto:{emailAdress}");

            if(!string.IsNullOrWhiteSpace(ImagePath))
            {
                output.Content.SetContent($"<img src='{ImagePath}' />");
            }
            else
            {
                output.Content.SetContent(emailAdress);
            }
            

            base.Process(context, output);
        }
    }
}
