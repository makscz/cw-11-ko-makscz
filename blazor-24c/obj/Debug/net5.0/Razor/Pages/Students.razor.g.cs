#pragma checksum "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dc98a5190bd7c40bbf3e077f12bb113551538d3"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-zr4hfffqtd>Students 22</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "b-zr4hfffqtd");
            __builder.OpenElement(3, "tr");
            __builder.AddAttribute(4, "b-zr4hfffqtd");
            __builder.OpenElement(5, "th");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
                        () => Sort("Avatar")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-zr4hfffqtd");
            __builder.AddContent(8, "Avatar");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "th");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
                        () => Sort("FirstName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "b-zr4hfffqtd");
            __builder.AddContent(13, "FirstName");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "th");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
                        () => Sort("LastName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "b-zr4hfffqtd");
            __builder.AddContent(18, "LastName");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "th");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
                        () => Sort("Birthdate")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "b-zr4hfffqtd");
            __builder.AddContent(23, "Birthdate");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "th");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
                        () => Sort("Studies")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "b-zr4hfffqtd");
            __builder.AddContent(28, "Studies");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.AddMarkupContent(30, "<th b-zr4hfffqtd>Actions</th>");
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
     foreach(var stud in StudentsList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "tr");
            __builder.AddAttribute(32, "b-zr4hfffqtd");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "b-zr4hfffqtd");
#nullable restore
#line 20 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
__builder.AddContent(35, stud.Avatar);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "b-zr4hfffqtd");
#nullable restore
#line 21 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
__builder.AddContent(39, stud.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "b-zr4hfffqtd");
#nullable restore
#line 22 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
__builder.AddContent(43, stud.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "b-zr4hfffqtd");
#nullable restore
#line 23 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
__builder.AddContent(47, stud.Birthdate.ToLongDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "b-zr4hfffqtd");
#nullable restore
#line 24 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
__builder.AddContent(51, stud.Studies);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "td");
            __builder.AddAttribute(54, "b-zr4hfffqtd");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
                                  (() => Delete(stud.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "b-zr4hfffqtd");
            __builder.AddContent(58, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
                                  (() => ShowDetails(stud.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "b-zr4hfffqtd");
            __builder.AddContent(63, "Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\maksc\OneDrive\Pulpit\gicik\cw-11-ko-makscz\blazor-24c\Pages\Students.razor"
       
    public List<Student> StudentsList { get; set; }
    public KeyValuePair<string, bool> ColumnSort { get; set; } = new KeyValuePair<string, bool>("", false);

    private void Sort(string columnName)
    {
        if(ColumnSort.Key != columnName)
        {
            ColumnSort = new KeyValuePair<string, bool>(columnName, false);
        } else
        {
            ColumnSort = new KeyValuePair<string, bool>(columnName, !ColumnSort.Value);
        }

        if (ColumnSort.Value)
        {
            SortListAsc(columnName);
        }else
        {
            SortListDesc(columnName);
        }
    }

    private void SortListDesc(string columnName)
    {
        StudentsList = StudentsList.OrderByDescending(e => e.GetType().GetProperty(columnName).GetValue(e, null)).ToList();
    }

    private void SortListAsc(string columnName)
    {
        StudentsList = StudentsList.OrderBy(e => e.GetType().GetProperty(columnName).GetValue(e, null)).ToList();
    }

    protected override void OnInitialized()
    {
        StudentsList = StudentService.GetStudents();
    }

    private async Task Delete(int id)
    {
        var result =await js.InvokeAsync<bool>("confirm", "Are you sure?");
        if (result)
        {
            StudentService.Remove(id);
        }
    }

    private void ShowDetails(int id)
    {
        navigator.NavigateTo("/students/" + id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591
