namespace ProjectName.Presentation.Store
{
    using System.Collections.Generic;
    using Features.UserModule;
    using Features.UserModule.Store;
    using Redux;

    public class ApplicationState
    {
        public static IStore<ApplicationState> Store { get; private set; }

        public static void InitAppStore()
        {
            var reducer = CombineReducers.Create(new IReducer[]
            {
                new ApplicationReducer(),
                new UserReducer()
            });

            Store = new Store<ApplicationState>(reducer.Execute, InitialState());
        }

        public static ApplicationState InitialState()
        {
            return new ApplicationState
            {
                Users = new List<User>(),
                IsSearching = false
            };
        }

        public bool IsSearching { get; internal set; }

        public IEnumerable<User> Users { get; internal set; }

        public User SelectCurrentUser { get; internal set; }

        public string UserName { get; internal set; }
    }
}