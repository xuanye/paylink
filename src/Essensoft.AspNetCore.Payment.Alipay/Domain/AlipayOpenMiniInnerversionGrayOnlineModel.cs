using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionGrayOnlineModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionGrayOnlineModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 多个规则逗号分隔
        /// </summary>
        [JsonPropertyName("gray_rule")]
        public string GrayRule { get; set; }

        /// <summary>
        /// 租户code，alipay or taobao
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
