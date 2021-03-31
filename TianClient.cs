using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TianYanCha.SDK.Extensions;

namespace TianYanCha.SDK
{
    public class TianClient : ITianClient
    {

        private readonly HttpClient httpClient;
        private readonly TianOptions options;

        public TianClient(IHttpClientFactory httpClientFactory,
            IOptions<TianOptions> options)
        {
            httpClient = httpClientFactory.CreateClient();
            this.options = options.Value;
        }

        public async Task<TResponse> ExecuteAsync<TResponse>(IRequest<TResponse> request) where TResponse : TianResponse, new()
        {
            TResponse result;
            try
            {
                var requestMessage = new HttpRequestMessage()
                {
                    Method = request.GetHttpMethod(),
                    RequestUri = new Uri(GetRequestUri(request)),
                    Content = GetRequestContent(request),
                };
                if (!requestMessage.Headers.Contains("Authorization"))
                    requestMessage.Headers.Add("Authorization", options.Token);

                var responseMessage = await httpClient.SendAsync(requestMessage);
                var responseContent = await responseMessage.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<TResponse>(responseContent);
                result.RequestUri = requestMessage.RequestUri.AbsoluteUri;
                result.RequestBody = GetRequestBody(request);
                result.StatusCode = responseMessage.StatusCode;
                result.Headers = responseMessage.Headers;
                result.ResponseBody = responseContent;

                return result;
            }
            catch (Exception ex)
            {
                result = new TResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    ResponseBody = ex.Message
                };
                return result;
            }
        }

        public TResponse Execute<TResponse>(IRequest<TResponse> request) where TResponse : TianResponse, new()
        {
            TResponse result = null;
            try
            {
                var requestMessage = new HttpRequestMessage()
                {
                    Method = request.GetHttpMethod(),
                    RequestUri = new Uri(GetRequestUri(request)),
                    Content = GetRequestContent(request)
                };
                if (!requestMessage.Headers.Contains("Authorization"))
                    requestMessage.Headers.Add("Authorization", options.Token);

                var responseMessage = httpClient.SendAsync(requestMessage).Result;
                var responseContent = responseMessage.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<TResponse>(responseContent);
                result.RequestUri = requestMessage.RequestUri.AbsoluteUri;
                result.RequestBody = GetRequestBody(request);
                result.StatusCode = responseMessage.StatusCode;
                result.Headers = responseMessage.Headers;
                result.ResponseBody = responseContent;
                return result;
            }
            catch (Exception ex)
            {
                result = new TResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    ResponseBody = ex.Message
                };

                return result;
            }
        }

        /// <summary>
        /// 获取请求地址
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetRequestUri(IRequest request)
        {
            if (request.GetHttpMethod() == HttpMethod.Get)
                return options.BaseUrl + request.GetApiName() + "?" + request.GetParameters().ToSortQueryParameters();
            else
                return options.BaseUrl + request.GetApiName();
        }

        /// <summary>
        /// 获取请求发送数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetRequestBody(IRequest request)
        {
            if (request.GetHttpMethod() == HttpMethod.Get)
                return request.GetParameters().ToSortQueryParameters();
            else
                return string.Empty;
        }

        /// <summary>
        /// 获取请求发送的HttpContent.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public virtual HttpContent GetRequestContent(IRequest request)
        {
            return (string.IsNullOrWhiteSpace(MediaType) || request.GetHttpMethod() == HttpMethod.Get)
                ? new StringContent(string.Empty)
                : new StringContent(GetRequestBody(request), Encoding.UTF8, MediaType);
        }

        /// <summary>
        /// 获取数据提交的MediaType
        /// </summary>
        public virtual string MediaType => "";

    }
}
