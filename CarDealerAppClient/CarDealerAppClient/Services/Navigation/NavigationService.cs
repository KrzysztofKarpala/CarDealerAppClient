using Microsoft.AspNetCore.Components;

namespace CarDealerAppClient.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        private NavigationManager _navigationManager;
        public NavigationService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }
        private class NavigationResult : INavigationResult
        {
            public bool Success { get; set; }
            public Exception Exception { get; set; } = null;
        }
        public async Task<INavigationResult> NavigateAsync(Uri uri)
        {
            return await NavigateAsync(uri.ToString());
        }

        public async Task<INavigationResult> NavigateAsync(string page)
        {
            if(string.IsNullOrEmpty(page))
            {
                return new NavigationResult { Success = false};
            }
            _navigationManager.NavigateTo(page);
            return new NavigationResult { Success = true };
        }
    }
}
