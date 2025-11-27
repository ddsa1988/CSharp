using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SportsStore.Models.ViewModels;

namespace SportsStore.Infrastructure;

[HtmlTargetElement("div", Attributes = "page-model")]
public class PageLinkTagHelper : TagHelper {
    private readonly IUrlHelperFactory _urlHelperFactory;
    [ViewContext] [HtmlAttributeNotBound] public ViewContext? ViewContext { get; set; }
    public PageInfo? PageInfo { get; set; }
    public string? PageAction { get; set; }

    public PageLinkTagHelper(IUrlHelperFactory urlHelperFactory) {
        _urlHelperFactory = urlHelperFactory;
    }

    public override void Process(TagHelperContext context, TagHelperOutput output) {
        if (ViewContext == null || PageInfo == null) return;

        IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
        var divTag = new TagBuilder("div");

        for (int i = 1; i < PageInfo.TotalPages; i++) {
            var anchorTag = new TagBuilder("a");
            anchorTag.Attributes["href"] = urlHelper.Action(PageAction, new { productPage = i });
            anchorTag.InnerHtml.Append(i.ToString());
            divTag.InnerHtml.AppendHtml(anchorTag);
        }

        output.Content.AppendHtml(divTag);
    }
}