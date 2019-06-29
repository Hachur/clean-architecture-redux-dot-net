namespace Enterprise.Domain.Users
{
    public class UserModel : IUserModel
    {
        public UserModel()
        {
        }

        public static UserModel NewInstance(
            string guid,
            string firstName,
            string lastName)
        {
            return new UserModel
            {
                Guid = guid,
                FirstName = firstName,
                LastName = lastName
            };
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(this.FirstName)
                    && !string.IsNullOrWhiteSpace(this.LastName);
        }

        public string Guid { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public IExternalUserModel MakeExternalUser()
        {
            return new ExternalUserModel
            {
                Guid = this.Guid,
                FirstName = this.FirstName,
                LastName = this.LastName
            };
        }

    }
}
