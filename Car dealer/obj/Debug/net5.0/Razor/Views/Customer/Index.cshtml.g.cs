#pragma checksum "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "802851d36a01c3f89ce73f6b6e59e485649a1cc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"802851d36a01c3f89ce73f6b6e59e485649a1cc3", @"/Views/Customer/Index.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car_dealer.ViewModels.CustomerSubmitForm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\Index.cshtml"
 using (Html.BeginForm("GetCustomer", "Customer", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table cellpadding=\"0\" cellspacing=\"0\">\r\n    <tr>\r\n        <th colspan=\"2\" align=\"center\">Search customer</th>\r\n    </tr>\r\n    <tr>\r\n        <td>Name: </td>\r\n        <td>");
#nullable restore
#line 11 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Street: </td>\r\n        <td>\r\n            ");
#nullable restore
#line 16 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Car model: </td>\r\n        <td>\r\n            ");
#nullable restore
#line 22 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Car make: </td>\r\n        <td>\r\n            ");
#nullable restore
#line 28 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Car make: </td>\r\n        <td>\r\n            ");
#nullable restore
#line 34 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Sales person: </td>\r\n        <td>\r\n            ");
#nullable restore
#line 40 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\Index.cshtml"
       Write(Html.TextBoxFor(m => m.SalePersonsName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td></td>\r\n        <td><input type=\"submit\" value=\"Submit\" /></td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 48 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car_dealer.ViewModels.CustomerSubmitForm> Html { get; private set; }
    }
}
#pragma warning restore 1591