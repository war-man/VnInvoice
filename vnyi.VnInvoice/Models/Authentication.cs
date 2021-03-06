﻿using Newtonsoft.Json;

namespace vnyi.VnInvoice.Models
{
    public class Authentication
    {
        /// <summary>
        ///     user đăng nhập vào vn-invoice
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        ///     mật khẩu của user
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        ///     domain dẫn tới ứng dụng
        /// </summary>
        [JsonProperty(PropertyName = "domainName")]
        public string DomainName { get; set; }
    }
}
