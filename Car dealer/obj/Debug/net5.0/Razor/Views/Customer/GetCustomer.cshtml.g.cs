#pragma checksum "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "834135f9692e9882c67026339bc6513fc4952d32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_GetCustomer), @"mvc.1.0.view", @"/Views/Customer/GetCustomer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834135f9692e9882c67026339bc6513fc4952d32", @"/Views/Customer/GetCustomer.cshtml")]
    public class Views_Customer_GetCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CarDealerDataLayer.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div><b>Customer table</b><br /></div>
<table class=""table table-bordered table-responsive table-hover"">
    <tr>
        <th>First Name </th>
        <th>Last Name </th>
        <th>Age</th>
        <th>Address</th>
        <th>Created</th>
    </tr>
");
#nullable restore
#line 13 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"
     foreach (var customer in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"
           Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"
           Write(customer.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"
           Write(customer.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <table>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"
                       Write(customer.Address.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"
                       Write(customer.Address.HouseNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"
                       Write(customer.Address.Town);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"
                       Write(customer.Address.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"
                       Write(customer.Address.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"
           Write(customer.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a class=\"btn btn-sm btn-simple\"");
            BeginWriteAttribute("href", " href=\"", 1247, "\"", 1286, 1);
#nullable restore
#line 44 "C:\Users\krkr\source\repos\Car dealer\Car dealer\Views\Customer\GetCustomer.cshtml"
WriteAttributeValue("", 1254, Url.Action("Index", "Customer"), 1254, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Back</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CarDealerDataLayer.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
