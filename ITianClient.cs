using System.Threading.Tasks;

namespace TianYanCha.SDK
{
    public interface ITianClient
    {
        Task<TResponse> ExecuteAsync<TResponse>(IRequest<TResponse> request) where TResponse : TianResponse, new();

        TResponse Execute<TResponse>(IRequest<TResponse> request) where TResponse : TianResponse, new();
    }
}
