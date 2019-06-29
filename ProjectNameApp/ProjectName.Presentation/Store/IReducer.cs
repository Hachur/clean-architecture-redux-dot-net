namespace ProjectName.Presentation.Store
{
    using Redux;

    public interface IReducer
    {
        ApplicationState Execute(ApplicationState state, IAction action);
    }
}
