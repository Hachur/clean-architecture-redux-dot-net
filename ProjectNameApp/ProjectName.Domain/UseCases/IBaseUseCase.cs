namespace ProjectName.Domain.UseCases
{
    using System.Threading.Tasks;

    public interface IBaseUseCase<T>
    {
        Task<T> ExecuteAsync();
    }
}
