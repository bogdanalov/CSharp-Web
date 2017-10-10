﻿using WebServer.Server.Enums;

namespace WebServer.Server.HTTP.Contracts
{
    public interface IHttpResponse
    {
        IHttpHeaderCollection HeaderCollection { get; }

        IHttpCookieCollection CookieCollection { get; }

        HttpStatusCode StatusCode { get; }

        string StatusMessage { get; }

        string Response { get; }

        byte[] Data { get; }

        void AddHeader(string key, string value);
    }
}