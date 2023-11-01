namespace Blog.Services
{
    public interface IAuthenticationService
    {
        string AuthenticateUser(string email, string password);
    }
}
