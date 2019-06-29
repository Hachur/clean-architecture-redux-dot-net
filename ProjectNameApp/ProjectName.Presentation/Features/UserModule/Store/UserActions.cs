namespace ProjectName.Presentation.Features.UserModule.Store
{
    using System.Collections.Generic;
    using Redux;

    public class LoadingUsersAction : IAction
    {
        public static LoadingUsersAction NewInstance()
        {
            return new LoadingUsersAction();
        }
    }

    public class GetUsersAction : IAction
    {
        public static GetUsersAction NewInstance()
        {
            return new GetUsersAction();
        }
    }

    public class ReceivedUsersAction : IAction
    {
        public ReceivedUsersAction(IEnumerable<User> users)
        {
            this.Users = users;
        }

        public static ReceivedUsersAction NewInstance(IEnumerable<User> users)
        {
            return new ReceivedUsersAction(users);
        }

        public IEnumerable<User> Users
        {
            get;
            private set;
        }
    }

    public class ErrorGetUsersAction : IAction
    {
        public static ErrorGetUsersAction NewInstance()
        {
            return new ErrorGetUsersAction();
        }
    }

    public class AddNewUserAction : IAction
    {
        public AddNewUserAction(User user)
        {
            this.User = user;
        }

        public static AddNewUserAction NewInstance(User user)
        {
            return new AddNewUserAction(user);
        }

        public User User { get; private set; }
    }

    public class RemoveUserAction : IAction
    {
        public RemoveUserAction(User user)
        {
            this.User = user;
        }

        public static RemoveUserAction NewInstance(User user)
        {
            return new RemoveUserAction(user);
        }

        public User User { get; private set; }

    }

    public class EditUserAction : IAction
    {
        public EditUserAction(User user)
        {
            this.User = user;
        }

        public static EditUserAction NewInstance(User user)
        {
            return new EditUserAction(user);
        }

        public User User { get; private set; }
    }

    public class CancelRemoveUserAction : IAction
    {
        public CancelRemoveUserAction(User user)
        {
            this.User = user;
        }

        public static CancelRemoveUserAction NewInstance(User user)
        {
            return new CancelRemoveUserAction(user);
        }

        public User User { get; private set; }
    }

    public class UserAddOrEditSuccesfullyAction : IAction
    {
        public UserAddOrEditSuccesfullyAction(User user)
        {
            this.User = user;
        }

        public static UserAddOrEditSuccesfullyAction NewInstance(User user)
        {
            return new UserAddOrEditSuccesfullyAction(user);
        }

        public User User { get; private set; }
    }
}
