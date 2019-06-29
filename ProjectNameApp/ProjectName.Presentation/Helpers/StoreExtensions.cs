namespace ProjectName.Presentation.Helpers
{
    using System;
    using System.Threading.Tasks;
    using Redux;

    public static class StoreExtensions
    {
        public delegate Task AsyncActionsCreator<TState>(Dispatcher dispatcher, Func<TState> getState);

        public delegate void ActionsCreator<TState>(Dispatcher dispatcher, Func<TState> getState);

        public static Task DispatchAsync<TState>(this IStore<TState> store, AsyncActionsCreator<TState> actionsCreator)
        {
            return actionsCreator(store.Dispatch, store.GetState);
        }

        public static void Dispatch<TState>(this IStore<TState> store, ActionsCreator<TState> actionsCreator)
        {
            actionsCreator(store.Dispatch, store.GetState);
        }
    }
}
