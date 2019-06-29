namespace ProjectName.Data.DataSources.Mocks
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Enterprise.Domain.Users;

    public class UserMockDataSource : IUserDataSource
    {
        private List<IUserModel> Users { get; } = new List<IUserModel>();

        public UserMockDataSource()
        {
            this.Users.Add(UserModel.NewInstance(GenerateRandomGuid(), "Juan", "Agu"));
            this.Users.Add(UserModel.NewInstance(GenerateRandomGuid(), "Rodrigo", "Garcia"));
            this.Users.Add(UserModel.NewInstance(GenerateRandomGuid(), "Manuel", "Aliaga"));
            this.Users.Add(UserModel.NewInstance(GenerateRandomGuid(), "Hugo", "Truffe"));
            this.Users.Add(UserModel.NewInstance(GenerateRandomGuid(), "Carla", "Sandrone"));
        }

        private static string GenerateRandomGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public async Task<IEnumerable<IUserModel>> FindUsersAsync()
        {
            await Task.Delay(1000);
            return this.Users;
        }

        public async Task<IUserModel> InsertOrUpdateASync(IUserModel userModel)
        {
            await Task.Delay(1000);

            if (string.IsNullOrWhiteSpace(userModel.Guid))
            {
                var guid = new Guid().ToString();
                userModel = UserModel.NewInstance(guid, userModel.FirstName, userModel.LastName);
                this.Users.Add(userModel);
            }
            else
            {
                var index = this.Users.FindIndex(u => string.Compare(u.Guid, userModel.Guid, StringComparison.Ordinal) == 0);
                if (index != -1)
                {
                    this.Users[index] = userModel;
                }
                else
                {
                    this.Users.Add(userModel);
                }
            }

            return userModel;
        }
    }
}
