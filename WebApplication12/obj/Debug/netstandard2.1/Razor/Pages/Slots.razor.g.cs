#pragma checksum "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11f3921444b08a136fdd96a027cee3f17312fe60"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication12.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using WebApplication12;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using WebApplication12.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
using WebApplication12.Shared.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Slots : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p>\r\n    <div>\r\n        Finding Slots In <em>DELHI</em>\r\n    </div>\r\n</p>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<span>\r\n        Enter Date : dd/mm/yyyy(optional)\r\n    </span>\r\n    ");
            __builder.OpenElement(4, "span");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "placeholder", 
#nullable restore
#line 19 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                             date

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                 date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => date = __value, date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "form");
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 24 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
         foreach (var item in Enum.GetNames(typeof(Question.VaccineType)))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "            ");
            __builder.OpenElement(18, "span");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "radio");
            __builder.AddAttribute(22, "name", "question1");
            __builder.AddAttribute(23, "id", 
#nullable restore
#line 27 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                          item

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 27 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                                        item

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                                                         SelectionChangedVaccineType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "checked", 
#nullable restore
#line 27 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                                                                                                selectedAnswer.Equals(item,StringComparison.OrdinalIgnoreCase)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "label");
            __builder.AddAttribute(29, "for", 
#nullable restore
#line 28 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                             item

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, 
#nullable restore
#line 28 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                    item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 30 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenElement(36, "form");
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 35 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
         foreach (var item in Enum.GetNames(typeof(Question.Dosage)))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "            ");
            __builder.OpenElement(41, "span");
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "radio");
            __builder.AddAttribute(45, "name", "question1");
            __builder.AddAttribute(46, "id", 
#nullable restore
#line 38 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                          item

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "value", 
#nullable restore
#line 38 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                                        item

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 38 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                                                         SelectionChangedDosage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "checked", 
#nullable restore
#line 38 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                                                                                           selectedAnswer.Equals(item,StringComparison.OrdinalIgnoreCase)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "label");
            __builder.AddAttribute(52, "for", 
#nullable restore
#line 39 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                             item

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, 
#nullable restore
#line 39 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                    item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 41 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.OpenElement(59, "form");
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 46 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
         foreach (var item in Enum.GetNames(typeof(Question.AgeGroup)))
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "            ");
            __builder.OpenElement(64, "span");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "radio");
            __builder.AddAttribute(68, "name", "question1");
            __builder.AddAttribute(69, "id", 
#nullable restore
#line 49 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                          item

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(70, "value", 
#nullable restore
#line 49 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                                        item

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 49 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                                                         SelectionChangedAgeGroup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "checked", 
#nullable restore
#line 49 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                                                                                             selectedAnswer.Equals(item,StringComparison.OrdinalIgnoreCase)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "label");
            __builder.AddAttribute(75, "for", 
#nullable restore
#line 50 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                             item

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(76, 
#nullable restore
#line 50 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                    item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 52 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 55 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
 if (!string.IsNullOrEmpty(vaccine) && !string.IsNullOrEmpty(dose) && !string.IsNullOrEmpty(ageGrp))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "    ");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "class", "buttonarjun");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                          FindCenters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "Find Centers");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 58 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
 if (flag)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
     if (flagSlot)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "        ");
            __builder.AddMarkupContent(89, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 64 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
    }
    else
    {
        if (slotResponse.slot.Count != 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "            ");
            __builder.OpenElement(91, "p");
            __builder.AddAttribute(92, "class", "margin-top-10");
            __builder.AddMarkupContent(93, "\r\n                Slots Available: ");
            __builder.AddContent(94, 
#nullable restore
#line 70 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                  slotResponse.slot.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "grid-container");
            __builder.AddMarkupContent(99, "\r\n                ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "grid-x");
            __builder.AddMarkupContent(102, "\r\n                    ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "cell small-12");
            __builder.AddMarkupContent(105, "\r\n                        ");
            __builder.OpenElement(106, "table");
            __builder.AddAttribute(107, "class", "table");
            __builder.AddMarkupContent(108, "\r\n                            ");
            __builder.AddMarkupContent(109, @"<thead>
                                <tr>
                                    <th>Dose</th>
                                    <th>Address</th>
                                    <th>District Name</th>
                                    <th>Fee</th>
                                    <th>Min_Age_Limit</th>
                                    <th>Name</th>
                                    <th>Pincode</th>
                                    <th>State Name</th>
                                    <th>Vaccine</th>
                                </tr>
                            </thead>
                            ");
            __builder.OpenElement(110, "tbody");
            __builder.AddMarkupContent(111, "\r\n");
#nullable restore
#line 90 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                 foreach (var slots in slotResponse.slot)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(112, "                                    ");
            __builder.OpenElement(113, "tr");
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 93 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                         if (slots.available_capacity_dose1 != 0)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(115, "                                            ");
            __builder.OpenElement(116, "td");
            __builder.AddContent(117, 
#nullable restore
#line 95 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                 slots.available_capacity_dose1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 96 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                        }
                                        else if (slots.available_capacity_dose2 != 0)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "                                            ");
            __builder.OpenElement(120, "td");
            __builder.AddContent(121, 
#nullable restore
#line 99 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                                 slots.available_capacity_dose2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 100 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(123, "\r\n                                        ");
            __builder.OpenElement(124, "td");
            __builder.AddContent(125, 
#nullable restore
#line 102 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                             slots.address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                                        ");
            __builder.OpenElement(127, "td");
            __builder.AddContent(128, 
#nullable restore
#line 103 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                             slots.district_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                                        ");
            __builder.OpenElement(130, "td");
            __builder.AddContent(131, 
#nullable restore
#line 104 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                             slots.fee

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                                        ");
            __builder.OpenElement(133, "td");
            __builder.AddContent(134, 
#nullable restore
#line 105 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                             slots.min_age_limit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                                        ");
            __builder.OpenElement(136, "td");
            __builder.AddContent(137, 
#nullable restore
#line 106 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                             slots.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                                        ");
            __builder.OpenElement(139, "td");
            __builder.AddContent(140, 
#nullable restore
#line 107 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                             slots.pincode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                                        ");
            __builder.OpenElement(142, "td");
            __builder.AddContent(143, 
#nullable restore
#line 108 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                             slots.state_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                                        ");
            __builder.OpenElement(145, "td");
            __builder.AddContent(146, 
#nullable restore
#line 109 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
                                             slots.vaccine

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n");
#nullable restore
#line 111 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"


                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(149, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n");
#nullable restore
#line 119 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"

        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(155, "            ");
            __builder.AddMarkupContent(156, "<p class=\"margin-top-10\">Sorry , No Slots are Present</p>\r\n");
#nullable restore
#line 124 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 129 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Slots.razor"
       
    private string responseBody;
    private string forecasts;
    private string dose;
    private string vaccine;
    private string ageGrp;
    private bool flagSlot;
    private string date;
    private string doseinp;

    private string buttondisabled = "";

    private List<string> templates;

    private bool flag;
    private bool finalFlag;

    public List<string> pincodes;

    public SlotResponse slotResponse;

    string vaccineTy = "";
    string dosage = "";
    string selectedAnswer = "";
    string age = "";

    void SelectionChanged(ChangeEventArgs args)
    {
        selectedAnswer = args.Value.ToString();
    }

    void SelectionChangedVaccineType(ChangeEventArgs args)
    {
        vaccineTy = args.Value.ToString();
        vaccine = vaccineTy;
    }

    void SelectionChangedDosage(ChangeEventArgs args)
    {
        dosage = args.Value.ToString();
        dose = dosage;
        doseinp = dosage;
    }
    void SelectionChangedAgeGroup(ChangeEventArgs args)
    {
        age = args.Value.ToString();
        ageGrp = age;
    }

    Question question = new Question { QuestionText = "What is the color of the sky" };


    public class Question
    {
        public string QuestionText { get; set; }
        public enum Colors { Red, Green, Blue, Yellow };
        public enum VaccineType { Covishield, Covaxin };
        public enum AgeGroup { Above45, Below45 };
        public enum Dosage { First, Second };

    }

    protected override Task OnInitializedAsync()
    {
        flag = false;
        flagSlot = true;
        DateTime dateTime = DateTime.UtcNow.Date;
        date = dateTime.ToString("dd/MM/yyyy");
        pincodes = new List<string>();
        return base.OnInitializedAsync();
    }

    public async Task FindCenters()
    {
        if (flag)
        {
            flag = false;
        }
        slotResponse = new SlotResponse();
        flag = true;
        flagSlot = true;
        slotResponse.slot = new List<slot>();

        var dateinp = date;
        if (string.IsNullOrEmpty(date))
        {
            dateinp = "nothing";
        }
        else
        {
            dateinp = dateinp.Replace('/', '@');
        }

        try
        {
            dose = doseinp;
            if (dose.ToLower() == "first")
            {
                dose = "available_capacity_dose1";
            }
            else if (dose.ToLower() == "second")
            {
                dose = "available_capacity_dose2";
            }
            for (int i = 110001; i <= 110096; i++)
            {
                pincodes.Add(i.ToString());
            }
            var age = 0;
            if (ageGrp.ToLower() == "above45")
            {
                age = 45;
            }
            if (date == "nothing")
            {
                DateTime dateTime = DateTime.UtcNow.Date;
                date = dateTime.ToString("dd/MM/yyyy");
            }
            if (vaccine.Contains("x") || vaccine.Contains("X"))
            {
                vaccine = "COVAXIN";
            }
            else
            {
                vaccine = "COVISHIELD";
            }
            foreach (var pincode in pincodes)
            {
                var requestMessage = new HttpRequestMessage()
                {
                    Method = new HttpMethod("GET"),
                    RequestUri = new Uri("https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/findByPin?pincode=" + pincode + "&date=" + date + "&vaccine=" + vaccine)
                };
                var response = await Http.SendAsync(requestMessage);
                var responseStatusCode = response.StatusCode;
                var asd = responseStatusCode.ToString();
                if (responseStatusCode.ToString() == "OK")
                {
                    var strContent = await response.Content.ReadAsStringAsync();
                    var responseFromSlot = JsonConvert.DeserializeObject<Root>(strContent);
                    foreach (var value in responseFromSlot.sessions)
                    {
                        slot slot = new slot();
                        if (age >= 45)
                        {
                            if (dose == "available_capacity_dose1")
                            {
                                if (value.available_capacity_dose1 > 0 && vaccine == value.vaccine && value.min_age_limit == 45)
                                {
                                    slot.address = value.address;
                                    slot.available_capacity_dose1 = value.available_capacity_dose1;
                                    slot.district_name = value.district_name;
                                    slot.fee = value.fee;
                                    slot.pincode = value.pincode;
                                    slot.name = value.name;
                                    slot.vaccine = value.vaccine;
                                    slot.min_age_limit = value.min_age_limit;
                                    slot.state_name = value.state_name;
                                    slotResponse.slot.Add(slot);
                                    flagSlot = false;
                                    StateHasChanged();
                                }
                            }
                            else if (value.available_capacity_dose2 > 0 && vaccine == value.vaccine && value.min_age_limit == 45)
                            {
                                slot.address = value.address;
                                slot.available_capacity_dose1 = value.available_capacity_dose2;
                                slot.district_name = value.district_name;
                                slot.fee = value.fee;
                                slot.pincode = value.pincode;
                                slot.name = value.name;
                                slot.vaccine = value.vaccine;
                                slot.min_age_limit = value.min_age_limit;
                                slot.state_name = value.state_name;
                                slotResponse.slot.Add(slot);
                                flagSlot = false;
                                StateHasChanged();
                            }
                        }
                        else
                        {
                            if (dose == "available_capacity_dose1")
                            {
                                if (value.available_capacity_dose1 > 0 && vaccine == value.vaccine && value.min_age_limit == 18)
                                {
                                    slot.address = value.address;
                                    slot.available_capacity_dose1 = value.available_capacity_dose1;
                                    slot.district_name = value.district_name;
                                    slot.fee = value.fee;
                                    slot.pincode = value.pincode;
                                    slot.name = value.name;
                                    slot.vaccine = value.vaccine;
                                    slot.min_age_limit = value.min_age_limit;
                                    slot.state_name = value.state_name;
                                    slotResponse.slot.Add(slot);
                                    flagSlot = false;
                                    StateHasChanged();
                                }
                            }
                            else if (value.available_capacity_dose2 > 0 && vaccine == value.vaccine && value.min_age_limit == 18)
                            {
                                slot.address = value.address;
                                slot.available_capacity_dose1 = value.available_capacity_dose2;
                                slot.district_name = value.district_name;
                                slot.fee = value.fee;
                                slot.pincode = value.pincode;
                                slot.name = value.name;
                                slot.min_age_limit = value.min_age_limit;
                                slot.state_name = value.state_name;
                                slot.vaccine = value.vaccine;
                                slotResponse.slot.Add(slot);
                                flagSlot = false;
                                StateHasChanged();
                            }
                        }
                    }
                }
            }
            if (slotResponse.slot.Count != 0)
            {
                flagSlot = false;
                StateHasChanged();
            }
            else
            {
                flagSlot = false;
                StateHasChanged();
            }

        }
        catch (Exception ex)
        {
            throw (ex);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
