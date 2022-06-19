using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorInCoreMVC.Pages.BlazorComponents
{
    public partial class DataComponent : ComponentBase
    {

        public List<DataItem> Items { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Items = new List<DataItem> { 
                new DataItem { Name = "Test 1", Address = "Test 1"},
                new DataItem { Name = "Test 2", Address = "Test 2"},
            };
        }


    }
}
