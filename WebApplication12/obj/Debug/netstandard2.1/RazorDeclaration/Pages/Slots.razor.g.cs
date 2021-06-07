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
