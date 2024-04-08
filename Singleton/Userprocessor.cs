namespace Singleton {
    public class Userprocessor {
        private readonly IUserManager userManager;

        public Userprocessor(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        public string Process() {
            var users = userManager.Usernames;
            //We can implement some log here
            return users.FirstOrDefault() ?? string.Empty;
        }
    }
}
