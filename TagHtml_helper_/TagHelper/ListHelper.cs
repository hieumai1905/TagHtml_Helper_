using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHtml_helper_.TagHelper;

[HtmlTargetElement("mylist")]
public class ListHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
{
    // Thuộc tính sẽ là title
    public string Title { get; set; }

    // Thuộc tính sẽ là list-items
    public List<string> ListItems {set; get;}

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "ul";    // ul sẽ thay cho myul
        output.TagMode = TagMode.StartTagAndEndTag;     // nó cho biết rằng đối tượng đầu ra sẽ tạo ra cặp thẻ mở và đóng cho các phần tử đầu ra.

        output.Attributes.SetAttribute("class", "list-group");     // thiết lập thuộc tính class cho phần tử
        output.PreElement.AppendHtml($"<h2>{Title}</h2>");     // thêm một đoạn mã html vào phần tử thực tế tạo ra.


        StringBuilder content = new StringBuilder();     // đoạn mã html được thêm vào thuộc tính Content.
        foreach (var item in ListItems)
        {
            content.Append($@"<li class=""list-group-item"">{item}</li>");
        }
        output.Content.SetHtmlContent(content.ToString());
    }

}