namespace ProjectName.Presentation.Features.UserModule.UserList
{
    using System.Collections.Generic;
    using ProjectName.Presentation.Features.Utils;

    public interface IUserListView : IBaseView
    {
        void ShowProgress();

        void AddUsers(IEnumerable<User> users);

        void ClearList();

        void ShowError(string error);

        void HideProgress();
    }
}
