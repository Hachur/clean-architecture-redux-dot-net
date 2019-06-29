namespace ProjectName.Presentation.Features.UserModule.UserAddOrEdit
{
    using System;
    using ProjectName.Presentation.Features.Utils;

    public interface IUserEditFormView : IBaseView
    {
        void ShowProgress();

        User GetUser();

        bool IsValidUser();

        void SetUser(User user);

        void HideProgress();
    }
}
