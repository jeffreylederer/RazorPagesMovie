using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;


namespace RazorPagesMovie.TagHelpers
{
    [HtmlTargetElement("text-file")]
    public class TextFileHelper : TagHelper
    {
         public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var content = await output.GetChildContentAsync();
            var target = content.GetContent();
            output.Content.SetHtmlContent(target.Replace("<", "&lt;").Replace(">", "&gt;").Replace("\r\n", "<br/>"));
        }
    }
}
