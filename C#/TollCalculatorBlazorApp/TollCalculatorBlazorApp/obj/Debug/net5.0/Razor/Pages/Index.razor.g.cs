#pragma checksum "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f377bf404c571d0a84bed592e404fd6b6dbb50b1"
// <auto-generated/>
#pragma warning disable 1591
namespace TollCalculatorBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\_Imports.razor"
using TollCalculatorBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\_Imports.razor"
using TollCalculatorBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
using TollCalculatorBlazorApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
using TollCalculatorBlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bodyContent");
            __builder.AddMarkupContent(2, "<div class=\"headerContent\"><h3>\r\n            Toll calculator Service\r\n        </h3>\r\n        <p>\r\n\r\n            Toll Calculation is based on customaized formula based on the vehcile type and the time of the toll record\r\n\r\n        </p></div>\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "tollContent");
            __builder.OpenElement(5, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 23 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                              enumModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "table");
                __builder2.AddAttribute(10, "class", "table");
                __builder2.OpenElement(11, "tbody");
                __builder2.OpenElement(12, "tr");
                __builder2.AddMarkupContent(13, "<td><label class=\"labelText\">\r\n                                    Vehicle type\r\n                                </label></td>\r\n                            ");
                __builder2.OpenElement(14, "td");
                __builder2.OpenElement(15, "select");
                __builder2.AddAttribute(16, "class", "textinput");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                                                 enumModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => enumModel = __value, enumModel));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 36 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                                     foreach (var value in Enum.GetValues(typeof(VehicleTypesEnum)))
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(19, "option");
                __builder2.AddContent(20, 
#nullable restore
#line 38 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                                                 value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 39 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n                        ");
                __builder2.OpenElement(22, "tr");
                __builder2.AddMarkupContent(23, "<td><label class=\"labelText\">\r\n                                    Toll Date\r\n                                </label></td>\r\n                            ");
                __builder2.OpenElement(24, "td");
                __Blazor.TollCalculatorBlazorApp.Pages.Index.TypeInference.CreateInputDate_0(__builder2, 25, 26, "textinput", 27, 
#nullable restore
#line 52 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                                                         tollDate

#line default
#line hidden
#nullable disable
                , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tollDate = __value, tollDate)), 29, () => tollDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n                        ");
                __builder2.OpenElement(31, "tr");
                __builder2.OpenElement(32, "td");
                __builder2.OpenElement(33, "label");
                __builder2.AddAttribute(34, "class", "labelText");
                __builder2.AddMarkupContent(35, "\r\n                                    Toll Time:  ");
                __builder2.AddContent(36, 
#nullable restore
#line 59 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                                                 getToll()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                            ");
                __builder2.OpenElement(38, "td");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "type", "time");
                __builder2.AddAttribute(41, "class", "textinput");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                                                           tollTime

#line default
#line hidden
#nullable disable
                , format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tollTime = __value, tollTime, format: "HH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenElement(45, "tr");
                __builder2.OpenElement(46, "td");
                __builder2.OpenElement(47, "button");
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                                                  appendNewTime

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "class", "button");
                __builder2.AddContent(50, "Register Time");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                            <td></td>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                        ");
                __builder2.OpenElement(53, "tr");
                __builder2.OpenElement(54, "td");
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                                                  showTotalToll

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "class", "button");
                __builder2.AddContent(58, "Calculate Total Toll");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                            ");
                __builder2.OpenElement(60, "td");
                __builder2.OpenElement(61, "label");
                __builder2.AddAttribute(62, "class", "textinput");
                __builder2.AddContent(63, 
#nullable restore
#line 79 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                                     totalTollFee

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "flex-item ");
            __builder.AddMarkupContent(67, "<label class=\"labelText\">\r\n                Rregistered Toll Times\r\n            </label>\r\n            <br>");
#nullable restore
#line 96 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
             foreach (var value in dates)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(68, "label");
            __builder.AddAttribute(69, "class", "textinput");
            __builder.AddContent(70, 
#nullable restore
#line 98 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
                                           value.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                <br>");
#nullable restore
#line 100 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\40116324\source\repos\TollCalculatorBlazorApp\TollCalculatorBlazorApp\Pages\Index.razor"
       


    private VehicleTypesEnum enumModel;

    private DateTime tollDate = DateTime.Now;

    [Parameter] public DateTime tollTime { get; set; }

    List<DateTime> dates = new List<DateTime>();

    private TollCalculatorService toll = new TollCalculatorService(new Car());
    private int totalTollFee;


    private TollCalculatorService createVehcile()
    {
        switch(enumModel)
        {
            case VehicleTypesEnum.Car:
                toll = new TollCalculatorService(new Car());
                break;
            case VehicleTypesEnum.Motorbike:
                toll = new TollCalculatorService(new Motorbike());
                break;
            case VehicleTypesEnum.Diplomat:
                toll = new TollCalculatorService(new Diplomat());
                break;
            case VehicleTypesEnum.Emergency:
                toll = new TollCalculatorService(new Emergency());
                break;
            case VehicleTypesEnum.Foreign:
                toll = new TollCalculatorService(new Foreign());
                break;
            case VehicleTypesEnum.Military:
                toll = new TollCalculatorService(new Military());
                break;
            case VehicleTypesEnum.Tractor:
                toll = new TollCalculatorService(new Tractor());
                break;;

        }

        return toll;

    }
    private int getToll()
    {
        createVehcile();
        int tollSum = toll.TollRate(tollTime);//toll.CalculateTollDailyInvoice(dates);
        return tollSum;

    }

    private int getTotalToll()
    {
        createVehcile();
        int tollSum = toll.CalculateTollDailyInvoice(dates.ToArray());
        return tollSum;

    }
    private void showTotalToll()
    {
        createVehcile();
        totalTollFee = getTotalToll();


    }

    private void appendNewTime()
    {
        

        tollDate = tollDate.Date.AddHours(tollTime.Hour).AddMinutes(tollTime.Minute).AddSeconds(tollTime.Second).AddMilliseconds(tollTime.Millisecond);
        dates.Add(tollDate);



    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.TollCalculatorBlazorApp.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
