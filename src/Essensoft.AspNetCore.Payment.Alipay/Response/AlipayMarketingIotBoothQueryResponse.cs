using System.Text.Json.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingIotBoothQueryResponse.
    /// </summary>
    public class AlipayMarketingIotBoothQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用于链路埋点，识别权益触发链路
        /// </summary>
        [JsonPropertyName("booth_token")]
        public string BoothToken { get; set; }

        /// <summary>
        /// 展位结果列表
        /// </summary>
        [JsonPropertyName("content_list")]
        public List<IotContentModuleInfo> ContentList { get; set; }

        /// <summary>
        /// 渲染引擎类型
        /// </summary>
        [JsonPropertyName("engine_type")]
        public string EngineType { get; set; }
    }
}
