#pragma checksum "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\StudentDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e0eb84c8147d2fc94c3e6bee424e6dab4dd2f93"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_24c.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\_Imports.razor"
using blazor_24c;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\_Imports.razor"
using blazor_24c.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\_Imports.razor"
using blazor_24c.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students/{ID:int}")]
    public partial class StudentDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-bjtie5lynq>StudentDetails</h3>\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "value", 
#nullable restore
#line 6 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\StudentDetails.razor"
               Student.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "disabled");
            __builder.AddAttribute(4, "b-bjtie5lynq");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "value", 
#nullable restore
#line 7 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\StudentDetails.razor"
               Student.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "disabled");
            __builder.AddAttribute(9, "b-bjtie5lynq");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "value", 
#nullable restore
#line 8 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\StudentDetails.razor"
               Student.Birthdate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "disabled");
            __builder.AddAttribute(14, "b-bjtie5lynq");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "value", 
#nullable restore
#line 9 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\StudentDetails.razor"
               Student.Studies

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "disabled");
            __builder.AddAttribute(19, "b-bjtie5lynq");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 10 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\StudentDetails.razor"
               Student.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "disabled");
            __builder.AddAttribute(24, "b-bjtie5lynq");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\StudentDetails.razor"
                  Return

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "b-bjtie5lynq");
            __builder.AddContent(29, "Return");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\StudentDetails.razor"
       

    [Parameter]
    public int ID { get; set; }
    public Student Student { get; set; }

    protected override void OnInitialized()
    {
        Student = StudentService.GetStudent(ID);
    }

    private void Return()
    {
        navigator.NavigateTo("/students");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591
