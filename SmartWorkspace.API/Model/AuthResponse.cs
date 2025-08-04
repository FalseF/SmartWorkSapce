namespace SmartWorkspace.API.Model
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string[] Roles { get; set; }
    }
}
