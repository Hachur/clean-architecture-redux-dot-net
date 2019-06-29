namespace ProjectName.Presentation.Features.UserModule
{
    using System.Collections.Generic;
    using System.Linq;
    using Enterprise.Domain.Users;
    using Mapster;

    public static class UserMapper
    {
        public static User Mapping(IUserModel userModel)
        {
            return userModel.Adapt<User>();
        }

        public static IEnumerable<User> Mapping(IEnumerable<IUserModel> users)
        {
            if (users == null) return default(IEnumerable<User>);

            return users.Select(Mapping);
        }

        public static IUserModel Transform(User user)
        {
            return user.Adapt<UserModel>();
        }

        public static IEnumerable<IUserModel> Transform(IEnumerable<User> users)
        {
            if (users == null) return default(IEnumerable<IUserModel>);

            return users.Select(Transform);
        }
    }
}
