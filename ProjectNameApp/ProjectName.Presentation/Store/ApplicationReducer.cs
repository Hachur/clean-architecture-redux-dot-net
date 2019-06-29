namespace ProjectName.Presentation.Store
{
    using System.Collections.Generic;
    using Features.UserModule;
    using Features.UserModule.Store;
    using Redux;

    public class ApplicationReducer : IReducer
    {
        public ApplicationState Execute(ApplicationState state, IAction action)
        {
            return state;
        }
    }
}
