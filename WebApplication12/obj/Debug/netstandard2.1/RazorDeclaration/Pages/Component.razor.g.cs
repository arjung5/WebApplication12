// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication12.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\leaningnetlify\WebApplication12\WebApplication12\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/component")]
    public partial class Component : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "E:\leaningnetlify\WebApplication12\WebApplication12\Pages\Component.razor"
       

    string vaccine = "";
    string dosage = "";
    string selectedAnswer = "";
    string age = "";

    void SelectionChanged(ChangeEventArgs args)
    {
        selectedAnswer = args.Value.ToString();
    }

    void SelectionChangedVaccineType(ChangeEventArgs args)
    {
        vaccine = args.Value.ToString();
    }

    void SelectionChangedDosage(ChangeEventArgs args)
    {
        dosage = args.Value.ToString();
    }
    void SelectionChangedAgeGroup(ChangeEventArgs args)
    {
        age = args.Value.ToString();
    }



    Question question = new Question { QuestionText = "What is the color of the sky" };


    public void OnSubmit()
    {

        Console.WriteLine(selectedAnswer);

    }

    public class Question
    {
        public string QuestionText { get; set; }
        public enum Colors { Red, Green, Blue, Yellow };
        public enum VaccineType { Covishield, Covaxin };
        public enum AgeGroup { Above45, Below45 };
        public enum Dosage { First, Second };

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
