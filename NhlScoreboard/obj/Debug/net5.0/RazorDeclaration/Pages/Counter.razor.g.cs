// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NhlScoreboard.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\_Imports.razor"
using NhlScoreboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\_Imports.razor"
using NhlScoreboard.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\Pages\Counter.razor"
using System.Net;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Client\dev\temp\NhlScoreboard\NhlScoreboard\Pages\Counter.razor"
       
    private int currentCount = 0;
    private string Time { get; set; }
    private List<Game> TodaySchedule { get; set; }
    private int scheduleIndex = 0;
    private Game CurrentGame { get; set; }

    private void IncrementCount()
    {
        currentCount++;
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        InvokeAsync(async () =>
        {
            TodaySchedule = await LoadSchedule();
        });
        
        
        var timer = new System.Threading.Timer((_) =>
        {
            InvokeAsync( async ()  =>
            {
                CurrentGame = TodaySchedule[scheduleIndex];
                scheduleIndex += 1;
                if (scheduleIndex == TodaySchedule.Count)
                    scheduleIndex = 0;
                StateHasChanged();
            });
        }, null, 0, 5000);

    }
    
    private async Task<List<Game>> LoadSchedule()
    {
        var today = DateTime.Now.ToString("yyyy-M-d");
        var response = await Http.GetFromJsonAsync<ScheduleResponse>
            ($"https://statsapi.web.nhl.com/api/v1/schedule?&startDate={today}&endDate={today}");
        return response?.dates[0].games;
    }
    
    
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class MetaData
    {
        public string timeStamp { get; set; }
    }

    public class Status
    {
        public string abstractGameState { get; set; }
        public string codedGameState { get; set; }
        public string detailedState { get; set; }
        public string statusCode { get; set; }
        public bool startTimeTBD { get; set; }
    }

    public class LeagueRecord
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public string type { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Away
    {
        public LeagueRecord leagueRecord { get; set; }
        public int score { get; set; }
        public Team team { get; set; }
    }

    public class Home
    {
        public LeagueRecord leagueRecord { get; set; }
        public int score { get; set; }
        public Team team { get; set; }
    }

    public class Teams
    {
        public Away away { get; set; }
        public Home home { get; set; }
    }

    public class Venue
    {
        public string name { get; set; }
        public string link { get; set; }
        public int? id { get; set; }
    }

    public class Content
    {
        public string link { get; set; }
    }

    public class Game
    {
        public int gamePk { get; set; }
        public string link { get; set; }
        public string gameType { get; set; }
        public string season { get; set; }
        public DateTime gameDate { get; set; }
        public Status status { get; set; }
        public Teams teams { get; set; }
        public Venue venue { get; set; }
        public Content content { get; set; }
    }

    public class Date
    {
        public string date { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public List<Game> games { get; set; }
        public List<object> events { get; set; }
        public List<object> matches { get; set; }
    }

    public class ScheduleResponse
    {
        public string copyright { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public MetaData metaData { get; set; }
        public int wait { get; set; }
        public List<Date> dates { get; set; }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
