namespace ProjectName.Domain.UseCases.UserModule
{
    using System;
    using System.Threading.Tasks;
    using Enterprise.Domain.Users;
    using ProjectName.Domain.Repositories;

    public class AddOrEditUserUseCase : IAddOrEditUserUseCase
    {
        private readonly IUserRepository userRepository;

        public AddOrEditUserUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task<IUserModel> ExecuteAsync(IUserModel user)
        {
            if (user.IsValid())
            {
                return this.userRepository.InsertOrUpdateASync(user);
            }

            throw new Exception("First name or last name cannot be empty");
        }
    }
}
