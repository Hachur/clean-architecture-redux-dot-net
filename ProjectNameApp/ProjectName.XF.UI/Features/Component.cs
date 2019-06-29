namespace ProjectName.XF.UI.Features
{
    using Xamarin.Forms;

    public abstract class Component<TPresenter> : ContentView where TPresenter : class
    {
        protected Component()
        {
            this.Presenter = App.Resolve<TPresenter>();
        }

        protected TPresenter Presenter
        {
            get;
            private set;
        }
    }
}
