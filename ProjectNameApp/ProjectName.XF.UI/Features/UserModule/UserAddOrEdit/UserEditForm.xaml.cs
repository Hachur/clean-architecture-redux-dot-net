namespace ProjectName.XF.UI.Features.UserModule.UserAddOrEdit
{
    using ProjectName.Presentation.Features.UserModule;
    using ProjectName.Presentation.Features.UserModule.UserAddOrEdit;

    public partial class UserEditForm : IUserEditFormView
    {
        public UserEditForm()
        {
            InitializeComponent();
            this.Presenter.View = this;
            this.User = User.NewInstance();
        }

        private User User { get; set; }

        public void OnAppearing()
        {
            this.Presenter.Start();
        }

        public User GetUser()
        {
            this.User.FirstName = this.FirstNameEntry.Text;
            this.User.LastName = this.LastNameEntry.Text;

            return this.User;
        }

        public bool IsValidUser()
        {
            return this.User.Validate();
        }

        public void SetUser(User user)
        {
            this.User = user;
            this.RefreshUI();
            this.Form.IsVisible = user != null;
        }

        public void ShowProgress()
        {
            this.ActivityIndicator.IsVisible = true;
            this.ActivityIndicator.IsRunning = true;
            this.Form.IsVisible = false;
        }

        public void HideProgress()
        {
            this.ActivityIndicator.IsVisible = false;
            this.ActivityIndicator.IsRunning = false;
        }

        public void SaveClicked(object sender, System.EventArgs e)
        {
            this.Presenter.Save();
        }

        private void RefreshUI()
        {
            if (this.User != null)
            {
                this.FirstNameEntry.Text = this.User.FirstName;
                this.LastNameEntry.Text = this.User.LastName;
            }
            else
            {
                this.FirstNameEntry.Text = string.Empty;
                this.LastNameEntry.Text = string.Empty;
            }
        }
    }
}
