using Microsoft.AspNetCore.Components;

namespace BlazorCommandLine.Components.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        [Parameter]
        public int InitialCount {get;set;}

        [Parameter]
        public int IncrementAmount { get;set; } = 1;

        private void IncrementCount()
        {
            Console.WriteLine("Incrementing count");
            currentCount += IncrementAmount;
        }


        protected override void OnInitialized()
        {
            currentCount = InitialCount;
        }
    }
}