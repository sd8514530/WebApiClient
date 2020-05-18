﻿namespace WebApiClientCore.OAuths
{
    /// <summary>
    /// 表示账号密码身份信息
    /// </summary>
    public class PasswordCredentials : ClientCredentials
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}