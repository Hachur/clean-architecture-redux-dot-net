namespace ProjectName.Domain.UseCases
{
    using System.Threading.Tasks;

    public interface IBaseParamUseCase<T, TParams>
    {
        Task<T> ExecuteAsync(TParams p);
    }
}
