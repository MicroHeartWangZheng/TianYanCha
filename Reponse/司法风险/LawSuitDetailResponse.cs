using Newtonsoft.Json;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class LawSuitDetailResponse
    {
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("judgeDate")]
		public string JudgeDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("judgeResult")]
		public string JudgeResult { get; set; }

		/// <summary>
		/// 杭州甘其食餐饮管理有限公司、杭州联创科讯网络科技有限公司、北京百度网讯科技有限公司商标权权属、侵权纠纷一审民事裁定书
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// （2019）浙0106民初9624号
		/// </summary>
		[JsonProperty("caseno")]
		public string Caseno { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("courtConsider")]
		public string CourtConsider { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("companies")]
		public List<CompaniesItem> Companies { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("plalongiffRequest")]
		public string PlalongiffRequest { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("judgetime")]
		public long Judgetime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("courtInspect")]
		public string CourtInspect { get; set; }

		/// <summary>
		///  原告杭州甘其食餐饮管理有限公司与被告杭州联创科讯网络科技有限公司、北京百度网讯科技有限公司商标权侵权及不正当竞争纠纷一案，本院于2019年11月5日立案。原告杭州甘其食餐饮管理有限公司在本院依法送达交纳诉讼费用通知后，未在七日内预交案件受理费。
		/// </summary>
		[JsonProperty("trialProcedure")]
		public string TrialProcedure { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("lawFirms")]
		public List<LawFirmsItem> LawFirms { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("plalongiffRequestOfFirst")]
		public string PlalongiffRequestOfFirst { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("defendantReplyOfFirst")]
		public string DefendantReplyOfFirst { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("trialPerson")]
		public string TrialPerson { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("plalongext")]
		public string Plalongext { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("appellor")]
		public string Appellor { get; set; }

		/// <summary>
		/// 杭州市西湖区人民法院
		/// </summary>
		[JsonProperty("court")]
		public string Court { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("courtConsiderOfFirst")]
		public string CourtConsiderOfFirst { get; set; }

		/// <summary>
		/// 裁定书
		/// </summary>
		[JsonProperty("doctype")]
		public string Doctype { get; set; }

		/// <summary>
		///  书　记　员　　黄惠瑾
		/// </summary>
		[JsonProperty("trialAssistPerson")]
		public string TrialAssistPerson { get; set; }

		/// <summary>
		/// 民事案件
		/// </summary>
		[JsonProperty("casetype")]
		public string Casetype { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("appellantRequest")]
		public string AppellantRequest { get; set; }

		/// <summary>
		/// 中国裁判文书网
		/// </summary>
		[JsonProperty("sourceName")]
		public string SourceName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("defendantReply")]
		public string DefendantReply { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("courtInspectOfFirst")]
		public string CourtInspectOfFirst { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("appelleeArguing")]
		public string AppelleeArguing { get; set; }
	}

	public class LawFirmsItem
	{
		/// <summary>
		/// 北京盈科（杭州）律师事务所
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class CompaniesItem
	{
		/// <summary>
		/// 杭州甘其食餐饮管理有限公司
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}
