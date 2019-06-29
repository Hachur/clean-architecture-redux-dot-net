namespace ProjectName.XF.UI
{
    using System;
    using Autofac;
    using ProjectName.Presentation.IoC;
    using ProjectName.Presentation.Store;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    public partial class App : Application
    {
        private static IContainer Container { get; set; }

        public App()
        {
            InitializeComponent();
            Startup();
            MainPage = new MainPage();
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        private static void Startup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<PresentationModule>();
            Container = builder.Build();
            ApplicationState.InitAppStore();
        }
    }
}
