namespace ProjectName.Domain.UseCases.UserModule
{
    using System.Collections.Generic;
    using Enterprise.Domain.Users;

    public interface IGetUsersUseCase : IBaseUseCase<IEnumerable<IUserModel>>
    {
    }
}
