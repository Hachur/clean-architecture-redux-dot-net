namespace ProjectName.Presentation.IoC
{
    using Autofac;
    using Modules;

    public class PresentationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<UserModule>();
        }
    }
}