namespace Enterprise.Domain.Users
{
    public interface IUserModel
    {
        string Guid { get; }

        string FirstName { get; }

        string LastName { get; }

        bool IsValid();

        IExternalUserModel MakeExternalUser();
    }
}
