namespace ProjectName.Presentation.Features.Utils
{
    public abstract class BasePresenter<TView> : IBasePresenter where TView : IBaseView
    {
        public TView View
        {
            protected get;
            set;
        }

        public abstract void Start();

        public abstract void Stop();
    }
}
