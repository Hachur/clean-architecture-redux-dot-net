namespace ProjectName.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Enterprise.Domain.Users;
    using ProjectName.Data.DataSources;
    using ProjectName.Domain.Repositories;

    public class UserDataRepository : IUserRepository
    {
        private readonly IUserDataSource userDataSource;

        public UserDataRepository(IUserDataSource userDataSource)
        {
            this.userDataSource = userDataSource;
        }

        public Task<IEnumerable<IUserModel>> FindUsersAsync()
        {
            return this.userDataSource.FindUsersAsync();
        }

        public Task<IUserModel> InsertOrUpdateASync(IUserModel userModel)
        {
            return this.userDataSource.InsertOrUpdateASync(userModel);
        }
    }
}
