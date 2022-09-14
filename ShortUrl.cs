using System;
using Microsoft.AspNetCore.WebUtilities;

namespace ShortUrl
{
    public class ShortUrlDto
    {
        public int Id { get; protected set; }
        public string Url { get; protected set; }
        public string UrlChunk => WebEncoders.Base64UrlEncode(BitConverter.GetBytes(Id));

        public ShortUrlDto(Uri url)
        {
            Url = url.ToString();
        }
    }


    public class UrlDto
    {
        public string Url { get; set; }

    }
}