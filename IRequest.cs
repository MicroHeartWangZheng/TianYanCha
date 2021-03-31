using System.Collections.Generic;
using System.Net.Http;

namespace TianYanCha.SDK
{
    public interface IRequest
    {
        /// <summary>
        /// 获取API名称。
        /// </summary>
        string GetApiName();


        IDictionary<string, object> GetParameters();

        /// <summary>
        /// 获取请求提交的方法
        /// </summary>
        /// <returns></returns>
        HttpMethod GetHttpMethod();
    }

    public interface IRequest<TResponse> : IRequest where TResponse : TianResponse, new()
    {

    }
}
