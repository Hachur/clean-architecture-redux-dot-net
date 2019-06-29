namespace ProjectName.XF.UI.Features.UserModule.UserList
{
    using System.Collections.Generic;
    using System.Linq;
    using Presentation.Features.UserModule;
    using Presentation.Features.UserModule.UserList;
    using Xamarin.Forms;

    public partial class UserListView : IUserListView
    {

        public UserListView()
        {
            InitializeComponent();
            this.Presenter.View = this;
        }

        public void OnAppearing()
        {
            this.Presenter.Start();
        }

        public void AddUsers(IEnumerable<User> users)
        {
            this.UserList.ItemsSource = users;
            this.UserList.IsVisible = users.Any();
        }

        public void ClearList()
        {
            
        }

        public void HideProgress()
        {
            this.ActivityIndicator.IsVisible = false;
            this.ActivityIndicator.IsRunning = false;
        }

        public void ShowError(string error)
        {
            Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error", error, "OK");
        }

        public void ShowProgress()
        {
            this.ActivityIndicator.IsVisible = true;
            this.ActivityIndicator.IsRunning = true;
            this.UserList.IsVisible = false;
        }

        public void UserTapped(object sender, System.EventArgs e)
        {
            if(sender is ListView listView
                && listView.SelectedItem is User user)
            {
                this.Presenter.ShowUserInfo(user);
            }
        }
    }
}
