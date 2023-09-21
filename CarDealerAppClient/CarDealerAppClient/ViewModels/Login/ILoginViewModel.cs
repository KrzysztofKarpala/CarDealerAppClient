namespace CarDealerAppClient.ViewModels.Login
{
    public interface ILoginViewModel
    {
        string Username { get; set; }
        string Password { get; set; }
        Task NavigateToHome();
    }
}
