﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 账单 - 申请二级商户资金账单 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/bill/chapter3_5.shtml">账单 - 申请二级商户资金账单API</a> - 最新更新时间：2020.08.10</para>
    /// </remarks>
    public class WeChatPayEcommerceBillFundflowBillResponse : WeChatPayResponse
    {
        /// <summary>
        /// 下载信息总数
        /// </summary>
        /// <remarks>
        /// 下载信息总数
        /// 示例值：1
        /// </remarks>
        [JsonPropertyName("download_bill_count")]
        public int DownloadBillCount { get; set; }

        /// <summary>
        /// 下载信息明细
        /// </summary>
        /// <remarks>
        /// 下载信息明细
        /// </remarks>
        [JsonPropertyName("download_bill_list")]
        public List<DownloadBill> DownloadBillList { get; set; }
    }
}
