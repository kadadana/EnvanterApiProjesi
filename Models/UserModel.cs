namespace EnvanterApiProjesi.Models
{
    public class UserModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsLoggedIn { get; set; }
        public static UserModel DefaultUser = new UserModel { Username = "kad", Password = "adana", IsLoggedIn = false };

    }
}