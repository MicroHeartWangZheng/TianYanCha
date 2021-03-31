using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class PatentsResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("total")]
		public string Total { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("items")]
		public List<PatentsItem> Items { get; set; }
	}

	public class PatentsItem
	{
		/// <summary>
		/// 孟金喆
		/// </summary>
		[JsonProperty("agent")]
		public string Agent { get; set; }

		/// <summary>
		/// 自动驾驶车辆的故障确定方法及装置、设备及存储介质
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("patentNum")]
		public string PatentNum { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("pubnumber")]
		public string Pubnumber { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("applicationTime")]
		public DateTime? ApplicationTime { get; set; }

		/// <summary>
		/// ["北京百度网讯科技有限公司"]
		/// </summary>
		[JsonProperty("applicantname")]
		public string Applicantname { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("eventTime")]
		public string EventTime { get; set; }

		/// <summary>
		/// 王晓艳; 杨凯; 殷其娟; 王柏生; 曲宁; 陈卓
		/// </summary>
		[JsonProperty("inventor")]
		public string Inventor { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// 100085 北京市海淀区上地十街10号百度大厦2层
		/// </summary>
		[JsonProperty("address")]
		public string Address { get; set; }

		/// <summary>
		/// 北京品源专利代理有限公司 11332
		/// </summary>
		[JsonProperty("agency")]
		public DateTime? Agency { get; set; }

		/// <summary>
		/// 本发明实施例公开了一种自动驾驶车辆的故障确定方法及装置、设备及存储介质。所述方法包括：获取自动驾驶车辆上的至少三个控制系统中，两两之间心跳信号的检测结果；根据各所述检测结果，对所述控制系统进行故障识别。本发明实施例的技术方案解决了现有技术中难以准确确定主控系统和安全冗余系统是否发生故障的技术缺陷，实现了更加准确地对主控系统和安全冗余系统的故障情况做出判定。
		/// </summary>
		[JsonProperty("abstracts")]
		public string Abstracts { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("searchType")]
		public string SearchType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("connList")]
		public string ConnList { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("_type")]
		public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("lawStatus")]
		public List<PatentsLawStatusItem> LawStatus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("cat")]
		public string Cat { get; set; }

		/// <summary>
		/// 北京百度网讯科技有限公司
		/// </summary>
		[JsonProperty("applicantName")]
		public string ApplicantName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("pubDate")]
		public DateTime? PubDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("applicationPublishTime")]
		public DateTime? ApplicationPublishTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("appnumber")]
		public string Appnumber { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("patentType")]
		public string PatentType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("imgUrl")]
		public string ImgUrl { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("uni")]
		public string Uni { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("mainCatNum")]
		public string MainCatNum { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("createTime")]
		public string CreateTime { get; set; }

		/// <summary>
		/// 自动驾驶车辆的故障确定方法及装置、设备及存储介质
		/// </summary>
		[JsonProperty("patentName")]
		public string PatentName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("applicationPublishNum")]
		public string ApplicationPublishNum { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("allCatNum")]
		public string AllCatNum { get; set; }
	}

	public class PatentsLawStatusItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("date")]
		public DateTime? Date { get; set; }

		/// <summary>
		/// 授权
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}

