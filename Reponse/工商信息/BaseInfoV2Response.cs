using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TianYanCha.SDK.Extensions;

namespace TianYanCha.SDK.Reponse
{
    /// <summary>
    /// 企业基本信息（含企业联系方式）
    /// </summary>
    public class BaseInfoV2Response
    {
        /// <summary>
        /// 深圳发展银行股份有限公司（深圳发展银行
        /// </summary>
        [JsonProperty("historyNames")]
        public string HistoryNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("historyNameList")]
        public List<string> HistoryNameList { get; set; }

        /// <summary>
        /// 存续
        /// </summary>
        [JsonProperty("regStatus")]
        public string RegStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bondNum")]
        public string BondNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public long? Type { get; set; }

        /// <summary>
        /// 平安银行
        /// </summary>
        [JsonProperty("bondName")]
        public string BondName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("revokeReason")]
        public string RevokeReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("property3")]
        public string Property3 { get; set; }

        /// <summary>
        /// 深发展A->S深发展A->深发展A
        /// </summary>
        [JsonProperty("usedBondName")]
        public string UsedBondName { get; set; }


        public string ApprovedTime => Approved.ToDateTime();


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("approvedTime")]
        public long? Approved { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("orgNumber")]
        public string OrgNumber { get; set; }

        /// <summary>
        /// 办理人民币存、贷、结算、汇兑业务；人民币票据承兑和贴现；各项信托业务；经监管机构批准发行或买卖人民币有价证券；外汇存款、汇款；境内境外借款；在境内境外发行或代理发行外币有价证券；贸易、非贸易结算；外币票据的承兑和贴现；外汇放款；代客买卖外汇及外币有价证券，自营外汇买卖；资信调查、咨询、见证业务；保险兼业代理业务；黄金进口业务；经有关监管机构批准或允许的其他业务。(《保险兼业代理业务许可证》有效期限至2015年5月1日)
        /// </summary>
        [JsonProperty("businessScope")]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("regCapitalCurrency")]
        public string RegCapitalCurrency { get; set; }

        /// <summary>
        /// 中国500强	;	上市公司	;
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 平安银行股份有限公司
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("percentileScore")]
        public long? PercentileScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("isMicroEnt")]
        public long? IsMicroEnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cancelDate")]
        public string CancelDate { get; set; }

        /// <summary>
        /// 1142489.479万人民币
        /// </summary>
        [JsonProperty("regCapital")]
        public string RegCapital { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("staffNumRange")]
        public string StaffNumRange { get; set; }

        /// <summary>
        /// 货币金融服务
        /// </summary>
        [JsonProperty("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("revokeDate")]
        public string RevokeDate { get; set; }

        /// <summary>
        /// 谢永林
        /// </summary>
        [JsonProperty("legalPersonName")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("regNumber")]
        public string RegNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creditCode")]
        public string CreditCode { get; set; }


        public string FromTime => From.ToDateTime();
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fromTime")]
        public long? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("socialStaffNum")]
        public long? SocialStaffNum { get; set; }

        /// <summary>
        /// 银行股份
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 股份有限公司(上市)
        /// </summary>
        [JsonProperty("companyOrgType")]
        public string CompanyOrgType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("actualCapitalCurrency")]
        public string ActualCapitalCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cancelReason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("toTime")]
        public string ToTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("actualCapital")]
        public string ActualCapital { get; set; }

        public string EstiblishTime => Estiblish.ToDateTime();
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("estiblishTime")]
        public long? Estiblish { get; set; }

        /// <summary>
        /// 深圳市市场监督管理局
        /// </summary>
        [JsonProperty("regInstitute")]
        public string RegInstitute { get; set; }

        /// <summary>
        /// 深圳市罗湖区深南东路5047号
        /// </summary>
        [JsonProperty("regLocation")]
        public string RegLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("websiteList")]
        public string WebsiteList { get; set; }

        /// <summary>
        /// A股
        /// </summary>
        [JsonProperty("bondType")]
        public string BondType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("base")]
        public string Base { get; set; }

        /// <summary>
        /// 深圳市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 罗湖区
        /// </summary>
        [JsonProperty("district")]
        public string District { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("industryAll")]
        public IndustryAll IndustryAll { get; set; }
    }

    public class IndustryAll
    {
        /// <summary>
        /// 金融业
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 货币金融服务
        /// </summary>
        [JsonProperty("categoryBig")]
        public string CategoryBig { get; set; }

        /// <summary>
        /// 货币银行服务
        /// </summary>
        [JsonProperty("categoryMiddle")]
        public string CategoryMiddle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("categorySmall")]
        public string CategorySmall { get; set; }
    }
}