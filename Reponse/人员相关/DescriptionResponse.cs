using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class DescriptionResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("longroduction")]
		public string longroduction { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("weibo")]
		public string Weibo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("headUrl")]
		public string HeadUrl { get; set; }
	}
	
}

