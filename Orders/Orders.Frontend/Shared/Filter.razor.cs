using Microsoft.AspNetCore.Components;

namespace Orders.Frontend.Shared
{
    public partial class Filter
    {
        [Parameter, SupplyParameterFromQuery] public string String { get; set; } = string.Empty;
        [Parameter] public string PlaceHolder { get; set; } = string.Empty;

        [Parameter]
        public Func<string, Task> Callback { get; set; } = async (str) => await Task.CompletedTask;

        private async Task CleanFilterAsync()
        {
            Console.WriteLine("Filter.CleanFilterAsync()");
            await Callback(string.Empty);
        }

        private async Task ApplyFilterAsync()
        {
            Console.WriteLine("Filter.ApplyFilterAsync()");
            await Callback(String);
        }
    }
}