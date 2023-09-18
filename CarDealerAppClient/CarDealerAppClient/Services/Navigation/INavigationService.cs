namespace CarDealerAppClient.Services.Navigation
{
    public interface INavigationService
    {
        Task<INavigationResult> NavigateAsync(Uri uri);
        Task<INavigationResult> NavigateAsync(string page);
    }

    public interface INavigationResult
    {
        bool Success { get; }
        Exception Exception { get; }
    }

}
