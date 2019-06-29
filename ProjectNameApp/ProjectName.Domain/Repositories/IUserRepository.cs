namespace ProjectName.Domain.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Enterprise.Domain.Users;

    public interface IUserRepository
    {
        Task<IEnumerable<IUserModel>> FindUsersAsync();

        Task<IUserModel> InsertOrUpdateASync(IUserModel userModel);
    }
}
