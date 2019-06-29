namespace ProjectName.Presentation.Features.UserModule.Store
{
    using System.Collections.Generic;
    using Presentation.Store;
    using Redux;

    public class UserReducer : IReducer
    {
        public ApplicationState Execute(ApplicationState state, IAction action)
        {
            return new ApplicationState
            {
                IsSearching = IsSearchReducer(state.IsSearching, action),
                Users = UsersReducer(state.Users, action),
                SelectCurrentUser = UserEditReducer(state.SelectCurrentUser, action)
            };
        }

        private static bool IsSearchReducer(bool isSearching, IAction action)
        {
            switch (action)
            {
                case ReceivedUsersAction _:
                    return false;
                case LoadingUsersAction _:
                    return true;
                default:
                    return isSearching;
            }
        }

        private static IEnumerable<User> UsersReducer(IEnumerable<User> users, IAction action)
        {
            if (action is ReceivedUsersAction receivedUsersAction)
            {
                return receivedUsersAction.Users;
            }

            return users;
        }

        private User UserEditReducer(User selectCurrentUser, IAction action)
        {
            switch (action)
            {
                case EditUserAction editUserAction:
                    return editUserAction.User;
                case UserAddOrEditSuccesfullyAction userAddOrEditSuccessfullyAction:
                    return null;
                default:
                    return selectCurrentUser;
            }
        }
    }
}
