namespace ProjectName.Presentation.Features.UserModule
{
    using System;

    public class User
    {
        public User()
        {
        }

        public static User NewInstance()
        {
            return new User();
        }

        public string Guid { get; internal set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(this.FirstName)
                && !string.IsNullOrWhiteSpace(this.LastName);
        }
    }
}
