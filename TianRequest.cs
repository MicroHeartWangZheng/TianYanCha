using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace TianYanCha.SDK
{
    public abstract class TianRequest<TResponse> : IRequest<TResponse> where TResponse : TianResponse, new()
    {
        /// <summary>
        /// 获取API名称
        /// </summary>
        /// <returns></returns>
        public abstract string GetApiName();

        public virtual IDictionary<string, object> GetParameters()
        {
            IDictionary<string, object> parameters = null;
            if (parameters != null)
                return parameters;

            var properties = this.GetType().GetProperties();
            return properties.ToDictionary(m => ((JsonPropertyAttribute)m.GetCustomAttributes(typeof(JsonPropertyAttribute), false).First()).PropertyName, n => n.GetValue(this, null));
        }

        /// <summary>
        /// 获取请求提交的方法
        /// </summary>
        /// <returns></returns>
        public abstract HttpMethod GetHttpMethod();
    }
}
