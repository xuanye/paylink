using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromotePageData Data Structure.
    /// </summary>
    public class PromotePageData : AlipayObject
    {
        /// <summary>
        /// 留资流水号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 留资属性实例数据列表
        /// </summary>
        [JsonPropertyName("property_list")]
        public List<PromotePagePropertyInstance> PropertyList { get; set; }
    }
}
