namespace LibraryApi.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "jacgenato", EmailAddress="jac_genato@gmail.com", Password="Password",
                GivenName="Jac", Surname="Genato", Role="Administrator"},
            new UserModel() { Username = "jobeekevin", EmailAddress="jobee@gmail.com", Password="Password",
                GivenName="Kevin", Surname="Ellamil", Role="Seller"},
        };
    }
}
