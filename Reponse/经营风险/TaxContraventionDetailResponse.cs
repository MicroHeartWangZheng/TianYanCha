using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
    public class TaxContraventionDetailResponse
    {
        /// <summary>
        /// 男
        /// </summary>
        [JsonProperty("legal_person_sex")]
        public string LegalPersonSex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("res_person_name")]
        public string ResPersonName { get; set; }

        /// <summary>
        /// 宁波保税区航晨塑化有限公司
        /// </summary>
        [JsonProperty("taxpayer_name")]
        public string TaxpayerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("companyGraphId")]
        public long CompanyGraphId { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [JsonProperty("legal_person_id_type")]
        public string LegalPersonIdType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("taxpayer_number")]
        public string TaxpayerNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("department")]
        public string Department { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("res_department_id_type")]
        public string ResDepartmentIdType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("res_person_id_type")]
        public string ResPersonIdType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("res_person_sex")]
        public string ResPersonSex { get; set; }

        /// <summary>
        /// 浙江省宁波保税区兴业大道8号1号楼153室
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("responsible_department")]
        public string ResponsibleDepartment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("res_department_name")]
        public string ResDepartmentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("taxpayer_code")]
        public string TaxpayerCode { get; set; }

        /// <summary>
        /// 经宁波国税第三稽查局检查，发现其在2015年01月01日至2015年12月31日期间，主要存在以下问题：非法取得增值税进项发票18份，金额173.45万元，税额29.49万元。 依照《中华人民共和国税收征收管理法》等相关法律法规的有关规定，对其处以追缴税款29.49万元的行政处理、处以罚款10.00万元的行政处罚，并依法移送司法机关。
        /// </summary>
        [JsonProperty("case_info")]
        public string CaseInfo { get; set; }

        /// <summary>
        /// 虚开增值税专用发票或者虚开用于骗取出口退税、抵扣税款的其他发票
        /// </summary>
        [JsonProperty("case_type")]
        public string CaseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("legal_person_id_number")]
        public string LegalPersonIdNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("res_department_sex")]
        public string ResDepartmentSex { get; set; }

        /// <summary>
        /// 叶祥勇
        /// </summary>
        [JsonProperty("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("res_person_id_number")]
        public string ResPersonIdNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("res_department_id_number")]
        public string ResDepartmentIdNumber { get; set; }
    }
}

