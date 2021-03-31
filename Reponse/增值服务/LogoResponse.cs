using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class LogoResponse
	{
		/// <summary>
		/// logourl
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }
	}
}

