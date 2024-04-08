namespace Singleton {
    public interface IUserManager {
       public string[] Usernames { get;}
    }
    public class UserManager : IUserManager {
        private readonly string[] usernames;
        private UserManager() {
            //We can make a DB/ distributed cache call to get initial user information
            usernames = new[] { "User1", "User2" };
        }
        //private static readonly Lazy<UserManager> _instance = new Lazy<UserManager>(() => new UserManager());
    
        //public static UserManager Instance => _instance.Value;

        public string[] Usernames => usernames;

    }
}
