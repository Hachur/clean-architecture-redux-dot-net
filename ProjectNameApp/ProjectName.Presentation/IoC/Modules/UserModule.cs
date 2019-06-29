namespace ProjectName.Presentation.IoC.Modules
{
    using Autofac;
    using Data.Repositories;
    using Domain.Repositories;
    using Domain.UseCases.UserModule;
    using Features.UserModule.Store;
    using ProjectName.Data.DataSources;
    using ProjectName.Data.DataSources.Mocks;
    using ProjectName.Presentation.Features.UserModule.UserAddOrEdit;
    using ProjectName.Presentation.Features.UserModule.UserList;

    public class UserModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserMockDataSource>().As<IUserDataSource>().SingleInstance();
            builder.RegisterType<UserDataRepository>().As<IUserRepository>();
            builder.RegisterType<GetUsersUseCase>().As<IGetUsersUseCase>();
            builder.RegisterType<AddOrEditUserUseCase>().As<IAddOrEditUserUseCase>();
            builder.RegisterType<UserActionCreators>().As<UserActionCreators>();
            builder.RegisterType<UserListPresenter>().As<UserListPresenter>();
            builder.RegisterType<UserAddOrEditPresenter>().As<UserAddOrEditPresenter>();
        }
    }
}
