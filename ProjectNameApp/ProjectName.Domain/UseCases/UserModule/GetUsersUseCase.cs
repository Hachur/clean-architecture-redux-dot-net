namespace ProjectName.Domain.UseCases.UserModule
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Enterprise.Domain.Users;
    using Repositories;

    public class GetUsersUseCase : IGetUsersUseCase
    {
        private readonly IUserRepository userRepository;

        public GetUsersUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task<IEnumerable<IUserModel>> ExecuteAsync()
        {
            return this.userRepository.FindUsersAsync();
        }
    }
}
