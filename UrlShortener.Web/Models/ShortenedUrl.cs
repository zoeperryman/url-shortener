﻿using Cosmonaut;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener.Web.Models
{
    public class ShortenedUrl 
    {
        /// <summary>
        /// Url alias that gets added to the hostname
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The shortened url
        /// </summary>
        public string ShortUrl { get; set; }

        /// <summary>
        /// The long url that has beeb shortened
        /// </summary>
        public string LongUrl { get; set; }

    }
}
