namespace Blog.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public string AuthenticateUser(string email, string password)
        {
            string token = null;

            if (email == "admin@blog.com" && password == "admin123")
            {
                token = Guid.NewGuid().ToString();
            }

            return token;
        }
    }
}
