namespace ProjectName.Presentation.Features.UserModule.UserList
{
    using System;
    using System.Linq;
    using System.Reactive.Linq;
    using System.Threading.Tasks;
    using Helpers;
    using Presentation.Store;
    using ProjectName.Presentation.Features.Utils;
    using Store;

    public class UserListPresenter : BasePresenter<IUserListView>
    {
        private readonly UserActionCreators userActionCreators;

        public UserListPresenter(UserActionCreators userActionCreators)
        {
            this.userActionCreators = userActionCreators;
        }

        public override async void Start()
        {
            this.Subscribe();
            await ApplicationState.Store.DispatchAsync(this.userActionCreators.GetUsersAsync());
        }

        public override void Stop()
        {
        }

        public void ShowUserInfo(User user)
        {
            ApplicationState.Store.Dispatch(EditUserAction.NewInstance(user));
        }

        private void Subscribe()
        {
            ApplicationState.Store
                            .DistinctUntilChanged(state => new { state.Users, state.IsSearching })
                            .Subscribe(this.OnApplicationStateChanged);
        }

        private void OnApplicationStateChanged(ApplicationState applicationState)
        {
            if (this.View != null)
            {
                var users = UserSelector.GetFilteredUsers(applicationState);

                this.View.ClearList();

                this.View.AddUsers(users);

                if (applicationState.IsSearching)
                {
                    this.View.ShowProgress();
                }
                else
                {
                    this.View.HideProgress();
                }
            }
        }
    }
}
