namespace ProjectName.Presentation.Store
{
    using Redux;

    public class CombineReducers
    {
        private readonly IReducer[] reducers;

        private CombineReducers(IReducer[] reducers)
        {
            this.reducers = reducers;
        }

        public static CombineReducers Create(IReducer[] reducers)
        {
            return new CombineReducers(reducers);
        }

        public ApplicationState Execute(ApplicationState state, IAction action)
        {
            foreach (var reducer in this.reducers)
            {
                state = reducer.Execute(state, action);
            }

            return state;
        }
    }
}
