namespace ProjectName.Presentation.Features.UserModule.UserAddOrEdit
{
    using System;
    using System.Reactive.Linq;
    using ProjectName.Presentation.Features.UserModule.Store;
    using ProjectName.Presentation.Features.Utils;
    using ProjectName.Presentation.Helpers;
    using ProjectName.Presentation.Store;

    public class UserAddOrEditPresenter : BasePresenter<IUserEditFormView>
    {
        private readonly UserActionCreators userActionCreators;

        public UserAddOrEditPresenter(UserActionCreators userActionCreators)
        {
            this.userActionCreators = userActionCreators;
        }


        public void Save()
        {
            if (this.View.IsValidUser())
            {
                this.View.ShowProgress();
                ApplicationState.Store
                    .DispatchAsync(userActionCreators.EditUserAsync(this.View.GetUser()));
            }
        }

        public override void Start()
        {
            ApplicationState.Store
                .DistinctUntilChanged(state => new { state.SelectCurrentUser })
                .Subscribe(this.OnApplicationStateChanged);
        }

        public override void Stop()
        {
        }

        private void OnApplicationStateChanged(ApplicationState applicationState)
        {
            this.View.SetUser(applicationState.SelectCurrentUser);
            if (applicationState.SelectCurrentUser == null)
            {
                this.View.HideProgress();
            }
        }
    }
}
