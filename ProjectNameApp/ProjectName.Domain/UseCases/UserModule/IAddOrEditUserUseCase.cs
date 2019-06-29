namespace ProjectName.Domain.UseCases.UserModule
{
    using System;
    using Enterprise.Domain.Users;

    public interface IAddOrEditUserUseCase : IBaseParamUseCase<IUserModel, IUserModel>
    {
    }
}
