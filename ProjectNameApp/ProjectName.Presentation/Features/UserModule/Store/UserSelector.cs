namespace ProjectName.Presentation.Features.UserModule.Store
{
    using System.Collections.Generic;
    using System.Linq;
    using Presentation.Store;

    public class UserSelector
    {
        public static IEnumerable<User> GetFilteredUsers(ApplicationState applicationState)
        {
            if(string.IsNullOrWhiteSpace(applicationState.UserName)){
                return applicationState.Users;
            }

            return applicationState.Users.Where(x => x.FullName.Contains(applicationState.UserName));
        }
    }
}
