using System.Threading.Tasks;

namespace Oceans.WebApplication.Pages
{
    public partial class Exercise
    {
        public int NumberExpiredSubscriptions { get; set; }
        public int ExpectedNumberOfExpiredSubscriptions { get; set; }

        protected override async Task OnInitializedAsync()
        {
            NumberExpiredSubscriptions = await ExerciseService.GetNumberExpiredSubscriptionsAsync();
            ExpectedNumberOfExpiredSubscriptions = await ExerciseService.GetExpectedNumberOfExpiredSubscriptions();
        }
    }
}
