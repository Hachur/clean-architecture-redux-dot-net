namespace ProjectName.Presentation.Features.UserModule.Store
{
    using Domain.UseCases.UserModule;
    using Presentation.Store;
    using static Helpers.StoreExtensions;

    public class UserActionCreators
    {
        private readonly IGetUsersUseCase getUsersUseCase;
        private readonly IAddOrEditUserUseCase addOrEditUserUsecase;

        public UserActionCreators(
            IGetUsersUseCase getUsersUseCase,
            IAddOrEditUserUseCase addOrEditUserUsecase)
        {
            this.getUsersUseCase = getUsersUseCase;
            this.addOrEditUserUsecase = addOrEditUserUsecase;
        }

        public AsyncActionsCreator<ApplicationState> GetUsersAsync()
        {
            return async (dispatch, getState) =>
            {
                dispatch(LoadingUsersAction.NewInstance());

                try
                {
                    var users = await this.getUsersUseCase.ExecuteAsync();

                    dispatch(ReceivedUsersAction.NewInstance(UserMapper.Mapping(users)));
                }catch
                {
                    dispatch(ErrorGetUsersAction.NewInstance());
                }
            };
        }

        public AsyncActionsCreator<ApplicationState> EditUserAsync(User user)
        {
            return async (dispatch, getState) =>
            {
                var userModel = await this.addOrEditUserUsecase.ExecuteAsync(UserMapper.Transform(user));
                dispatch(UserAddOrEditSuccesfullyAction.NewInstance(UserMapper.Mapping(userModel)));
                await ApplicationState.Store.DispatchAsync(GetUsersAsync());
            };
        }
    }
}
