using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TagHtml_helper_.Views.Home;

public class Demo : PageModel
{
    [DisplayName("Tên người dùng")] public string UserName { get; set; } = "xuanthulab";

    public void OnGet()
    {
    }
}