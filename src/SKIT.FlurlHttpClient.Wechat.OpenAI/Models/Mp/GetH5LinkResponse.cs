namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /geth5link/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class GetH5LinkResponse : WechatOpenAIResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public override int? ReturnCode { get; set; }

        /// <summary>
        /// 获取微信智能对话 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? ReturnMessage { get; set; }

        /// <summary>
        /// 获取或设置机器人链接 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public string Url { get; set; } = default!;
    }
}
