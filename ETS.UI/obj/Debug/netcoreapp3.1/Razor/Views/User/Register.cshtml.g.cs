#pragma checksum "C:\Users\ext02d19216\source\repos\ETSHomework\ETS.UI\Views\User\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21c3f4e1e4adc70484b6c6c39cca3d43df3e9a8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Register), @"mvc.1.0.view", @"/Views/User/Register.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ext02d19216\source\repos\ETSHomework\ETS.UI\Views\_ViewImports.cshtml"
using ETS.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ext02d19216\source\repos\ETSHomework\ETS.UI\Views\_ViewImports.cshtml"
using ETS.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c3f4e1e4adc70484b6c6c39cca3d43df3e9a8c", @"/Views/User/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb3d34ce0006d6f54e5b98f15b4e20cb5390dc8", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ETS.UI.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ext02d19216\source\repos\ETSHomework\ETS.UI\Views\User\Register.cshtml"
  
    ViewData["Title"] = "ETS Homework Register Page";
    List<SelectListItem> bloodGroups = new List<SelectListItem>();
    bloodGroups.Add(new SelectListItem
    {
        Text = "A RH -",
        Value = "A-"
    });
    bloodGroups.Add(new SelectListItem
    {
        Text = "A RH +",
        Value = "A+",
    });
    bloodGroups.Add(new SelectListItem
    {
        Text = "B RH -",
        Value = "B-"
    });
    bloodGroups.Add(new SelectListItem
    {
        Text = "B RH +",
        Value = "B+"
    });
    bloodGroups.Add(new SelectListItem
    {
        Text = "AB RH -",
        Value = "AB-"
    });
    bloodGroups.Add(new SelectListItem
    {
        Text = "AB RH +",
        Value = "AB+"
    });
    bloodGroups.Add(new SelectListItem
    {
        Text = "O RH -",
        Value = "O-"
    });
    bloodGroups.Add(new SelectListItem
    {
        Text = "O RH +",
        Value = "O+"
    });

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n");
#nullable restore
#line 49 "C:\Users\ext02d19216\source\repos\ETSHomework\ETS.UI\Views\User\Register.cshtml"
     using (Html.BeginForm("Register", "User", FormMethod.Post, new { @id = "userRegisterForm" }))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"name\">Name</label>\r\n            ");
#nullable restore
#line 54 "C:\Users\ext02d19216\source\repos\ETSHomework\ETS.UI\Views\User\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Name, new { @id = "name", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"surname\">Surname</label>\r\n            ");
#nullable restore
#line 59 "C:\Users\ext02d19216\source\repos\ETSHomework\ETS.UI\Views\User\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Surname, new { @id = "surname", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"bloodgroup\">Blood Group</label>\r\n            ");
#nullable restore
#line 64 "C:\Users\ext02d19216\source\repos\ETSHomework\ETS.UI\Views\User\Register.cshtml"
       Write(Html.DropDownListFor(model => model.BloodGroup, bloodGroups, "Select Blood Group", new { @id = "bloodGroup", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"phone\">Phone</label>\r\n            ");
#nullable restore
#line 70 "C:\Users\ext02d19216\source\repos\ETSHomework\ETS.UI\Views\User\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Phone, new { @id = "phone", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label for=\"phone\">Adress</label>\r\n            ");
#nullable restore
#line 75 "C:\Users\ext02d19216\source\repos\ETSHomework\ETS.UI\Views\User\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Address, new { @id = "address", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <button type=\"button\" class=\"btn btn-success\" onclick=\"UserRegister()\">Submit</button>\r\n");
#nullable restore
#line 78 "C:\Users\ext02d19216\source\repos\ETSHomework\ETS.UI\Views\User\Register.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


</div>

<script>
    document.getElementById('phone').addEventListener('input', function (e) {
        $('#phone').removeClass(""border border-danger"");
        var x = e.target.value.replace(/\D/g, '').match(/(\d{0,3})(\d{0,3})(\d{0,4})/);
        e.target.value = !x[2] ? x[1] : '(' + x[1] + ') ' + x[2] + (x[3] ? '-' + x[3] : '');
    });
    document.getElementById('address').addEventListener('input', function (e) {
        $('#address').removeClass(""border border-danger"");
    });
    document.getElementById('name').addEventListener('input', function (e) {
        $('#name').removeClass(""border border-danger"");
    });
    document.getElementById('surname').addEventListener('input', function (e) {
        $('#surname').removeClass(""border border-danger"");
    });
    document.getElementById('bloodGroup').addEventListener('input', function (e) {
        $('#bloodGroup').removeClass(""border border-danger"");
    });

    function UserRegister() {
        var isValid = true;
       ");
            WriteLiteral(@" isValid = RunValidations();
        if (isValid) {
            var userDto = {
                Name: $('#name').val(),
                Surname: $('#surname').val(),
                BloodGroup: $('#bloodGroup').val(),
                Address: $('#address').val(),
                Phone: $('#phone').val()
            };
            $.ajax({
                url: ""/User/Register"",
                type: ""POST"",
                data: { ""user"": userDto },
                success: function (data) {
                    alert(data);
                },
                error: function () {
                    alert('Error occured');
                }
            })
        }
    }

    function RunValidations() {
        var textIsValid = CheckIfTheTextFieldIsEmpty();
        var checkIsValid = CheckIstheSelectFieldIsEmpty('bloodGroup');
        return textIsValid == true && checkIsValid == true ? true : false;
    }
    function CheckIfTheTextFieldIsEmpty() {
        var isValid = true;
   ");
            WriteLiteral(@"     $('input[type=text]').each(function () {
            var text = $(this).val();
            if (text == null || text === """") {
                $(this).addClass(""border border-danger"");
                $(this).attr(""placeholder"", ""type some text"");
                isValid = false;
            }
        });
        return isValid;
    }
    function CheckIstheSelectFieldIsEmpty(id) {
        var isValid = true;
        var element = $(""#"" + id + """");
        var choice = element.val();

        if (choice == null || choice === """") {

            $('#' + id + '').addClass(""border border-danger"");
            $('#' + id + '').attr(""placeholder"", ""type some text"");
            isValid = false;

        }
        return isValid;
    }

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ETS.UI.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591